using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class Connection
{
    public string connString = "Data Source=ProjectsV13;Initial Catalog=DentistryDatabase;Integrated Security=True;Pooling=False;Connect Timeout=30";

    public SqlConnection SqlConn;
    public SqlCommand sqlComm;
    public SqlDataAdapter sqlAdap;
    public DataSet dataSet;
    public SqlDataReader DR;
    
    public Connection()
    {
        //add constructor logic
    }

}