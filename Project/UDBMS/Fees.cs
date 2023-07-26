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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\UniDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void updateStd()
        {
            Con.Open();
            string query = "update StudentTbl set StdFees='" + AmountTb.Text + "'where StdId='" + StdIdCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Student Updated!");
            Con.Close();
        }
        private void updateStd2()
        {
            Con.Open();
            string query = "update StudentTbl set StdFees='" + 0 + "'where StdId='" + StdIdCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Student Updated!");
            Con.Close();
        }
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from FeesTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                FeesDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
        private void fillId()
        {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select StdId from StudentTbl", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("StdId", typeof(int));
                dt.Load(rdr);
                StdIdCb.ValueMember = "StdId";
                StdIdCb.DataSource = dt;
                Con.Close();
        }
        private void Fees_Load(object sender, EventArgs e)
        {
            fillId();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from StudentTbl where StdId=" + StdIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                StdName.Text = dr["StdName"].ToString();

            }
            Con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Num.Text == "" || StdName.Text == "" || AmountTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    string date = Period.Value.Year.ToString();
                    Con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from FeesTbl where Stdid=" + StdIdCb.SelectedValue.ToString() + "and Period='" + date + "'", Con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString()=="1")
                    {
                        MessageBox.Show("No Dues for the selected Period");
                        Con.Close();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into FeesTbl values(" + Num.Text + "," + StdIdCb.SelectedValue.ToString() + ",'" + StdName.Text + "','" + date + "'," + AmountTb.Text + ")", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fees successfully paid!");
                        Con.Close();
                        populate();
                        updateStd();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string date = Period.Value.Year.ToString();
                if (Num.Text == "" || StdName.Text == "" || date == "" || AmountTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update FeesTbl set Stdid='" + StdIdCb.SelectedValue.ToString() + "',StdName='" + StdName.Text + "',Period='" + date + "',Amount='" + AmountTb.Text + "'where FeesNum='" + Num.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Updated!");
                    Con.Close();
                    populate();
                    updateStd();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Num.Text == "")
                {
                    MessageBox.Show("Enter the fees num");
                }
                else
                {
                    Con.Open();
                    string query = "delete from FeesTbl where FeesNum='" + Num.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Deleted!");
                    Con.Close();
                    populate();
                    updateStd2();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

    }
}
