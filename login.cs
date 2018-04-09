using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

namespace cafemanagement
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Required");
            }
            else if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Required");
            }

            else if (comboBox1.Text == "User")
            {
                
                cn.Open();
                SqlCommand cmd = new SqlCommand("select [username],password,Emailid from [registration] where [Emailid]='" + textBox1.Text + "' and password='" + textBox2.Text + "' and status='Approved'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (textBox1.Text == dr[0].ToString() || textBox2.Text == dr[1].ToString())
                    {
                        this.Hide();
                        FileSplitter.Master e1 = new FileSplitter.Master(textBox1.Text);
                        e1.Show();                     
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                cn.Close();
                
            }
            else if (comboBox1.Text == "Admin")
            {


                if (textBox1.Text == "admin" || textBox2.Text == "admin")
                {
                    this.Hide();
                    FileSplitter.Admin.Adminmaster ma = new FileSplitter.Admin.Adminmaster();
                    ma.Show();


                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                cn.Close();

            }
        }

        save s = new save();
        
        private void Login_Load(object sender, EventArgs e)
        {

        }
        public string SendEmail(string toAddress, string subject, string body)
        {
            string result = "Message Sent Successfully..!!";
            string senderID = "hahuja2612@gmail.com";// use sender’s email id here..
            const string senderPassword = "jmdrocks"; // sender password here…
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // smtp server address here…
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,
                };
                MailMessage message = new MailMessage(senderID, toAddress, subject, body);
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                result = "Error sending email.!!!";
            }
            return result;
        }

       
    }
}
