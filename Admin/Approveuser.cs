using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FileSplitter.Admin
{

    public partial class Approveuser : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);
        public Approveuser()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string val = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox1.Text = val;
                textBox1.Enabled = false;

            }
        }

        private void Approveuser_Load(object sender, EventArgs e)
        {
            getvalue();
        }
        public void getvalue()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from registration", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save s = new save();
            s.insert("update registration set status='"+comboBox1.Text+"' where id='"+textBox1.Text+"'");
            MessageBox.Show("Successfully Updated");
            getvalue();

        }
    }
}
