using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;


namespace project1
{
    
    public partial class FormHome : Form
    {
        
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        
        public FormHome()
        {
            InitializeComponent();
        }

        
        private void FormHome_Load(object sender, EventArgs e) //โชว์หน้าหลักที่รวบรวมเรื่องสั้นทุกเรื่องเอาไว้ให้เลือกอ่าน
        {
            
            try
            {
                conn.Open();
                string Sql = $"Select Author, Title, Type, Category, Preview, Story FROM story";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                dataStory.DataSource = dt;
                dataStory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataStory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataStory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataStory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataStory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataStory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {

            }
            

        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //คลิกเรื่องสั้นเรื่องใดให้โชว์ข้อมูลใน textbox ที่กำหนด
        {
            
            FormReading myForm = new FormReading();
            myForm.txtstory1.Text = dataStory.CurrentRow.Cells[0].Value.ToString();
            myForm.txtstory2.Text = dataStory.CurrentRow.Cells[1].Value.ToString();
            myForm.txtstory3.Text = dataStory.CurrentRow.Cells[4].Value.ToString();
            myForm.txtstory4.Text = dataStory.CurrentRow.Cells[5].Value.ToString();
            myForm.txtstory5.Text = dataStory.CurrentRow.Cells[2].Value.ToString();
            myForm.txtstory6.Text = dataStory.CurrentRow.Cells[3].Value.ToString();
            myForm.Show();

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //ค้นหาด้วย textbox
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                MySqlCommand command;
                MySqlDataAdapter da;

                if (textBox1.Text != "")
                {
                    cn.Open();
                    command = new MySqlCommand($"Select Author, Title, Type, Category, Preview, Story FROM story WHERE Title Like '%" + textBox1.Text + "%' OR Author Like '%" + textBox1.Text + "%' OR Preview Like '%" + textBox1.Text + "%' OR Story Like '%" + textBox1.Text + "%'", cn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataStory.DataSource = dt.DefaultView;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    command = new MySqlCommand("Select Author, Title, Type, Category, Preview, Story FROM story");
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataStory.DataSource = dt.DefaultView;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e) //ค้นหาด้วยประเภท combobox
        {
            
            try
            {
                MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                MySqlCommand command;
                MySqlDataAdapter da;

                if (cbtype.Text != "")
                {
                    cn.Open();
                    command = new MySqlCommand($"Select Author, Title, Type, Category, Preview, Story FROM story WHERE Type Like '%" + cbtype.Text + "%'", cn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataStory.DataSource = dt.DefaultView;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    command = new MySqlCommand("Select Author, Title, Type, Category, Preview, Story FROM story");
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataStory.DataSource = dt.DefaultView;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e) //ค้นหาด้วยหมวดหมู่ combobox
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                MySqlCommand command;
                MySqlDataAdapter da;

                if (cbcategory.Text != "")
                {
                    cn.Open();
                    command = new MySqlCommand($"Select Author, Title, Type, Category, Preview, Story FROM story WHERE Category Like '%" + cbcategory.Text + "%'", cn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataStory.DataSource = dt.DefaultView;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    command = new MySqlCommand("Select Author, Title, Type, Category, Preview, Story FROM story");
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataStory.DataSource = dt.DefaultView;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
