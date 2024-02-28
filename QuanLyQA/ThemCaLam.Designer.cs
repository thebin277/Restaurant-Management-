namespace QuanLyQA
{
    partial class ThemCaLam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNgayLam = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaCa = new System.Windows.Forms.ComboBox();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 65);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thêm Ca Làm Việc Cho Nhân Viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimeNgayLam
            // 
            this.dateTimeNgayLam.CustomFormat = "yyyy-MM-dd";
            this.dateTimeNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayLam.Location = new System.Drawing.Point(98, 131);
            this.dateTimeNgayLam.Name = "dateTimeNgayLam";
            this.dateTimeNgayLam.Size = new System.Drawing.Size(184, 20);
            this.dateTimeNgayLam.TabIndex = 16;
            // 
            // comboBoxMaCa
            // 
            this.comboBoxMaCa.FormattingEnabled = true;
            this.comboBoxMaCa.Items.AddRange(new object[] {
            "Ca1",
            "Ca2",
            "Ca3",
            "Ca4"});
            this.comboBoxMaCa.Location = new System.Drawing.Point(98, 93);
            this.comboBoxMaCa.Name = "comboBoxMaCa";
            this.comboBoxMaCa.Size = new System.Drawing.Size(184, 21);
            this.comboBoxMaCa.TabIndex = 15;
            this.comboBoxMaCa.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaCa_SelectedIndexChanged);
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(98, 168);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(184, 20);
            this.textBoxMaNV.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày Làm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Ca:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giờ Bắt Đầu: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm Ca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 64);
            this.panel2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giờ Kết Thúc:";
            // 
            // ThemCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimeNgayLam);
            this.Controls.Add(this.comboBoxMaCa);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "ThemCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemCaLam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNgayLam;
        private System.Windows.Forms.ComboBox comboBoxMaCa;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}