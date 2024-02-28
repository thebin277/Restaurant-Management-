namespace QuanLyQA
{
    partial class PhanCaNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.comboBoxMaCa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNgayLam = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ca:";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(109, 88);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(184, 20);
            this.textBoxMaNV.TabIndex = 4;
            // 
            // comboBoxMaCa
            // 
            this.comboBoxMaCa.FormattingEnabled = true;
            this.comboBoxMaCa.Items.AddRange(new object[] {
            "Ca1",
            "Ca2",
            "Ca3",
            "Ca4"});
            this.comboBoxMaCa.Location = new System.Drawing.Point(109, 141);
            this.comboBoxMaCa.Name = "comboBoxMaCa";
            this.comboBoxMaCa.Size = new System.Drawing.Size(184, 21);
            this.comboBoxMaCa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Làm: ";
            // 
            // dateTimeNgayLam
            // 
            this.dateTimeNgayLam.CustomFormat = "yyyy-MM-dd";
            this.dateTimeNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayLam.Location = new System.Drawing.Point(109, 197);
            this.dateTimeNgayLam.Name = "dateTimeNgayLam";
            this.dateTimeNgayLam.Size = new System.Drawing.Size(184, 20);
            this.dateTimeNgayLam.TabIndex = 6;
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Phân Ca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 65);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 64);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PhanCaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimeNgayLam);
            this.Controls.Add(this.comboBoxMaCa);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhanCaNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCaNV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.ComboBox comboBoxMaCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayLam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
    }
}