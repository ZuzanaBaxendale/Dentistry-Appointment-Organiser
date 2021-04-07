using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class AdminDTO
{
    private string user = "";
    private string password = "";

    public AdminDTO(string user, string password)
    {
        this.user = user;
        this.password = password;
    }

    public string USER
    {
        get { return user; }
        set { user = value; }
    }

    public string PASSWORD
    {
        get { return password; }
        set { password = value; }
    }
}