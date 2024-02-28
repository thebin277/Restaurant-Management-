namespace QuanLyQA
{
    partial class DanhSachCa
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewShift = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvMaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 103);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm Ca Làm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Ca Làm Việc";
            // 
            // dataGridViewShift
            // 
            this.dataGridViewShift.AllowUserToAddRows = false;
            this.dataGridViewShift.AllowUserToDeleteRows = false;
            this.dataGridViewShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaCa,
            this.dgvNgayLam,
            this.dgvGioBatDau,
            this.dgvGioKetThuc});
            this.dataGridViewShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShift.Location = new System.Drawing.Point(0, 103);
            this.dataGridViewShift.Name = "dataGridViewShift";
            this.dataGridViewShift.ReadOnly = true;
            this.dataGridViewShift.Size = new System.Drawing.Size(800, 347);
            this.dataGridViewShift.TabIndex = 1;
            
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QuanLyQA.Properties.Resources._3687412;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 36;
            // 
            // dgvMaCa
            // 
            this.dgvMaCa.HeaderText = "MaCa";
            this.dgvMaCa.Name = "dgvMaCa";
            this.dgvMaCa.ReadOnly = true;
            // 
            // dgvNgayLam
            // 
            this.dgvNgayLam.HeaderText = "NgayLam";
            this.dgvNgayLam.Name = "dgvNgayLam";
            this.dgvNgayLam.ReadOnly = true;
            // 
            // dgvGioBatDau
            // 
            this.dgvGioBatDau.HeaderText = "GioBatDau";
            this.dgvGioBatDau.Name = "dgvGioBatDau";
            this.dgvGioBatDau.ReadOnly = true;
            // 
            // dgvGioKetThuc
            // 
            this.dgvGioKetThuc.HeaderText = "GioKetThuc";
            this.dgvGioKetThuc.Name = "dgvGioKetThuc";
            this.dgvGioKetThuc.ReadOnly = true;
            // 
            // DanhSachCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewShift);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachCa";
            this.Load += new System.EventHandler(this.DanhSachCa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewShift;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioKetThuc;
    }
}