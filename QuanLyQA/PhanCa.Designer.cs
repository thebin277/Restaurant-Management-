namespace QuanLyQA
{
    partial class PhanCa
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
            this.dataGridView_Division = new System.Windows.Forms.DataGridView();
            this.dgvMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Division)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Division
            // 
            this.dataGridView_Division.AllowUserToAddRows = false;
            this.dataGridView_Division.AllowUserToDeleteRows = false;
            this.dataGridView_Division.AllowUserToResizeColumns = false;
            this.dataGridView_Division.AllowUserToResizeRows = false;
            this.dataGridView_Division.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Division.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Division.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Division.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Division.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaNV,
            this.dgvHoNV,
            this.dgvTenNV,
            this.dgvMaCa,
            this.dgvNgayLam,
            this.dgvdel});
            this.dataGridView_Division.Location = new System.Drawing.Point(-2, 119);
            this.dataGridView_Division.Name = "dataGridView_Division";
            this.dataGridView_Division.ReadOnly = true;
            this.dataGridView_Division.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_Division.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Division.Size = new System.Drawing.Size(802, 335);
            this.dataGridView_Division.TabIndex = 0;
            this.dataGridView_Division.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Division_CellClick);
            this.dataGridView_Division.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Division_CellContentClick);
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.HeaderText = "MaNV";
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.ReadOnly = true;
            // 
            // dgvHoNV
            // 
            this.dgvHoNV.HeaderText = "HoNV";
            this.dgvHoNV.Name = "dgvHoNV";
            this.dgvHoNV.ReadOnly = true;
            // 
            // dgvTenNV
            // 
            this.dgvTenNV.HeaderText = "TenNV";
            this.dgvTenNV.Name = "dgvTenNV";
            this.dgvTenNV.ReadOnly = true;
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
            // dgvdel
            // 
            this.dgvdel.FillWeight = 20F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = global::QuanLyQA.Properties.Resources._3687412;
            this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem danh sách ca làm việc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Danh sách phân ca";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Phân ca cho nhân viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 119);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "Phân Ca";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QuanLyQA.Properties.Resources._3687412;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 759;
            // 
            // PhanCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Division);
            this.Name = "PhanCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCa";
            this.Load += new System.EventHandler(this.PhanCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Division)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Division;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayLam;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
        private System.Windows.Forms.Label label5;
    }
}