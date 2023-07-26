using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UDBMS
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\UniDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select count(*) from StudentTbl", Con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Stdlb.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(*) from FeesTbl", Con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            Feeslb.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter da3 = new SqlDataAdapter("select count(*) from TeacherTbl", Con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            Teacherlb.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter da4 = new SqlDataAdapter("select count(*) from DepartmentTbl", Con);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            Departmentlb.Text = dt1.Rows[0][0].ToString();
            Con.Close();

        }
    }
}
