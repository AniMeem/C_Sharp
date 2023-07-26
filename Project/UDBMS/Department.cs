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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\UniDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from DepartmentTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DepDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "" || DepDesc.Text == "" || DepDurationTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DepartmentTbl values('" + DepNameTb.Text + "','" + DepDesc.Text + "','" + DepDurationTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department successfully added!");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Enter the Department name");
                }
                else
                {
                    Con.Open();
                    string query = "delete from DepartmentTbl where DepName='" + DepNameTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Deleted!");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "" || DepDesc.Text == "" || DepDurationTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update DepartmentTbl set DepDesc='" + DepDesc.Text + "',DepDuration=" + DepDurationTb.Text + "where DepName='" + DepNameTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Updated!");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
