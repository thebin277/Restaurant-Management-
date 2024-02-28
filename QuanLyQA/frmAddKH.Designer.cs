using System.Drawing;
using System.Windows.Forms;
namespace QuanLyQA
{
    partial class frmAddKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddKHCancel = new System.Windows.Forms.Button();
            this.btnAddKHSave = new System.Windows.Forms.Button();
            this.textBoxAddSDT = new System.Windows.Forms.TextBox();
            this.textBoxAddMaKH = new System.Windows.Forms.TextBox();
            this.textBoxAddTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm thông tin khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddKHCancel);
            this.panel2.Controls.Add(this.btnAddKHSave);
            this.panel2.Controls.Add(this.textBoxAddSDT);
            this.panel2.Controls.Add(this.textBoxAddMaKH);
            this.panel2.Controls.Add(this.textBoxAddTenKH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 162);
            this.panel2.TabIndex = 1;
            // 
            // btnAddKHCancel
            // 
            this.btnAddKHCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddKHCancel.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddKHCancel.Location = new System.Drawing.Point(248, 116);
            this.btnAddKHCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddKHCancel.Name = "btnAddKHCancel";
            this.btnAddKHCancel.Size = new System.Drawing.Size(89, 30);
            this.btnAddKHCancel.TabIndex = 19;
            this.btnAddKHCancel.Text = "Hủy";
            this.btnAddKHCancel.UseVisualStyleBackColor = false;
            this.btnAddKHCancel.Click += new System.EventHandler(this.btnAddKHCancel_Click);
            // 
            // btnAddKHSave
            // 
            this.btnAddKHSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddKHSave.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddKHSave.Location = new System.Drawing.Point(121, 116);
            this.btnAddKHSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddKHSave.Name = "btnAddKHSave";
            this.btnAddKHSave.Size = new System.Drawing.Size(89, 30);
            this.btnAddKHSave.TabIndex = 18;
            this.btnAddKHSave.Text = "Lưu";
            this.btnAddKHSave.UseVisualStyleBackColor = false;
            this.btnAddKHSave.Click += new System.EventHandler(this.btnAddKHSave_Click);
            // 
            // textBoxAddSDT
            // 
            this.textBoxAddSDT.Location = new System.Drawing.Point(268, 31);
            this.textBoxAddSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddSDT.Name = "textBoxAddSDT";
            this.textBoxAddSDT.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddSDT.TabIndex = 15;
            // 
            // textBoxAddMaKH
            // 
            this.textBoxAddMaKH.Location = new System.Drawing.Point(50, 82);
            this.textBoxAddMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddMaKH.Name = "textBoxAddMaKH";
            this.textBoxAddMaKH.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddMaKH.TabIndex = 14;
            // 
            // textBoxAddTenKH
            // 
            this.textBoxAddTenKH.Location = new System.Drawing.Point(50, 31);
            this.textBoxAddTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddTenKH.Name = "textBoxAddTenKH";
            this.textBoxAddTenKH.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddTenKH.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(261, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(47, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khách hàng";
            // 
            // frmAddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 234);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thông tin khach hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        public TextBox textBoxAddSDT;
        public TextBox textBoxAddMaKH;
        public TextBox textBoxAddTenKH;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button btnAddKHCancel;
        public Button btnAddKHSave;
    }
}