using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PecificSchoolOfLow
{
    public partial class insertdetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1AT9VT2\SQLEXPRESS;Initial Catalog=Webform1;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                data_ins();
                empty();
                if((ex.Message) != "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Mail has been sent succesfully')", true);
                }
                
            }
            else 
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Mail has not been sent')", true);
            }
        }
        public void empty()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }
        public void data_ins()
        {
            if (con.State == ConnectionState.Open)
            { 
            con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "Insert into Table_1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) {

                Label6.Text = "Please enter a valid mobile number" + ex.Message;
                Label6.ForeColor=System.Drawing.Color.Red;

            }               
            con.Close();            
        }


    }
}