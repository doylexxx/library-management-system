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
    /// <returns></returns>
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
    /// 执行返回单个值的SQL语句。如果返回null，表示无结果<para/>
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
    public enum LoginStatus { Success, Wrong, NotExist };

    /// <summary>
    /// 实现管理员登录功能。
    /// </summary>
    /// <param name="id">管理员ID</param>
    /// <param name="password">密码</param>
    /// <returns></returns>
    public LoginStatus Login(string id, string password)
    {
        string query = string.Format(
            "select password from admin where ano = '{0}'",id);
        string pass = ExecScalarQuery(query) as string;

        if (pass == null) return LoginStatus.NotExist;
        else if (pass == password)
        {
            admin = id;
            return LoginStatus.Success;
        }
        else return LoginStatus.Wrong;
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
    /// 显示该借书证所有已借书籍 (返回, 格式同查询模块)
    /// </summary>
    public DataSet ListBorrow(string cno)
    {
        string query = string.Format(@"
select * from book
where title in(
    select title
    from borrow join book on borrow.bno = book.bno
    where borrow.cno = '{0}'
    ) and return_date is null"
            , cno);
        return SQL(query);
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
    public void Return(string cno, string book)
    {
        var trans = BeginTransaction();
        try
        {
            // TODO return

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
            ExecNoneQuery(cmd);
        }
        catch(Exception)
        {
            MessageBox.Show("Delete Failed! ");
        }
    }

}
