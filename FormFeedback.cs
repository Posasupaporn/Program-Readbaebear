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
    
    public partial class FormFeedback : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public FormFeedback()
        {
            InitializeComponent();
        }

        private void Formedit_Load(object sender, EventArgs e) //โชว์ database feedback
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                string Sql = $"Select reader, title, comment FROM feedback WHERE writer = '{Form1.instance.txtuser.Text}'";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                dataComment.DataSource = dt;
                dataComment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataComment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataComment.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                MySqlCommand command;
                MySqlDataAdapter da;

                if (txtsearch.Text != "")
                {
                    cn.Open();
                    command = new MySqlCommand($"Select reader, title, comment FROM feedback WHERE writer = '{Form1.instance.txtuser.Text}' AND Title Like '%" + txtsearch.Text + "%'", cn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataComment.DataSource = dt.DefaultView;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    command = new MySqlCommand($"Select reader, title, comment FROM feedback WHERE writer = '{Form1.instance.txtuser.Text}'");
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataComment.DataSource = dt.DefaultView;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
