using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {

                Button btn = new Button();
               
                btn.Text = rnd.Next(1, 999).ToString();
                btn.Attributes.Add("onclick", "cside('" + btn.Text +"')");
                div2.Controls.Add(btn);
              
            }



        }




        [System.Web.Services.WebMethod]
       public static  void yazdir(string ID)
        {
            Button lbl = new Button();
            lbl.Text = "FROM ME : " + ID;
            Page frm = HttpContext.Current.Handler as Page;
            frm.FindControl("div2").Controls.Add(lbl);
          
        }
    }
}