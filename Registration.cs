using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace cafemanagement
{
    public partial class Registration : Form, IDisposable
    {
      
        save s = new save();
        public Registration()
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
            else if (textBox3.Text == string.Empty)
            {
                errorProvider1.SetError(textBox3, "Required");
            }
            else if (textBox4.Text == string.Empty)
            {
                errorProvider1.SetError(textBox4, "Required");
            }
            else
            {
                s.insert("insert into Registration([Username],[Password],[Emailid],[Contactno],Ipaddress,MacAddress) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + lblip.Text + "','" + label8.Text + "')");
                MessageBox.Show("information saved successfully");
                s = null;               
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
         && !char.IsDigit(e.KeyChar)
         && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (rEMail.IsMatch(textBox4.Text) == true)
            {


            }
            else
            {
                MessageBox.Show("invalid email");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST        
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            lblip.Text = myIP;
            label8.Text = s.GetMacAddress();
        }
    }
}
