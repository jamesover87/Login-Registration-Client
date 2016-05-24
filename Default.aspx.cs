﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Login();
    }

    protected void Login()
    {
        ServiceReference1.LoginServiceClient rs =
            new ServiceReference1.LoginServiceClient();
        int key = rs.VenueLogin(UserTextBox.Text, PassTextBox.Text);
        if(key != 0)
        {
            ErrorLabel.Text = "Welcome";
            Session["Userkey"] = key;
            Response.Redirect("Addshow.aspx");
        }
        else
        {
            ErrorLabel.Text = "Invalid Login";
        }
    }
}