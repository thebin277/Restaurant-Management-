
namespace QuanLyQA
{
    partial class frmKho
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKho = new System.Windows.Forms.TabPage();
            this.txtSearchKho = new System.Windows.Forms.TextBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.dgvMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNL = new System.Windows.Forms.Button();
            this.btnSearchNL = new System.Windows.Forms.Button();
            this.lbnguyenlieu = new System.Windows.Forms.Label();
            this.tabPhieuChi = new System.Windows.Forms.TabPage();
            this.dgvPhieuChi = new System.Windows.Forms.DataGridView();
            this.dgvMaDonNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNCCPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTinhTrangPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayXuatPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonViPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.tabPhieuChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKho);
            this.tabControl1.Controls.Add(this.tabPhieuChi);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 569);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKho
            // 
            this.tabKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabKho.Controls.Add(this.txtSearchKho);
            this.tabKho.Controls.Add(this.dgvKho);
            this.tabKho.Controls.Add(this.btnAddNL);
            this.tabKho.Controls.Add(this.btnSearchNL);
            this.tabKho.Controls.Add(this.lbnguyenlieu);
            this.tabKho.Location = new System.Drawing.Point(4, 22);
            this.tabKho.Margin = new System.Windows.Forms.Padding(2);
            this.tabKho.Name = "tabKho";
            this.tabKho.Padding = new System.Windows.Forms.Padding(2);
            this.tabKho.Size = new System.Drawing.Size(955, 543);
            this.tabKho.TabIndex = 0;
            this.tabKho.Text = "KHO";
            this.tabKho.Click += new System.EventHandler(this.tabKho_Click);
            // 
            // txtSearchKho
            // 
            this.txtSearchKho.BackColor = System.Drawing.Color.Linen;
            this.txtSearchKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchKho.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearchKho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearchKho.Location = new System.Drawing.Point(185, 21);
            this.txtSearchKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKho.Multiline = true;
            this.txtSearchKho.Name = "txtSearchKho";
            this.txtSearchKho.Size = new System.Drawing.Size(342, 28);
            this.txtSearchKho.TabIndex = 24;
            this.txtSearchKho.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaNL,
            this.dgvTenNL,
            this.dgvMaNCC,
            this.dgvSL,
            this.dgvDonVi,
            this.dgvTinhTrang});
            this.dgvKho.Location = new System.Drawing.Point(0, 73);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersWidth = 62;
            this.dgvKho.RowTemplate.Height = 28;
            this.dgvKho.Size = new System.Drawing.Size(955, 375);
            this.dgvKho.TabIndex = 23;
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvMaNL
            // 
            this.dgvMaNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNL.HeaderText = "MaNL";
            this.dgvMaNL.MinimumWidth = 8;
            this.dgvMaNL.Name = "dgvMaNL";
            this.dgvMaNL.ReadOnly = true;
            // 
            // dgvTenNL
            // 
            this.dgvTenNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTenNL.HeaderText = "TenNL";
            this.dgvTenNL.MinimumWidth = 8;
            this.dgvTenNL.Name = "dgvTenNL";
            this.dgvTenNL.ReadOnly = true;
            // 
            // dgvMaNCC
            // 
            this.dgvMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNCC.HeaderText = "MaNCC";
            this.dgvMaNCC.MinimumWidth = 8;
            this.dgvMaNCC.Name = "dgvMaNCC";
            this.dgvMaNCC.ReadOnly = true;
            // 
            // dgvSL
            // 
            this.dgvSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSL.HeaderText = "SL";
            this.dgvSL.MinimumWidth = 8;
            this.dgvSL.Name = "dgvSL";
            this.dgvSL.ReadOnly = true;
            // 
            // dgvDonVi
            // 
            this.dgvDonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDonVi.HeaderText = "DonVi";
            this.dgvDonVi.MinimumWidth = 8;
            this.dgvDonVi.Name = "dgvDonVi";
            this.dgvDonVi.ReadOnly = true;
            // 
            // dgvTinhTrang
            // 
            this.dgvTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTinhTrang.HeaderText = "TinhTrang";
            this.dgvTinhTrang.MinimumWidth = 8;
            this.dgvTinhTrang.Name = "dgvTinhTrang";
            this.dgvTinhTrang.ReadOnly = true;
            // 
            // btnAddNL
            // 
            this.btnAddNL.BackColor = System.Drawing.Color.Khaki;
            this.btnAddNL.Location = new System.Drawing.Point(780, 13);
            this.btnAddNL.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNL.Name = "btnAddNL";
            this.btnAddNL.Size = new System.Drawing.Size(150, 34);
            this.btnAddNL.TabIndex = 22;
            this.btnAddNL.Text = "THÊM NGUYÊN LIỆU";
            this.btnAddNL.UseVisualStyleBackColor = false;
            this.btnAddNL.Click += new System.EventHandler(this.btnAddNL_Click_1);
            // 
            // btnSearchNL
            // 
            this.btnSearchNL.BackColor = System.Drawing.Color.Khaki;
            this.btnSearchNL.Location = new System.Drawing.Point(633, 13);
            this.btnSearchNL.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNL.Name = "btnSearchNL";
            this.btnSearchNL.Size = new System.Drawing.Size(127, 34);
            this.btnSearchNL.TabIndex = 21;
            this.btnSearchNL.Text = "TÌM";
            this.btnSearchNL.UseVisualStyleBackColor = false;
            this.btnSearchNL.Click += new System.EventHandler(this.btnSearchNL_Click);
            // 
            // lbnguyenlieu
            // 
            this.lbnguyenlieu.AutoSize = true;
            this.lbnguyenlieu.Location = new System.Drawing.Point(47, 34);
            this.lbnguyenlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnguyenlieu.Name = "lbnguyenlieu";
            this.lbnguyenlieu.Size = new System.Drawing.Size(112, 13);
            this.lbnguyenlieu.TabIndex = 20;
            this.lbnguyenlieu.Text = "KHO NGUYÊN LIỆU: ";
            // 
            // tabPhieuChi
            // 
            this.tabPhieuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPhieuChi.Controls.Add(this.dgvPhieuChi);
            this.tabPhieuChi.Controls.Add(this.btnrefresh);
            this.tabPhieuChi.Controls.Add(this.label7);
            this.tabPhieuChi.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.tabPhieuChi.Name = "tabPhieuChi";
            this.tabPhieuChi.Padding = new System.Windows.Forms.Padding(2);
            this.tabPhieuChi.Size = new System.Drawing.Size(955, 543);
            this.tabPhieuChi.TabIndex = 1;
            this.tabPhieuChi.Text = "PHIẾU CHI";
            // 
            // dgvPhieuChi
            // 
            this.dgvPhieuChi.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaDonNH,
            this.dgvNgayNH,
            this.dgvMaNCCPC,
            this.dgvTinhTrangPC,
            this.dgvMaPC,
            this.dgvNgayXuatPhieu,
            this.dgvMaNLPC,
            this.dgvDonGiaPC,
            this.dgvSLPC,
            this.dgvDonViPC,
            this.dgvSoTienChi});
            this.dgvPhieuChi.Location = new System.Drawing.Point(7, 59);
            this.dgvPhieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuChi.Name = "dgvPhieuChi";
            this.dgvPhieuChi.RowHeadersWidth = 62;
            this.dgvPhieuChi.RowTemplate.Height = 28;
            this.dgvPhieuChi.Size = new System.Drawing.Size(941, 353);
            this.dgvPhieuChi.TabIndex = 31;
            this.dgvPhieuChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuChi_CellContentClick);
            // 
            // dgvMaDonNH
            // 
            this.dgvMaDonNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaDonNH.HeaderText = "MaDonNH";
            this.dgvMaDonNH.MinimumWidth = 8;
            this.dgvMaDonNH.Name = "dgvMaDonNH";
            // 
            // dgvNgayNH
            // 
            this.dgvNgayNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNgayNH.HeaderText = "NgayNH";
            this.dgvNgayNH.MinimumWidth = 8;
            this.dgvNgayNH.Name = "dgvNgayNH";
            // 
            // dgvMaNCCPC
            // 
            this.dgvMaNCCPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNCCPC.HeaderText = "MaNCC";
            this.dgvMaNCCPC.MinimumWidth = 8;
            this.dgvMaNCCPC.Name = "dgvMaNCCPC";
            // 
            // dgvTinhTrangPC
            // 
            this.dgvTinhTrangPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTinhTrangPC.HeaderText = " TinhTrang";
            this.dgvTinhTrangPC.MinimumWidth = 8;
            this.dgvTinhTrangPC.Name = "dgvTinhTrangPC";
            // 
            // dgvMaPC
            // 
            this.dgvMaPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaPC.HeaderText = "MaPC";
            this.dgvMaPC.MinimumWidth = 8;
            this.dgvMaPC.Name = "dgvMaPC";
            // 
            // dgvNgayXuatPhieu
            // 
            this.dgvNgayXuatPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNgayXuatPhieu.HeaderText = "NgayXuatPhieu";
            this.dgvNgayXuatPhieu.MinimumWidth = 8;
            this.dgvNgayXuatPhieu.Name = "dgvNgayXuatPhieu";
            // 
            // dgvMaNLPC
            // 
            this.dgvMaNLPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNLPC.HeaderText = "MaNL";
            this.dgvMaNLPC.MinimumWidth = 8;
            this.dgvMaNLPC.Name = "dgvMaNLPC";
            // 
            // dgvDonGiaPC
            // 
            this.dgvDonGiaPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDonGiaPC.HeaderText = "DonGia";
            this.dgvDonGiaPC.MinimumWidth = 8;
            this.dgvDonGiaPC.Name = "dgvDonGiaPC";
            // 
            // dgvSLPC
            // 
            this.dgvSLPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSLPC.HeaderText = "SL";
            this.dgvSLPC.MinimumWidth = 8;
            this.dgvSLPC.Name = "dgvSLPC";
            // 
            // dgvDonViPC
            // 
            this.dgvDonViPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDonViPC.HeaderText = "DonVi";
            this.dgvDonViPC.MinimumWidth = 8;
            this.dgvDonViPC.Name = "dgvDonViPC";
            // 
            // dgvSoTienChi
            // 
            this.dgvSoTienChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSoTienChi.HeaderText = "SoTienChi";
            this.dgvSoTienChi.MinimumWidth = 8;
            this.dgvSoTienChi.Name = "dgvSoTienChi";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(595, 6);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(69, 29);
            this.btnrefresh.TabIndex = 29;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "PHIẾU CHI";
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 477);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKho";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKho.ResumeLayout(false);
            this.tabKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.tabPhieuChi.ResumeLayout(false);
            this.tabPhieuChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKho;
        private System.Windows.Forms.TabPage tabPhieuChi;
        private System.Windows.Forms.DataGridView dgvPhieuChi;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchKho;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Button btnAddNL;
        private System.Windows.Forms.Button btnSearchNL;
        private System.Windows.Forms.Label lbnguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaDonNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNCCPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTinhTrangPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayXuatPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNLPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonGiaPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSLPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonViPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTienChi;
    }
}

