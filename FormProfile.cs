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

namespace project1
{
    public partial class FormProfile : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void dataprofile_CellClick(object sender, DataGridViewCellEventArgs e) //ทำให้ textbox รับค่าจากแถวที่คลิก
        {
            dataprofile.CurrentRow.Selected = true;
            edituser.Text = dataprofile.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
            editemail.Text = dataprofile.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
            editname.Text = dataprofile.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            editlname.Text = dataprofile.Rows[e.RowIndex].Cells["lname"].FormattedValue.ToString();
        }
        private void showMyProfile() //เลือกข้อมูลของเจ้าของ username มาโชว์
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                string Sql = $"Select id, username, email, name, lname, coin FROM infprofile1 WHERE username = '{Form1.instance.txtuser.Text}' AND password = '{Form1.instance.txtpass.Text}'";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                dataprofile.DataSource = dt;
                dataprofile.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataprofile.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataprofile.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataprofile.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                
            }
        }
        private void FormProfile_Load(object sender, EventArgs e)
        {
            showMyProfile();
        }

        public FormProfile()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) //อัพเดทข้อมูล
        {
            int selectedRow = dataprofile.CurrentCell.RowIndex; //รับค่า index ของ cell ที่คลิก
            int edits = Convert.ToInt32(dataprofile.Rows[selectedRow].Cells["id"].Value); //ดึงข้อมูล id มาเก็บไว้ในตัวแปร
            MySqlConnection conn = databaseConnection();
            String sql1 = "UPDATE infprofile1 SET username = '" + edituser.Text + "', email = '" + editemail.Text + "', name = '" + editname.Text + "', lname = '" + editlname.Text + "' WHERE id = '" + edits + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("Successfully Updated");
                showMyProfile();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e) //log out
        {
            this.Hide();
            FormMenu obj = (FormMenu)Application.OpenForms["FormMenu"]; //แก้ปัญหาเมื่อกดปิดโปรแกรมแล้วหน้าเมนูไม่ถูกปิด
            obj.Close();
            Form1 frm4 = new Form1();
            frm4.ShowDialog();
        }

        private void topup_Click(object sender, EventArgs e)
        {
            Formcoin frm3 = new Formcoin();
            frm3.ShowDialog();
        }
    }
}
