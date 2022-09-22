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
    
    public partial class FormWriting : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public FormWriting()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes() //ลบข้อมูลที่กรอกไว้ใน text box ทั้งหมด
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);

        }
        private void button1_Click(object sender, EventArgs e) //เพิ่มเรื่องสั้ั้น
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            string iquery = "INSERT INTO story(`Author`, `Title`, `Type`, `Category`, `Preview`, `Story`, `Donate`) VALUES ('" + Form1.instance.txtuser.Text + "','" + txtTitle.Text + "','" + txttype.Text + "','" + txtcategory.Text + "', '" + txtPreview.Text + "', '" + txtStory.Text + "', 0)";

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
            MessageBox.Show("Story Successfully Added");
            ClearTextBoxes();
            

            
        }

        
    }
}
