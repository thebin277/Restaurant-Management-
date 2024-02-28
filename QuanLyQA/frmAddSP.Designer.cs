using System.Drawing;
using System.Windows.Forms;
namespace QuanLyQA
{
    partial class frmAddSP
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
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.textBoxAddMaLSP = new System.Windows.Forms.TextBox();
            this.comboBoxAddTT = new System.Windows.Forms.ComboBox();
            this.textBoxAddDonGia = new System.Windows.Forms.TextBox();
            this.textBoxAddTenSP = new System.Windows.Forms.TextBox();
            this.textBoxAddMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddCancel);
            this.panel2.Controls.Add(this.btnAddSave);
            this.panel2.Controls.Add(this.textBoxAddMaLSP);
            this.panel2.Controls.Add(this.comboBoxAddTT);
            this.panel2.Controls.Add(this.textBoxAddDonGia);
            this.panel2.Controls.Add(this.textBoxAddTenSP);
            this.panel2.Controls.Add(this.textBoxAddMaSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 225);
            this.panel2.TabIndex = 1;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddCancel.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.Location = new System.Drawing.Point(230, 184);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(89, 30);
            this.btnAddCancel.TabIndex = 11;
            this.btnAddCancel.Text = "Hủy";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddSave.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddSave.Location = new System.Drawing.Point(103, 184);
            this.btnAddSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(89, 30);
            this.btnAddSave.TabIndex = 10;
            this.btnAddSave.Text = "Lưu";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // textBoxAddMaLSP
            // 
            this.textBoxAddMaLSP.Location = new System.Drawing.Point(35, 148);
            this.textBoxAddMaLSP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddMaLSP.Name = "textBoxAddMaLSP";
            this.textBoxAddMaLSP.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddMaLSP.TabIndex = 9;
            // 
            // comboBoxAddTT
            // 
            this.comboBoxAddTT.FormattingEnabled = true;
            this.comboBoxAddTT.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.comboBoxAddTT.Location = new System.Drawing.Point(251, 96);
            this.comboBoxAddTT.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAddTT.Name = "comboBoxAddTT";
            this.comboBoxAddTT.Size = new System.Drawing.Size(148, 21);
            this.comboBoxAddTT.TabIndex = 8;
            // 
            // textBoxAddDonGia
            // 
            this.textBoxAddDonGia.Location = new System.Drawing.Point(35, 96);
            this.textBoxAddDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddDonGia.Name = "textBoxAddDonGia";
            this.textBoxAddDonGia.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddDonGia.TabIndex = 7;
            // 
            // textBoxAddTenSP
            // 
            this.textBoxAddTenSP.Location = new System.Drawing.Point(251, 46);
            this.textBoxAddTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddTenSP.Name = "textBoxAddTenSP";
            this.textBoxAddTenSP.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddTenSP.TabIndex = 6;
            // 
            // textBoxAddMaSP
            // 
            this.textBoxAddMaSP.Location = new System.Drawing.Point(35, 46);
            this.textBoxAddMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddMaSP.Name = "textBoxAddMaSP";
            this.textBoxAddMaSP.Size = new System.Drawing.Size(148, 20);
            this.textBoxAddMaSP.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(32, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(245, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(245, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // frmAddSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 282);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.frmAddSP_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddCancel;
        public TextBox textBoxAddMaSP;
        public TextBox textBoxAddMaLSP;
        public ComboBox comboBoxAddTT;
        public TextBox textBoxAddDonGia;
        public TextBox textBoxAddTenSP;
        public Label label1;
        public Button btnAddSave;
    }
}