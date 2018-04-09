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

namespace FileSplitter
{
    public partial class Downloadold : Form
    { SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);
        public Downloadold(string name)
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
        save s = new save();
        private void Download_Load(object sender, EventArgs e)
        {
            string query = "select * from [Share] where [Friendid]='" + label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                dataGridView1.DataSource = dt;

            }
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST        
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            lblip.Text = myIP;
            label8.Text = s.GetMacAddress();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("select [Ipaddress],MacAddress from [Registration] where Ipaddress='" + lblip.Text + "' and MacAddress='" + label8.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string filename = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                   // string filename = row.Cells[2].Text;
                    string ftplocation = "ftp://107.180.1.81";
                    // Or on FreeBSD: "/usr/home/jared/test2.txt";
                    string user = "lbsim";
                    string password = "sim@9599929953";                    
                    DownloadFile(ftplocation, filename, user, password, @"F:\");
                    MessageBox.Show("File successfully downloaded !!");
                  
                }
                else
                {
                    string ftplocation = "ftp://107.180.1.81";
                    // Or on FreeBSD: "/usr/home/jared/test2.txt";
                    string user = "lbsim";
                    string password = "sim@9599929953";
                    //UploadToFTP(ftplocation, file, user, password);
                    DownloadFile(ftplocation, "About.aspx", user, password, @"F:\");
                    s.insert("insert into Intrudorip(Intrudorip,Macaddress) values('" + lblip.Text + "','" + label8.Text + "')");
                   s.SendEmail("shikhars335@gmail.com", "CAUTION !!! Unauthorized person is trying to download the file!!", "ABC");
                  // s.SendEmail("runjun.saxxena@gmail.com", "CAUTION !!! Unauthorized person is trying to download the file!!", "ABC");
                    MessageBox.Show("file successfully downloaded !!");
                  
                }
            }
                  
        }
    }
}
