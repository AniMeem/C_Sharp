using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UDBMS
{
    public partial class Teachers : Form
    {
        public Teachers()
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
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from TeacherTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                TeacherDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            fillDepartment();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (TId.Text==""||TName.Text==""||TPhoneTb.Text==""||Address.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl values(" + TId.Text + ",'" + TName.Text + "','" + GenderCb.SelectedItem.ToString() + "','"+Date.Text+"','"+TPhoneTb.Text+"','"+DepCb.SelectedValue.ToString()+"','"+Address.Text+"')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher successfully added!");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TId.Text == "")
                {
                    MessageBox.Show("Enter the Teacher ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from TeacherTbl where TeacherId='" + TId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tecaher Deleted!");
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
                if (TId.Text == "" || TName.Text == "" || TPhoneTb.Text == "" || Address.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update TeacherTbl set TeacherName='" + TName.Text + "',TeacherGender='" + GenderCb.SelectedItem.ToString() + "',TeacherDOB='" + Date.Text + "',TeacherPhone='" + TPhoneTb.Text + "',TeacherDep='" + DepCb.SelectedValue.ToString() + "',TeacherAdd='" + Address.Text + "'where TeacherId='" + TId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated!");
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
