using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

namespace FileSplitter
{
    public partial class Download : Form
    {SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);
        public Download(string name)
        {
            InitializeComponent();
            label1.Text = name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public static string DownloadFile(string FtpUrl, string FileNameToDownload,
                        string userName, string password, string tempDirPath)
        {
            string ResponseDescription = "";
            string PureFileName = new FileInfo(FileNameToDownload).Name;
            string DownloadedFilePath = tempDirPath + "/" + PureFileName;
            string downloadUrl = String.Format("{0}/{1}", FtpUrl, FileNameToDownload);
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(downloadUrl);
            req.Method = WebRequestMethods.Ftp.DownloadFile;
            req.Credentials = new NetworkCredential(userName, password);
            req.UseBinary = true;
            req.Proxy = null;
            try
            {
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                Stream stream = response.GetResponseStream();
                byte[] buffer = new byte[2048];
                FileStream fs = new FileStream(DownloadedFilePath, FileMode.Create);
                int ReadCount = stream.Read(buffer, 0, buffer.Length);
                while (ReadCount > 0)
                {
                    fs.Write(buffer, 0, ReadCount);
                    ReadCount = stream.Read(buffer, 0, buffer.Length);
                }
                ResponseDescription = response.StatusDescription;
                fs.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ResponseDescription;
        }

        private void Download_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                label2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                string filename=Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                string ftplocation = "ftp://107.180.1.81";
                //string file = lblfilepath.Text; // Or on FreeBSD: "/usr/home/jared/test2.txt";
                string user = "lbsim";
                string password = "sim@9599929953";
                //UploadToFTP(ftplocation, file, user, password);
                DownloadFile(ftplocation, filename, user, password, @"E:\");               
                MessageBox.Show("File Successfully Downloaded");
            }
                  
        }
        protected string SendEmail(string toAddress, string subject, string body)
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string query = "select Registration.Emailid,FileDetails.Uploadedby,filedetails.Filename from registration inner join FileDetails on Registration.emailid=FileDetails.Uploadedby where FileDetails.Readpermission='Yes' and FileDetails.Keywords like '%" + textBox1.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                dataGridView1.DataSource = dt;

            }
        }
    }
}
