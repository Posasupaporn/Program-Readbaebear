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

    public partial class FormReading : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public FormReading()
        {
            InitializeComponent();
        }

        
        
        private void sendcomment_Click(object sender, EventArgs e) // insert คอมเม้นของนักอ่าน
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            string iquery = "INSERT INTO feedback(`reader`, `writer`, `title`, `comment`) VALUES ('" + Form1.instance.txtuser.Text + "','" + txtstory1.Text + "', '" + txtstory2.Text + "', '" + txtcomment.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Comment successfully sent");
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void senddonate_Click(object sender, EventArgs e) //คำนวณโดเนท
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select coin FROM infprofile1 WHERE username = '{Form1.instance.txtuser.Text}'";
            cmd.Connection = conn;
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int d = dr.GetInt32(0); //จำนวนคอยน์ที่มี
            conn.Close();
            int a = Convert.ToInt32(txtDonate.Text); //จำนวนที่ต้องการโดเนท
            if (d >= a) //เช็คว่าจำนวนที่จะโดเนทเกินจำนวนคอยน์ที่มีไหม
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Donate from story where Title ='" + txtstory2.Text + "'";
                cmd.Connection = conn;
                conn.Open();
                MySqlDataReader dr1 = cmd.ExecuteReader();
                dr1.Read();
                int d1 = dr1.GetInt32(0); //รับค่าที่เป็นจำนวนเงินโดเนทที่มีอยู่ก่อนหน้า
                conn.Close();
                int a1 = Convert.ToInt32(txtDonate.Text); //จำนวนเงินโดเนทของผู้อ่านคนล่าสุด
                int b1 = (a1 * 90) / 100;
                int c = d1 + b1;
                try
                {
                    string Query = "UPDATE story SET Donate ='" + c + "' where Title ='" + txtstory2.Text + "';"; 
                    MySqlCommand cmd1 = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader2;
                    conn.Open();
                    MyReader2 = cmd1.ExecuteReader();
                    MessageBox.Show("Your donation is successful");

                    while (MyReader2.Read())
                    {

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                int f = d - a; //คำนวณคอร์นหลังจากโดเนท
                try
                {
                    string Query = "UPDATE infprofile1 SET coin ='" + f + "' where username = '" + Form1.instance.txtuser.Text + "'";
                    MySqlCommand cmd1 = new MySqlCommand(Query, conn);
                    MySqlDataReader MyReader2;
                    conn.Open();
                    MyReader2 = cmd1.ExecuteReader();
                    while (MyReader2.Read())
                    {

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You don't have enough coins");
            }
        }

        private void FormReading_Load(object sender, EventArgs e)
        {

        }

        private void txtstory2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
