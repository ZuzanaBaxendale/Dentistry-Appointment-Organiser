using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class AppointmentDTO
{
    string name, time, date;
    int id;

    public string NAME
    {
        get { return name; }
        set { name = value; }
    }

    public string TIME
    {
        get { return time; }
        set { time = value; }
    }

    public string DATE
    {
        get { return date; }
        set { date = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public AppointmentDTO(string name, string date)
    {
        this.name = name;
        this.date = date;
    }

    public AppointmentDTO(string name, string date, string time, int id)
    {
        this.name = name;
        this.date = date;
        this.time = time;
        this.id = id;
    }
}