using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class DoctorDAO
{
    Connection c = new Connection();
    public DoctorDAO()
    {
        c.SqlConn = new SqlConnection(c.connString);
        c.SqlConn.Open();
    }

    public SqlDataReader getDoctors()
    {
        string query = "select Name from doctor where Available=1";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public SqlDataReader getDoctors2()
    {
        string query = "select Name from doctor";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public int getID(string name)
    {
        string query = "select DocId from doctor where Name='" + name + "'";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return Convert.ToInt32(c.dataSet.Tables[0].Rows[0][0]);
    }

    public DataSet getDocs()
    {
        string query = "select * from doctor";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return c.dataSet;
    }

    public DataSet getInfo(string name)
    {
        string query = "select * from doctor where name='" + name + "'";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return c.dataSet;
    }

    public bool update(DoctorDTO d)
    {
        int s = 0;
        if (d.AVAILABLE == true) s = 1;
        string query = "update doctor set Name='" + d.NAME + "', Salary=" + d.SALARY + ", Available =" + s + " where DocId=" + d.DOCID;
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

    public bool add(DoctorDTO d)
    {
        int s = 0;
        if (d.AVAILABLE == true) s = 1;
        try
        {
            string query = "insert into doctor (Name, Salary, Available) values ('" + d.NAME + "'," + d.SALARY + "," + s + ")";
            c.sqlComm = new SqlCommand(query, c.SqlConn);
            c.sqlComm.ExecuteNonQuery();
            for (int i = 0; i < 7; i++)
            {
                new AppointmentDAO().addNew(d.NAME, DateTime.Today.AddDays(i).ToString("dd-MM-yyyy"));
            }
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