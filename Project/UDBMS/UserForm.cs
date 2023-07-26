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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\UniDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from UserTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                UserDGV.DataSource = ds.Tables[0];
                Con.Close();
            }catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if(UidTb.Text == ""||UnameTb.Text == ""||UpassTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl values("+UidTb.Text+",'"+UnameTb.Text+"','"+UpassTb.Text+"')",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully added!");
                    Con.Close();
                    populate();
                }
            }catch
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
                if(UidTb.Text=="")
                {
                    MessageBox.Show("Enter the User ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from UserTbl where UserId=" + UidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted!");
                    Con.Close();
                    populate();
                }
            }catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (UidTb.Text == "" || UnameTb.Text == "" || UpassTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update UserTbl set UserName='"+UnameTb.Text+"',password='"+UpassTb.Text+"'where UserId="+UidTb.Text+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated!");
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
