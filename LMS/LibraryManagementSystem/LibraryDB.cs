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

    string msg = "";
    public string Message
    {
        get { return msg; }
    }

    // SQL Basics

    public LibraryDB(string DSN, string UID, string PWD)
    {
        string strConn = string.Format("DSN={0};UID={1};PWD={2}", DSN, UID, PWD);
        conn = new OdbcConnection(strConn);
        conn.Open();
        string useLib = "use LMS";
        ocmd = new OdbcCommand(useLib, conn);
        ocmd.ExecuteNonQuery();
    }

    public DataSet SQL(string query)
    {
        try
        {
            var adapter = new OdbcDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        catch (Exception)
        {
            return new DataSet();
        }
    }

    private int ExecNoneQuery(string command)
    {
        ocmd.CommandText = command;
        return ocmd.ExecuteNonQuery();
    }

    private object ExecScalarQuery(string command)
    {
        ocmd.CommandText = command;
        return ocmd.ExecuteScalar();
    }

    //------------------------
    public enum LoginStatus { Success, Wrong, NotExist };

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

    public void AddBook(string book)
    {

    }

    public void AddCard(string cno, string name, string dep, string type)
    {
        try
        {
            string strConn = string.Format("DSN=Library;UID=sa;PWD=111");
            conn = new OdbcConnection(strConn);
            conn.Open();
            string useLib = "use LMS";
            ocmd = new OdbcCommand(useLib, conn);
            ocmd.ExecuteNonQuery();
            useLib = "insert into card(cno,name,department,type) values('" + cno + "','" + name + "','" + dep + "','" + type + "')";
            ocmd = new OdbcCommand(useLib, conn);
            ocmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception)
        {
            MessageBox.Show("Uncorrect format! Please confirm the information. ");
        }
    }

    public void DeleteCard(string cno)
    {
        try
        {
            string strConn = string.Format("DSN=Library;UID=sa;PWD=111");
            conn = new OdbcConnection(strConn);
            conn.Open();
            string useLib = "use LMS";
            ocmd = new OdbcCommand(useLib, conn);
            ocmd.ExecuteNonQuery();
            useLib = "delete from card where cno = '" + cno + "'";
            ocmd = new OdbcCommand(useLib, conn);
            ocmd.ExecuteNonQuery();
            conn.Close();
        }
        catch(Exception)
        {
            MessageBox.Show("Delete Failed! ");
        }
    }

    public string[] ListBorrow(string cno)
    {
        string[] ret = new string[0];
        string query = string.Format(@"
select title
from borrow join book on borrow.bno = book.bno
where borrow.cno = '{0}'", cno);

        return ret;
    }
}
