using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudFormsApplication
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        bool newBtnFlag = false;

        public Form1()
        {
            InitializeComponent();
            loadData();
   
        }


        private void connectionSql(String sql)
        {
           
            try
            {
                this.conn = new SqlConnection(@"Data Source=.;Initial Catalog=db;Integrated Security=True;database=db;uid=sa;password=meem123;");
                this.conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    this.cmd = new SqlCommand(sql, conn);
                    this.cmd.ExecuteNonQuery();
                    
                }

                else
                {
                    MessageBox.Show(" connection failed ");
               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            finally
            {
                conn.Close();
            }

        }

        private void loadData()
        {
             string query = "select * from employee";
             connectionSql(query);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            // _dataGridView.AutoGenerateColumns = false;
           
            _dataGridView.DataSource = dt;
            _dataGridView.Columns["id"].Visible = false;
            _dataGridView.Refresh();
        }


        private void insertData(String sql)
        {
            connectionSql(sql);
        }



        private void updateData(String sql)
        {
                if (_dataGridView.SelectedRows.Count != 0)
                {

                     DataGridViewRow row = _dataGridView.SelectedRows[0];
                     String id =row.Cells["id"].Value.ToString();
                     string query = sql + id;

                     connectionSql(query);
                   
                }
        }


        private void deleteData(String sql)
        {

                if (_dataGridView.SelectedRows.Count != 0)
                {

                    DataGridViewRow row = _dataGridView.SelectedRows[0];
                    String id = row.Cells["id"].Value.ToString();

                    string query = sql + id;
                    connectionSql(query);
                }
        }


        private void emptyField()
        {
            _firstNameBox.Clear();
            _lastNameBox.Clear();
            _userNameBox.Clear();
            _emailBox.Clear();
        }

       private void findDatafromDatatable(String sql){
           connectionSql(sql);
           SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);
           DataTable dt = new DataTable();
           adapt.Fill(dt);
           _dataGridView.DataSource = dt;

        }

        private void search_Click(object sender, EventArgs e)
        {

            String searchName= _searchBox.Text;
            String sql_query = "select  * from employee where firstname like '" + searchName + "%'";
            findDatafromDatatable(sql_query);

            _searchBox.Clear();

        }

        private void new_Click(object sender, EventArgs e)
        {

            emptyField();
            newBtnFlag = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String sql_query = " DELETE FROM employee WHERE id =";
            deleteData(sql_query);
            loadData();
            emptyField();
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            loadData();
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (newBtnFlag == true)
            {
                String firstName = _firstNameBox.Text;
                String lastName = _lastNameBox.Text;
                String userName = _userNameBox.Text;
                String email = _emailBox.Text;

                String sql_query =
                            "insert into employee (firstname,lastname,username,email) values('" + firstName +
                            "','" + lastName + "','" + userName + "','" + email +  "')";

                insertData(sql_query);
                newBtnFlag = false;
                loadData();
            }
            else
            {

                String firstName = _firstNameBox.Text;
                String lastName = _lastNameBox.Text;
                String userName = _userNameBox.Text;
                String email = _emailBox.Text;

                String sql_query =" UPDATE employee "
                                  + "  SET firstname = '" + firstName + "', lastname= '" + lastName + "', username= '" + userName + "', email= '" + email + "' "
                                  +" WHERE id =";


                updateData(sql_query);
                loadData();
            }

           // emptyField();
           
        }

        private void dataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1){
                DataGridViewRow dG = _dataGridView.Rows[e.RowIndex];
                _firstNameBox.Text = dG.Cells[1].Value.ToString();
                _lastNameBox.Text = dG.Cells[2].Value.ToString();
                _userNameBox.Text = dG.Cells[3].Value.ToString();
                _emailBox.Text = dG.Cells[4].Value.ToString();

            }
            //MessageBox.Show("grid cell click" + e.RowIndex);
        }
    }
}
