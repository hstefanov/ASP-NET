using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstAspNetWebForms
{
    public partial class About : Page
    {
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            this.Label1.Text = this.Calendar1.SelectedDate.ToShortDateString();
            //this.Label1.Text += Environment.NewLine + ConfigurationSettings.AppSettings["GmailPassword"].ToString();        }
        }
    }
}