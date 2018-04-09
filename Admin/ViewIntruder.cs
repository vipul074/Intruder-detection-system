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
    public partial class ViewIntruder : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);
        public ViewIntruder()
        {
            InitializeComponent();
        }

        private void ViewIntruder_Load(object sender, EventArgs e)
        {
            getvalue();
        }
        public void getvalue()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Intrudorip", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
