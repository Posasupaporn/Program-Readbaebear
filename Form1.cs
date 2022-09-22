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
    public partial class Form1 : Form
    {
        
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open(); //เช็ค username password
            string selectQuery = "SELECT * FROM project.infprofile1 WHERE username = '" + txtuser.Text + "' AND password = '" + txtpass.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {

                this.Hide();
                FormMenu frm3 = new FormMenu();
                frm3.ShowDialog();
            }

            else
            {

                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpass.Text)) // textbox ว่างจะแจ้งเตือน
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
        }
    private void button2_Click(object sender, EventArgs e) //กดปุ่ม sign up
        {
            this.Hide();
            Formsignin frm2 = new Formsignin();
            frm2.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
