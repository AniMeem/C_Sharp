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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\UniDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillDepartment()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select DepName from DepartmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(rdr);
            DepCb.ValueMember = "DepName";
            DepCb.DataSource = dt;
            Con.Close();
        }
        private void NoDues()
        {
            try
            {
                Con.Open();
                string query = "select * from StudentTbl where StdFees >"+0+"";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                StudentDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from StudentTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                StudentDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
        private void Student_Load(object sender, EventArgs e)
        {
            fillDepartment();
            populate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SId.Text == "" || SName.Text == "" || SPhoneTb.Text == "" || Fees.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl values(" + SId.Text + ",'" + SName.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + Date.Text + "','" + SPhoneTb.Text + "','" + DepCb.SelectedValue.ToString() + "','" + Fees.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student successfully added!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (SId.Text == "")
                {
                    MessageBox.Show("Enter the Student ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from StudentTbl where StdId='" + SId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted!");
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
                if (SId.Text == "" || SName.Text == "" || SPhoneTb.Text == "" || Fees.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update StudentTbl set StdName='" + SName.Text + "',StdGender='" + GenderCb.SelectedItem.ToString() + "',StdDOB='" + Date.Text + "',StdPhone='" + SPhoneTb.Text + "',StdDep='" + DepCb.SelectedValue.ToString() + "',StdFees='" + Fees.Text + "'where StdId='" + SId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated!");
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

        private void button5_Click(object sender, EventArgs e)
        {
            NoDues();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
