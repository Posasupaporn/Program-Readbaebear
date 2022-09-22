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
    public partial class FormMystory : Form
    {

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void dataMyStory_CellClick(object sender, DataGridViewCellEventArgs e) //ทำให้ textbox รับค่าจากแถวที่คลิก
        {
            dataMyStory.CurrentRow.Selected = true;
            editTitle.Text = dataMyStory.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
            editPreview.Text = dataMyStory.Rows[e.RowIndex].Cells["Preview"].FormattedValue.ToString();
            editStory.Text = dataMyStory.Rows[e.RowIndex].Cells["Story"].FormattedValue.ToString();
            edittype.Text = dataMyStory.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
            editcategory.Text = dataMyStory.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
        }

        private void showMyStory() //โชว์เรื่องสั้นที่เจ้าของ username เป็นคนแต่ง 
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                string Sql = $"Select id, Title, Type, Category, Preview, Story, Donate FROM story WHERE Author = '{Form1.instance.txtuser.Text}'";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                dataMyStory.DataSource = dt;
                dataMyStory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataMyStory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataMyStory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataMyStory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataMyStory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataMyStory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataMyStory.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (Exception ex)
            {

            }
        }
        private void FormWriting_Load(object sender, EventArgs e)
        {
            showMyStory();

        }
        public FormMystory()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int selectedRow = dataMyStory.CurrentCell.RowIndex; //รับค่า index ของ cell ที่คลิก
            int edits = Convert.ToInt32(dataMyStory.Rows[selectedRow].Cells["id"].Value); //ดึงข้อมูล id มาเก็บไว้ในตัวแปร
            MySqlConnection conn = databaseConnection();
            String sql1 = "UPDATE story SET Title = '" + editTitle.Text + "', Preview = '" +editPreview.Text+ "', Type = '" + edittype.Text + "', Category = '" + editcategory.Text + "', Story = '" + editStory.Text + "' WHERE id = '" + edits + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("Successfully Updated");
                showMyStory();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataMyStory.CurrentCell.RowIndex; //รับค่า index ของ cell ที่คลิก
            int deletes = Convert.ToInt32(dataMyStory.Rows[selectedRow].Cells["id"].Value); //ดึงข้อมูล id มาเก็บไว้ในตัวแปร
            MySqlConnection conn = databaseConnection();
            String sql1 = "DELETE FROM story WHERE id = '" + deletes + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();
            if (MessageBox.Show("Do you want to delete this story", "delete story", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("Successfully Deleted");
                    showMyStory();
                }
            }
            else
            {
                MessageBox.Show("Story not delete", "Delete story", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vComment_Click(object sender, EventArgs e)
        {
            FormFeedback frm = new FormFeedback();
            frm.ShowDialog();
        }

        
    }
}
