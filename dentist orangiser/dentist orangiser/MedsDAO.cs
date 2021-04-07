using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class MedsDAO
{
    Connection c = new Connection();

    public MedsDAO()
    {
        c.SqlConn = new SqlConnection(c.connString);
        c.SqlConn.Open();
    }

    public DataSet getMedicine()
    {
        string query = "select * from Medicine";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return c.dataSet;
    }

    public SqlDataReader getMedicineNames()
    {
        string query = "select Name from Medicine";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public DataSet getMedicineInfo(string name)
    {
        string query = "select * from Medicine where Name ='" + name + "'";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return c.dataSet;
    }

    public bool update(MedsDTO m)
    {
        string query = "update Medicine set Quantity=" + m.QUANTITY + ", Price=" + m.PRICE + ", Supplier='" + m.SUPPLIER + "' where Name='" + m.NAME + "'";
        try
        {
            c.sqlComm = new SqlCommand(query, c.SqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.SqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
            c.SqlConn.Close();
            return false;
        }
    }

    public bool add(MedsDTO m)
    {
        try
        {
            string query = "insert into Medicine (Name, Quantity, Price, Supplier) values ('" + m.NAME + "'," + m.QUANTITY + "," + m.PRICE + ",'" + m.SUPPLIER + "')";
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