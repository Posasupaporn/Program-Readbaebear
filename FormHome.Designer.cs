namespace project1
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataStory = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataStory);
            this.panel1.Location = new System.Drawing.Point(12, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 341);
            this.panel1.TabIndex = 0;
            // 
            // dataStory
            // 
            this.dataStory.AllowUserToAddRows = false;
            this.dataStory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataStory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStory.BackgroundColor = System.Drawing.Color.White;
            this.dataStory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataStory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataStory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStory.Location = new System.Drawing.Point(0, 0);
            this.dataStory.Name = "dataStory";
            this.dataStory.ReadOnly = true;
            this.dataStory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataStory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStory.Size = new System.Drawing.Size(597, 341);
            this.dataStory.TabIndex = 0;
            this.dataStory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataStory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataStory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(440, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(579, 139);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 26);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // cbtype
            // 
            this.cbtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtype.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbtype.ForeColor = System.Drawing.Color.DimGray;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "บทความ",
            "เรื่องสั้น"});
            this.cbtype.Location = new System.Drawing.Point(57, 137);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(140, 26);
            this.cbtype.TabIndex = 3;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ประเภท";
            // 
            // cbcategory
            // 
            this.cbcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcategory.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbcategory.ForeColor = System.Drawing.Color.DimGray;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Items.AddRange(new object[] {
            "ชุมชนคนขี้ชิป",
            "ห้องแห่งความรัก",
            "คาเฟ่อมยิ้ม",
            "คืนฟ้าหม่น",
            "คืนโหยหวน",
            "แฟ้มคดีสีเลือด",
            "ป่าเวทมนตร์",
            "สาระความรู้",
            "เรื่องนี้ที่อยากเล่า"});
            this.cbcategory.Location = new System.Drawing.Point(271, 137);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(140, 26);
            this.cbcategory.TabIndex = 5;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(216, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "หมวดหมู่";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project1.Properties.Resources.IMG_9004;
            this.ClientSize = new System.Drawing.Size(621, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "ReadBaeBear";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataStory;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Label label2;
    }
}