using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class AdminDAO
{
    Connection c = new Connection();

    public AdminDAO()
    {
        c.SqlConn = new SqlConnection(c.connString);
        c.SqlConn.Open();
    }

    public bool verifyAdmin(string user, string password)
    {
        string query = "select * from admin where username = '" + user + "' and password = '" + password + "'";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        if (c.dataSet.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    public bool changePassword(string user, string password, string newPassword)
    {
        if (this.verifyAdmin(user, password))
        {
            c.SqlConn.Open();
            string query = "update admin set password='" + newPassword + "' where username='" + user + "'";

            c.sqlComm = new SqlCommand(query, c.SqlConn);
            c.sqlAdap.Fill(c.dataSet);
            c.SqlConn.Close();
            return true;
        }
        else return false;
    }

    public bool addAdmin(AdminDTO a)
    {
        try
        {
            c.SqlConn.Open();
            string query = "insert into admin (username, password) values ('" + a.USER + "', '" + a.PASSWORD + "')";

            c.sqlComm = new SqlCommand(query, c.SqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.SqlConn.Close();
        return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
            return false;
        }
    }
}