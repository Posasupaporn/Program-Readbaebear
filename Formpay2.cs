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
    public partial class Formpay2 : Form
    {
        public Formpay2()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void finished_Click(object sender, EventArgs e) //คำนวณคอร์ย
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select coin FROM infprofile1 WHERE username = '{Form1.instance.txtuser.Text}'";
            cmd.Connection = conn;
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int d = dr.GetInt32(0); //รับค่าที่เป็นคอร์ยที่มีอยู่ก่อนหน้า
            conn.Close();
            int a = 50;
            int b = a + d;
            try
            {
                string Query = "UPDATE infprofile1 SET coin ='" + b + "' where username = '" + Form1.instance.txtuser.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                conn.Open();
                MyReader2 = cmd1.ExecuteReader();
                MessageBox.Show("Coin successfully added");
                while (MyReader2.Read())
                {

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }
    }
}
