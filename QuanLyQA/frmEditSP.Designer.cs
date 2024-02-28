using System.Drawing;
using System.Windows.Forms;
namespace QuanLyQA
{
    partial class frmEditSP
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
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.textBoxEditMaLSP = new System.Windows.Forms.TextBox();
            this.comboBoxEditTT = new System.Windows.Forms.ComboBox();
            this.textBoxEditDonGia = new System.Windows.Forms.TextBox();
            this.textBoxEditTenSP = new System.Windows.Forms.TextBox();
            this.textBoxEditMaSP = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sửa thông tin sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnEditCancel);
            this.panel2.Controls.Add(this.btnEditSave);
            this.panel2.Controls.Add(this.textBoxEditMaLSP);
            this.panel2.Controls.Add(this.comboBoxEditTT);
            this.panel2.Controls.Add(this.textBoxEditDonGia);
            this.panel2.Controls.Add(this.textBoxEditTenSP);
            this.panel2.Controls.Add(this.textBoxEditMaSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 225);
            this.panel2.TabIndex = 1;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditCancel.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditCancel.Location = new System.Drawing.Point(234, 177);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(89, 30);
            this.btnEditCancel.TabIndex = 23;
            this.btnEditCancel.Text = "Hủy";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditSave.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditSave.Location = new System.Drawing.Point(107, 177);
            this.btnEditSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(89, 30);
            this.btnEditSave.TabIndex = 22;
            this.btnEditSave.Text = "Lưu";
            this.btnEditSave.UseVisualStyleBackColor = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // textBoxEditMaLSP
            // 
            this.textBoxEditMaLSP.Location = new System.Drawing.Point(39, 141);
            this.textBoxEditMaLSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditMaLSP.Name = "textBoxEditMaLSP";
            this.textBoxEditMaLSP.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditMaLSP.TabIndex = 21;
            // 
            // comboBoxEditTT
            // 
            this.comboBoxEditTT.FormattingEnabled = true;
            this.comboBoxEditTT.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.comboBoxEditTT.Location = new System.Drawing.Point(256, 89);
            this.comboBoxEditTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEditTT.Name = "comboBoxEditTT";
            this.comboBoxEditTT.Size = new System.Drawing.Size(148, 21);
            this.comboBoxEditTT.TabIndex = 20;
            // 
            // textBoxEditDonGia
            // 
            this.textBoxEditDonGia.Location = new System.Drawing.Point(39, 89);
            this.textBoxEditDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditDonGia.Name = "textBoxEditDonGia";
            this.textBoxEditDonGia.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditDonGia.TabIndex = 19;
            // 
            // textBoxEditTenSP
            // 
            this.textBoxEditTenSP.Location = new System.Drawing.Point(256, 39);
            this.textBoxEditTenSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditTenSP.Name = "textBoxEditTenSP";
            this.textBoxEditTenSP.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditTenSP.TabIndex = 18;
            // 
            // textBoxEditMaSP
            // 
            this.textBoxEditMaSP.Location = new System.Drawing.Point(39, 39);
            this.textBoxEditMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditMaSP.Name = "textBoxEditMaSP";
            this.textBoxEditMaSP.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditMaSP.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(250, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(250, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sản phẩm";
            // 
            // frmEditSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 282);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEditSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin sản phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public Label label1;
        private Button btnEditCancel;
        public Button btnEditSave;
        public TextBox textBoxEditMaLSP;
        public ComboBox comboBoxEditTT;
        public TextBox textBoxEditDonGia;
        public TextBox textBoxEditTenSP;
        public TextBox textBoxEditMaSP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}