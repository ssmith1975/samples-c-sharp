using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebFormsClient
{
    public partial class _Default : Page
    {


        protected void Button1_Click(object sender, EventArgs e)
        {
           var client = new WebServicesSample.SampleServiceSoapClient();
           TextBox2.Text = client.ReverseString(TextBox1.Text);
        }
    }
}