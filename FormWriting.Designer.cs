namespace project1
{
    partial class FormWriting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWriting));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ขื่อเรื่อง*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "คำโปรย*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(268, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "เนื้อเรื่อง*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Story";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.Location = new System.Drawing.Point(70, 141);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(177, 38);
            this.txtTitle.TabIndex = 9;
            // 
            // txtPreview
            // 
            this.txtPreview.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPreview.ForeColor = System.Drawing.Color.DimGray;
            this.txtPreview.Location = new System.Drawing.Point(71, 204);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(177, 88);
            this.txtPreview.TabIndex = 10;
            // 
            // txtStory
            // 
            this.txtStory.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtStory.ForeColor = System.Drawing.Color.DimGray;
            this.txtStory.Location = new System.Drawing.Point(344, 137);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStory.Size = new System.Drawing.Size(265, 311);
            this.txtStory.TabIndex = 11;
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txttype.ForeColor = System.Drawing.Color.DimGray;
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "บทความ",
            "เรื่องสั้น"});
            this.txttype.Location = new System.Drawing.Point(71, 315);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(149, 26);
            this.txttype.TabIndex = 26;
            // 
            // txtcategory
            // 
            this.txtcategory.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtcategory.ForeColor = System.Drawing.Color.DimGray;
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Items.AddRange(new object[] {
            "ชุมชนคนขี้ชิป",
            "ห้องแห่งความรัก",
            "คาเฟ่อมยิ้ม",
            "คืนฟ้าหม่น",
            "คืนโหยหวน",
            "แฟ้มคดีสีเลือด",
            "ป่าเวทมนตร์",
            "สาระความรู้",
            "เรื่องนี้ที่อยากเล่า"});
            this.txtcategory.Location = new System.Drawing.Point(70, 367);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(149, 26);
            this.txtcategory.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "ประเภท*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("FC Lamoon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(12, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "หมวดหมู่*";
            // 
            // FormWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project1.Properties.Resources.IMG_9006;
            this.ClientSize = new System.Drawing.Size(621, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtStory);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWriting";
            this.Text = "ReadBaeBear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}