using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DoctorDTO
{
    private string name;
    private int docId, salary;
    private bool available;
    public string NAME
    {
        get { return name; }
        set { name = value; }
    }
    public int DOCID
    {
        get { return docId; }
        set { docId = value; }
    }
    public int SALARY
    {
        get { return salary; }
        set { salary = value; }
    }
    public bool AVAILABLE
    {
        get { return available; }
        set { available = value; }
    }

    public DoctorDTO(string name, int docId, int salary, bool available)
    {
        this.name = name;
        this.docId = docId;
        this.salary = salary;
        this.available = available;
    }


}