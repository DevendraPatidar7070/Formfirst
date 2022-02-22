using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
namespace PecificSchoolOfLow
{
    public partial class form1aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("dsp.insta2210sa@gmail.com", "Insta@1005");
                    MailMessage msgobj = new MailMessage();
                    msgobj.To.Add(TextBox2.Text);
                    msgobj.From = new MailAddress("dsp.insta2210sa@gmail.com");
                    msgobj.Subject = TextBox3.Text;
                    msgobj.Body = TextBox4.Text;
                    client.Send(msgobj);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Mail has been sent succesfully')", true);
                    Response.Write("Mail has been sent succesfully");
                }
            }
            catch(Exception ex){
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Mail has been sent succesfully'+'ex.Message')", true);
            }


        }
    }
}