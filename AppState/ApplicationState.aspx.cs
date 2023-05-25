using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplicationState : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = 0;
        if (Application["visit"] != null)
        {
            count = Convert.ToInt32(Application["visit"].ToString());
        }
        count = count + 1;
        Application["visit"] = count;
        Label1.Text = "This page is been visited for <b>    " + count.ToString() + "  </b>times";
    }
   
}