using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace project1
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel BorderBtn;
        private Form currentChildForm;
        public FormMenu()
        {
            InitializeComponent();
            BorderBtn = new Panel(); //เป็นการกำหนด panal ที่ทำหน้าที่เป็นแถบเมนู
            BorderBtn.Size = new Size(7, 47); 
            panelMenu.Controls.Add(BorderBtn); //ทำการแอดให้ panel ที่เราสร้างไว้หลังปุ่มให้เราสามารถควบคุมได้
        }

        private struct RGBColors //กำหนดสีพื้นหลังไอคอน
        {
            public static Color color1 = Color.FromArgb(249, 226, 228);
            
        }
        private void ActivateButton(object senderBtn, Color color) //กำหนดสีเมื่อปุ่มเมนูยัง active อยู่
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.FromArgb(237, 165, 169); 
                currentBtn.IconColor = Color.FromArgb(237, 165, 169);

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.FromArgb(138, 138, 138);
                currentBtn.IconColor = Color.Silver;
            }
        }

        private void OpenChildForm(Form childForm) //ควบคุมการเปิดฟอร์มอื่นๆเมื่อกดแถบเมนู
        {
            
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormHome());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormMystory());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormWriting());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormProfile());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
