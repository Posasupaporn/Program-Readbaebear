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
using System.Text.RegularExpressions;

namespace project1
{
    public partial class Formsignin : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Formsignin()
        {
            InitializeComponent();

        }

        private void btnsignUp_Click(object sender, EventArgs e) //เช็ค username password email
        {
            connection.Open();
            string selectQuery = "SELECT * FROM project.infprofile1 WHERE Username = '" + userName.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            var hasMiniMaxChars = new Regex(@".{8,15}"); //ต้องมีมากกว่าหรือเท่ากับ 8 แต่ไม่เกิน 15
            var pattern = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"); //กำหนดคุณสมบัติอีเมล
            
            if (mdr.Read()) //มีคนใช้ username ไปแล้ว
            {
                MessageBox.Show("Username not available!");

            }
            else if (!hasMiniMaxChars.IsMatch(Password.Text)) //จำนวนรหัสผ่าน
            {
                MessageBox.Show("Password should not be lesser than 8 or greater than 15 characters.");
            }
            else if (!pattern.IsMatch(EmAil.Text)) //องค์ประกอบของอีเมล
            {
                MessageBox.Show(" is not a valid Email address");
            }
            else
            {

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                string iquery = "INSERT INTO infprofile1(`id`, `email`, `username`, `name`, `lname`, `password`, `coin`) VALUES (NULL, '" + EmAil.Text + "', '" + userName.Text + "', '" + txtname.Text + "', '" + txtlname.Text + "', '" + Password.Text + "', 0)";

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

                MessageBox.Show("Account Successfully Created!");
                this.Hide();
                Form1 frm3 = new Form1();
                frm3.ShowDialog();
            }

            connection.Close();

            if (string.IsNullOrEmpty(EmAil.Text) || string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtlname.Text)) //text box ว่าง
            {
                MessageBox.Show("Please input information", "Error");
            }
        }

        private void Formsignin_Load(object sender, EventArgs e)
        {

        }
    }
}