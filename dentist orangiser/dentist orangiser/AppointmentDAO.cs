using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class AppointmentDAO
{
    Connection c = new Connection();

    public AppointmentDAO()
    {
        c.SqlConn = new SqlConnection(c.connString);
    }

    public bool rowsExist()
    {
        c.SqlConn.Open();
        string query = "select * from Appointment";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        if (c.dataSet.Tables[0].Rows.Count == 0) return false;
        else return true;
    }

    public void addRows()
    {
        c.SqlConn.Open();
        string query = "", date = "", name = "";
        SqlDataReader dr = new DoctorDAO().getDoctors();
        while (dr.Read())
        {
        name = dr[0].ToString();
        for (int i = 0; i < 7; i++)
        {
        date = System.DateTime.Today.AddDays(i).ToString("dd-MM-yyyy");
        query = "INSERT INTO Appointment (Name, Date) values ('" + name + "','" + date + "')";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlComm.ExecuteNonQuery();
        }
        }
        c.SqlConn.Close();
    }

    public DataSet getRow(AppointmentDTO a)
    {
        c.SqlConn.Open();
        string query = "select * from Appointment where Name='" + a.NAME + "' and Date='" + a.DATE + "'";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return c.dataSet;
    }

    public bool getAppointment(AppointmentDTO a)
    {
        c.SqlConn.Open();
        string query = "update Appointment set [" + a.TIME + "]=" + a.ID + " where Name='" + a.NAME + "' and Date='" + a.DATE + "'";
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

    public bool prevDay(int i)
    {
        string date = DateTime.Today.AddDays(-i).ToString("dd-MM-yyyy");
        string query = "select * from Appointment where Date='" + date + "'";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        if (c.dataSet.Tables[0].Rows.Count == 0) return false;
        else return true;
    }

    public void adjust()
    {
        for (int i = 1; i < 6; i++)
        {
            if (prevDay(i))
            {
                c.SqlConn.Open();
                string date = DateTime.Today.AddDays(-i).ToString("dd-MM-yyyy");
                string query = "Delete from Appointment where Date='" + date + "'";
                string name = "";
                c.sqlComm = new SqlCommand(query, c.SqlConn);
                c.sqlComm.ExecuteNonQuery();
                SqlDataReader dr = new DoctorDAO().getDoctors2();
                while (dr.Read())
                {
                   name = dr[0].ToString();
                    date = System.DateTime.Today.AddDays(i).ToString("dd-MM-yyyy");
                    query = "INSERT INTO Appointment (Name, Date) values ('" + name + "','" + date + "')";
                    c.sqlComm = new SqlCommand(query, c.SqlConn);
                    c.sqlComm.ExecuteNonQuery();
                }
            }
        }
    }

    public string[] find(int id)
    {
        c.SqlConn.Open();
        string query = "";
        int i;
        string[] d = new string[] { "", "", "" };
        string[] times = new string[] { "9:00am", "9:30am", "10:00am", "10:30am", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm", "7:30pm", "8:00pm", "8:30pm" };
        for (i = 0; i < 12; i++)
        {
            query = "select * from Appointment where [" + times[i] + "]=" + id + "";
            c.sqlComm = new SqlCommand(query, c.SqlConn);
            c.sqlAdap = new SqlDataAdapter(c.sqlComm);

            c.dataSet = new DataSet();
            c.sqlAdap.Fill(c.dataSet);
            if (c.dataSet.Tables[0].Rows.Count > 0) break;
        }
        if (c.dataSet.Tables[0].Rows.Count > 0)
        {
            d[0] = c.dataSet.Tables[0].Rows[0]["Name"].ToString();
            d[1] = c.dataSet.Tables[0].Rows[0]["Date"].ToString();
            d[2] = times[i];
        }
        return d;
    }

    public bool delete(AppointmentDTO a)
    {
        c.SqlConn.Open();
        string query = "update Appointment set [" + a.TIME + "]= 0 where Name='" + a.NAME + "' and Date='" + a.DATE + "'";
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

    public DataSet appList()
    {
        c.SqlConn.Open();
        string query = "select * from Appointment";

        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.SqlConn.Close();
        return c.dataSet;
    }

    public void addNew(string name, string date)
    {
        c.SqlConn.Open();
        string query = "INSERT INTO Appointment (Name, Date) values ('" + name + "','" + date + "')";
        c.sqlComm = new SqlCommand(query, c.SqlConn);
        c.sqlComm.ExecuteNonQuery();
        c.SqlConn.Close();
    }
}