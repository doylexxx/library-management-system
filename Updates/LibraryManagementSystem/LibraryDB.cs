using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

public class LibraryDB
{
    OdbcConnection conn;
    OdbcCommand ocmd;
    string admin;

    public const int MaxBorrow = 3;
    public const int BorrowDays = 60;
    public const int TopN = 50;

    // Last Executed SQL command
    string lastexec = "";
    public string LastExecuted
    {
        get { return lastexec.Trim(); }
    }

    // SQL Basics
    
    /// <summary>
    /// 建立并初始化LibrayDB连接
    /// </summary>
    /// <param name="DSN">数据源名称</param>
    /// <param name="UID">登录名</param>
    /// <param name="PWD">密码</param>
    public LibraryDB(string DSN, string UID, string PWD)
    {
        try
        {
            string strConn = string.Format("DSN={0};UID={1};PWD={2}", DSN, UID, PWD);
            conn = new OdbcConnection(strConn);
            conn.Open();
            lastexec = "use Library";
            ocmd = new OdbcCommand(lastexec, conn);
            ocmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }

    /// <summary>
    /// 执行SQL语句，返回SQL语句的执行结果。<para/>
    /// 若执行的语句不是select，或出现错误，返回空表。
    /// </summary>
    /// <param name="query">需要执行的SQL语句</param>
    /// <returns>SQL语句的执行结果</returns>
    public DataSet SQL(string query)
    {
        lastexec = query;
        try
        {
            var adapter = new OdbcDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return new DataSet();
        }
    }

    /// <summary>
    /// 新建ODBC事件
    /// </summary>
    private OdbcTransaction BeginTransaction()
    {
        var trans = conn.BeginTransaction();
        ocmd.Transaction = trans;
        return trans;
    }

    /// <summary>
    /// 执行非查询SQL语句（insert, update, delete），返回值为受影响的行数
    /// </summary>
    /// <param name="command">非查询SQL语句</param>
    private int ExecNoneQuery(string command)
    {
        lastexec = command;
        ocmd.CommandText = command;
        return ocmd.ExecuteNonQuery();
    }

    /// <summary>
    /// 执行返回单个值的SQL语句。如果返回DBNull.Value，说明结果为（数据库）null。
    /// 如果返回（C#）null，表示查询结果为空表<para/>
    /// 返回结果需要使用类型转换。如"ExecScalarQuery(command) as string"得到string结果。
    /// 转换失败亦会得到null。
    /// </summary>
    /// <param name="command">返回单个值的SQL语句</param>
    private object ExecScalarQuery(string command)
    {
        lastexec = command;
        ocmd.CommandText = command;
        return ocmd.ExecuteScalar();
    }

    //------------------------
    /// <summary>
    /// 登录状态
    /// </summary>
    public enum LoginStatus { Success, Wrong, NotExist, Error };

    /// <summary>
    /// 实现管理员登录功能。
    /// </summary>
    /// <param name="id">管理员ID</param>
    /// <param name="password">密码</param>
    /// <returns></returns>
    public LoginStatus Login(string id, string password)
    {
        try
        {
            string query = string.Format(
                "select password from admin where ano = '{0}'", id);
            string pass = ExecScalarQuery(query) as string;

            if (pass == null) return LoginStatus.NotExist;
            else if (pass == password)
            {
                admin = id;
                return LoginStatus.Success;
            }
            else return LoginStatus.Wrong;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return LoginStatus.Error;
        }
    }

    /// <summary>
    /// 实现单本图书入库功能。返回值表示入库成功/失败。（未测试）
    /// </summary>
    /// <param name="book">图书信息</param>
    /// <returns></returns>
    public bool AddBook(string book)
    {
        string[] bn = book.Substring(1, book.Length - 2).Split(',');
        if (bn.Length < 8) return false;
        DataSet ds = SQL(string.Format("select * from book where bno = '{0}'", bn[0]));
        // 该书已存在，执行更新操作
        if (ds.Tables.Count != 0)
        {
            for (int i = 1; i <= 6; i++)
            {
                // 信息不匹配
                if (ds.Tables[0].Rows[0][i].ToString() != bn[i])
                    return false;
            }
            int ret = ExecNoneQuery(string.Format(@"
update book
set total = total + {1}, stock = stock + {1}
where bno = '{0}'"
                , bn[0], bn[7]));
            return ret == 1;
        }
        // 该书不存在，执行插入操作
        string sql = string.Format(@"
insert into book
values('{0}','{1}','{2}','{3}',{4},'{5}',{6},{7},{7})"
            , bn);
        return ExecNoneQuery(sql) == 1;
    }

    /// <summary>
    /// 批量添加书籍（框架）
    /// </summary>
    /// <param name="filename">文件名</param>
    /// <returns></returns>
    public int AddBooks(string filename)
    {
        var trans = BeginTransaction();
        try
        {
            int count = 0;

            // TODO 批量添加

            trans.Commit();
            return count;
        }
        catch (Exception)
        {
            trans.Rollback();
            return 0;
        }
    }

    /// <summary>
    /// 实现图书查询功能（框架）
    /// </summary>
    /// <returns></returns>
    public DataSet BookSearch()
    {
        // TODO 查询
        return new DataSet();
    }

    /// <summary>
    /// 显示该借书证所有已借书籍 (返回, 格式同查询模块)
    /// </summary>
    public DataSet ListBorrow(string cno)
    {
        string query = string.Format(@"
select * from book
where title in(
    select title
    from borrow join book on borrow.bno = book.bno
    where borrow.cno = '{0}' and return_date is null)"
            , cno);
        return SQL(query);
    }

    /// <summary>
    /// 查询借书证已借书籍数目，-1表示查询失败
    /// </summary>
    /// <param name="cno"></param>
    /// <returns></returns>
    public int CountBorrow(string cno)
    {
        try
        {
            string query = string.Format(
                "select count(*) from borrow where cno = '{0}' and return_date is null", cno);
            int? ret = ExecScalarQuery(query) as int?;
            return ret ?? -1;
        }
        catch (Exception)
        {
            return -1;
        }
    }

    /// <summary>
    /// 查询库存。-1表示查询失败
    /// </summary>
    /// <param name="bno"></param>
    /// <returns></returns>
    public int BookStock(string bno)
    {
        try
        {
            string query = string.Format(
                "select stock from book where bno = '{0}'", bno);
            int? ret = ExecScalarQuery(query) as int?;
            return ret ?? -1;
        }
        catch (Exception)
        {
            return -1;
        }
    }

    /// <summary>
    /// 一本书的的最早归还时间
    /// </summary>
    /// <param name="bno"></param>
    /// <returns></returns>
    public string EarliestReturn(string bno)
    {
        string query = string.Format(@"
select min(earliest) from(
    select dateadd(day,{0},borrow_date) as earliest from borrow
    where bno = '{1}') as T
--where earliest >= getdate()"
            , BorrowDays, bno);
        try
        {
            var ret = ExecScalarQuery(query);
            if (ret == DBNull.Value) return null;
            else return ret.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return null;
        }
    }

    /// <summary>
    /// 判断借书证是否结果某本书
    /// </summary>
    /// <param name="cno"></param>
    /// <param name="bno"></param>
    /// <returns></returns>
    public bool Borrowed(string cno, string bno)
    {
        string check = string.Format(@"
select bno from borrow
where cno = '{0}' and bno = '{1}' and return_date is null"
                , cno, bno);
        var ret = ExecScalarQuery(check);
        return ret != null;
    }

    /// <summary>
    /// 实现借书功能。（执行该函数前需先执行ListBorrow）
    /// </summary>
    public void Borrow(string cno, string bno)
    {
        var trans = BeginTransaction();
        try
        {
            string update = string.Format(@"
update book set stock = stock - 1
where bno = '{0}'"
                , bno);

            string insert = string.Format(@"
insert into borrow
values('{0}', '{1}', getdate(), null, '{2}')"
                , cno, bno, admin);
            
            ExecNoneQuery(update);
            ExecNoneQuery(insert);
            trans.Commit();
        }
        catch (Exception ex)
        {
            trans.Rollback();
            MessageBox.Show(ex.Message);
        }
    }

    /// <summary>
    /// 实现还书功能。（执行该函数前需先执行ListBorrow）(框架)
    /// </summary>
    public void Return(string cno, string bno)
    {
        var trans = BeginTransaction();
        try
        {
            // TODO return
            string update_book = string.Format(@"
            update book set stock = stock + 1
            where bno = '{0}'" , bno);
            string update_borrow = string.Format(@"
            update borrow set return_date = getdate()
            where bno = '{0}'and cno='{1}'", bno,cno);
            trans.Commit();
        }
        catch (Exception ex)
        {
            trans.Rollback();
            MessageBox.Show(ex.Message);
        }
    }

    /// <summary>
    /// 实现添加借书证功能。
    /// </summary>
    public void AddCard(string cno, string name, string dep, char type)
    {
        try
        {
            string cmd = string.Format(
                "insert into card values('{0}','{1}','{2}','{3}')",cno, name, dep, type);
            ExecNoneQuery(cmd);
        }
        catch (Exception)
        {
            MessageBox.Show("Uncorrect format! Please confirm the information. ");
        }
    }

    /// <summary>
    /// 实现删除借书证功能。（功能未完善）
    /// </summary>
    public void DeleteCard(string cno)
    {
        try
        {
            // TODO 判断能否删除

            string cmd = string.Format(
                "delete from card where cno = '{0}'", cno);
            if (ExecNoneQuery(cmd) == 0)
            {
                MessageBox.Show("No such card!");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Delete Failed! ");
        }
    }

}
