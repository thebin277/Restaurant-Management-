
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQA
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.dgvPhieuChi = new System.Windows.Forms.DataGridView();
            this.dgvSoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonViPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayXuatPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTinhTrangPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNCCPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaDonNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchNL = new System.Windows.Forms.Button();
            this.btnAddNL = new System.Windows.Forms.Button();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.dgvTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchKho = new System.Windows.Forms.TextBox();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabPhanCa = new System.Windows.Forms.TabPage();
            this.tabHoadon = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearchHD = new System.Windows.Forms.Button();
            this.btnRefeshHD = new System.Windows.Forms.Button();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.dgvTriGiaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSanpham = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMenuSP = new System.Windows.Forms.Label();
            this.textBoxSearchSP = new System.Windows.Forms.TextBox();
            this.btnSearchSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnRefeshSP = new System.Windows.Forms.Button();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.dgvdel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabMenuAll = new System.Windows.Forms.TabPage();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.dgvDelSLAll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddSLAll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLSPAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSPAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSPAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenuNuoc = new System.Windows.Forms.TabPage();
            this.dataGridViewNuoc = new System.Windows.Forms.DataGridView();
            this.dgvDelSLNuoc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddSLNuoc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLSPNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSPNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSPNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenuBun = new System.Windows.Forms.TabPage();
            this.dataGridViewBun = new System.Windows.Forms.DataGridView();
            this.dgvDelSLBun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddSLBun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLSPBun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTBun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaBun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSPBun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSPBun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenuCom = new System.Windows.Forms.TabPage();
            this.dataGridViewCom = new System.Windows.Forms.DataGridView();
            this.dgvDelSLCom = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddSLCom = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLSPCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSPCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSPCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenuPho = new System.Windows.Forms.TabPage();
            this.dataGridViewPho = new System.Windows.Forms.DataGridView();
            this.dgvDelSLPho = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddSLPho = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLSPPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSPPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSPPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenuMy = new System.Windows.Forms.TabPage();
            this.dataGridViewMy = new System.Windows.Forms.DataGridView();
            this.dgvDelSLMy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvAddSLMy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvMaLSPMy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTMy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaMy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSPMy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSPMy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.btnCheckKH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.btnRefeshHome = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.tabHoadon.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            this.tabSanpham.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.tabHome.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabMenuAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.tabMenuNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNuoc)).BeginInit();
            this.tabMenuBun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBun)).BeginInit();
            this.tabMenuCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).BeginInit();
            this.tabMenuPho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPho)).BeginInit();
            this.tabMenuMy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 20F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::QuanLyQA.Properties.Resources._3687412;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 759;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvPhieuChi);
            this.tabPage2.Controls.Add(this.btnrefresh);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(944, 520);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Phiếu Chi";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(834, 12);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(69, 29);
            this.btnrefresh.TabIndex = 29;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // dgvPhieuChi
            // 
            this.dgvPhieuChi.AllowUserToAddRows = false;
            this.dgvPhieuChi.AllowUserToDeleteRows = false;
            this.dgvPhieuChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvPhieuChi.Location = new System.Drawing.Point(0, 59);
            this.dgvPhieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuChi.Name = "dgvPhieuChi";
            this.dgvPhieuChi.ReadOnly = true;
            this.dgvPhieuChi.RowHeadersWidth = 62;
            this.dgvPhieuChi.RowTemplate.Height = 28;
            this.dgvPhieuChi.Size = new System.Drawing.Size(948, 465);
            this.dgvPhieuChi.TabIndex = 31;
            // 
            // dgvSoTienChi
            // 
            this.dgvSoTienChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSoTienChi.HeaderText = "SoTienChi";
            this.dgvSoTienChi.MinimumWidth = 8;
            this.dgvSoTienChi.Name = "dgvSoTienChi";
            this.dgvSoTienChi.ReadOnly = true;
            // 
            // dgvDonViPC
            // 
            this.dgvDonViPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDonViPC.HeaderText = "DonVi";
            this.dgvDonViPC.MinimumWidth = 8;
            this.dgvDonViPC.Name = "dgvDonViPC";
            this.dgvDonViPC.ReadOnly = true;
            // 
            // dgvSLPC
            // 
            this.dgvSLPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSLPC.HeaderText = "SL";
            this.dgvSLPC.MinimumWidth = 8;
            this.dgvSLPC.Name = "dgvSLPC";
            this.dgvSLPC.ReadOnly = true;
            // 
            // dgvDonGiaPC
            // 
            this.dgvDonGiaPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDonGiaPC.HeaderText = "DonGia";
            this.dgvDonGiaPC.MinimumWidth = 8;
            this.dgvDonGiaPC.Name = "dgvDonGiaPC";
            this.dgvDonGiaPC.ReadOnly = true;
            // 
            // dgvMaNLPC
            // 
            this.dgvMaNLPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNLPC.HeaderText = "MaNL";
            this.dgvMaNLPC.MinimumWidth = 8;
            this.dgvMaNLPC.Name = "dgvMaNLPC";
            this.dgvMaNLPC.ReadOnly = true;
            // 
            // dgvNgayXuatPhieu
            // 
            this.dgvNgayXuatPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNgayXuatPhieu.HeaderText = "NgayXuatPhieu";
            this.dgvNgayXuatPhieu.MinimumWidth = 8;
            this.dgvNgayXuatPhieu.Name = "dgvNgayXuatPhieu";
            this.dgvNgayXuatPhieu.ReadOnly = true;
            // 
            // dgvMaPC
            // 
            this.dgvMaPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaPC.HeaderText = "MaPC";
            this.dgvMaPC.MinimumWidth = 8;
            this.dgvMaPC.Name = "dgvMaPC";
            this.dgvMaPC.ReadOnly = true;
            // 
            // dgvTinhTrangPC
            // 
            this.dgvTinhTrangPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTinhTrangPC.HeaderText = " TinhTrang";
            this.dgvTinhTrangPC.MinimumWidth = 8;
            this.dgvTinhTrangPC.Name = "dgvTinhTrangPC";
            this.dgvTinhTrangPC.ReadOnly = true;
            // 
            // dgvMaNCCPC
            // 
            this.dgvMaNCCPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNCCPC.HeaderText = "MaNCC";
            this.dgvMaNCCPC.MinimumWidth = 8;
            this.dgvMaNCCPC.Name = "dgvMaNCCPC";
            this.dgvMaNCCPC.ReadOnly = true;
            // 
            // dgvNgayNH
            // 
            this.dgvNgayNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNgayNH.HeaderText = "NgayNH";
            this.dgvNgayNH.MinimumWidth = 8;
            this.dgvNgayNH.Name = "dgvNgayNH";
            this.dgvNgayNH.ReadOnly = true;
            // 
            // dgvMaDonNH
            // 
            this.dgvMaDonNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaDonNH.HeaderText = "MaDonNH";
            this.dgvMaDonNH.MinimumWidth = 8;
            this.dgvMaDonNH.Name = "dgvMaDonNH";
            this.dgvMaDonNH.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Phiếu Chi";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonrefresh);
            this.tabPage1.Controls.Add(this.txtSearchKho);
            this.tabPage1.Controls.Add(this.dgvKho);
            this.tabPage1.Controls.Add(this.btnAddNL);
            this.tabPage1.Controls.Add(this.btnSearchNL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(944, 520);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Kho";
            // 
            // btnSearchNL
            // 
            this.btnSearchNL.BackColor = System.Drawing.Color.White;
            this.btnSearchNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNL.Location = new System.Drawing.Point(433, 27);
            this.btnSearchNL.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNL.Name = "btnSearchNL";
            this.btnSearchNL.Size = new System.Drawing.Size(127, 28);
            this.btnSearchNL.TabIndex = 21;
            this.btnSearchNL.Text = "Tìm";
            this.btnSearchNL.UseVisualStyleBackColor = false;
            this.btnSearchNL.Click += new System.EventHandler(this.btnSearchNL_Click);
            // 
            // btnAddNL
            // 
            this.btnAddNL.BackColor = System.Drawing.Color.White;
            this.btnAddNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNL.Location = new System.Drawing.Point(593, 27);
            this.btnAddNL.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNL.Name = "btnAddNL";
            this.btnAddNL.Size = new System.Drawing.Size(150, 28);
            this.btnAddNL.TabIndex = 22;
            this.btnAddNL.Text = "Thêm Nguyên Liệu";
            this.btnAddNL.UseVisualStyleBackColor = false;
            this.btnAddNL.Click += new System.EventHandler(this.btnAddNL_Click);
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
            this.dgvTT});
            this.dgvKho.Location = new System.Drawing.Point(0, 80);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersWidth = 62;
            this.dgvKho.RowTemplate.Height = 28;
            this.dgvKho.Size = new System.Drawing.Size(944, 444);
            this.dgvKho.TabIndex = 23;
            // 
            // dgvTT
            // 
            this.dgvTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTT.HeaderText = "TinhTrang";
            this.dgvTT.MinimumWidth = 8;
            this.dgvTT.Name = "dgvTT";
            this.dgvTT.ReadOnly = true;
            // 
            // dgvDonVi
            // 
            this.dgvDonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDonVi.HeaderText = "DonVi";
            this.dgvDonVi.MinimumWidth = 8;
            this.dgvDonVi.Name = "dgvDonVi";
            this.dgvDonVi.ReadOnly = true;
            // 
            // dgvSL
            // 
            this.dgvSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSL.HeaderText = "SL";
            this.dgvSL.MinimumWidth = 8;
            this.dgvSL.Name = "dgvSL";
            this.dgvSL.ReadOnly = true;
            // 
            // dgvMaNCC
            // 
            this.dgvMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNCC.HeaderText = "MaNCC";
            this.dgvMaNCC.MinimumWidth = 8;
            this.dgvMaNCC.Name = "dgvMaNCC";
            this.dgvMaNCC.ReadOnly = true;
            // 
            // dgvTenNL
            // 
            this.dgvTenNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTenNL.HeaderText = "TenNL";
            this.dgvTenNL.MinimumWidth = 8;
            this.dgvTenNL.Name = "dgvTenNL";
            this.dgvTenNL.ReadOnly = true;
            // 
            // dgvMaNL
            // 
            this.dgvMaNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMaNL.HeaderText = "MaNL";
            this.dgvMaNL.MinimumWidth = 8;
            this.dgvMaNL.Name = "dgvMaNL";
            this.dgvMaNL.ReadOnly = true;
            // 
            // txtSearchKho
            // 
            this.txtSearchKho.BackColor = System.Drawing.Color.White;
            this.txtSearchKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchKho.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearchKho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearchKho.Location = new System.Drawing.Point(224, 27);
            this.txtSearchKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKho.Multiline = true;
            this.txtSearchKho.Name = "txtSearchKho";
            this.txtSearchKho.Size = new System.Drawing.Size(181, 28);
            this.txtSearchKho.TabIndex = 24;
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.BackColor = System.Drawing.Color.White;
            this.buttonrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrefresh.Location = new System.Drawing.Point(770, 27);
            this.buttonrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(150, 28);
            this.buttonrefresh.TabIndex = 25;
            this.buttonrefresh.Text = "Refresh";
            this.buttonrefresh.UseVisualStyleBackColor = false;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kho Nguyên Liệu";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(944, 520);
            this.tabNhanVien.TabIndex = 4;
            this.tabNhanVien.Text = "Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPhanCa
            // 
            this.tabPhanCa.Location = new System.Drawing.Point(4, 22);
            this.tabPhanCa.Name = "tabPhanCa";
            this.tabPhanCa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanCa.Size = new System.Drawing.Size(944, 520);
            this.tabPhanCa.TabIndex = 3;
            this.tabPhanCa.Text = "Phân Ca";
            this.tabPhanCa.UseVisualStyleBackColor = true;
            // 
            // tabHoadon
            // 
            this.tabHoadon.Controls.Add(this.dataGridViewHD);
            this.tabHoadon.Controls.Add(this.panel3);
            this.tabHoadon.Location = new System.Drawing.Point(4, 22);
            this.tabHoadon.Margin = new System.Windows.Forms.Padding(2);
            this.tabHoadon.Name = "tabHoadon";
            this.tabHoadon.Size = new System.Drawing.Size(944, 520);
            this.tabHoadon.TabIndex = 2;
            this.tabHoadon.Text = "Hóa đơn";
            this.tabHoadon.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnRefeshHD);
            this.panel3.Controls.Add(this.btnSearchHD);
            this.panel3.Controls.Add(this.dateTimePickerTo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateTimePickerFrom);
            this.panel3.Controls.Add(this.lblFrom);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 67);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hóa đơn";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(135, 24);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 21);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(185, 24);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(350, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(380, 24);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // btnSearchHD
            // 
            this.btnSearchHD.BackColor = System.Drawing.Color.White;
            this.btnSearchHD.Location = new System.Drawing.Point(573, 17);
            this.btnSearchHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchHD.Name = "btnSearchHD";
            this.btnSearchHD.Size = new System.Drawing.Size(95, 32);
            this.btnSearchHD.TabIndex = 6;
            this.btnSearchHD.Text = "Tìm kiếm";
            this.btnSearchHD.UseVisualStyleBackColor = false;
            this.btnSearchHD.Click += new System.EventHandler(this.btnSearchHD_Click);
            // 
            // btnRefeshHD
            // 
            this.btnRefeshHD.BackColor = System.Drawing.Color.White;
            this.btnRefeshHD.Location = new System.Drawing.Point(701, 20);
            this.btnRefeshHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefeshHD.Name = "btnRefeshHD";
            this.btnRefeshHD.Size = new System.Drawing.Size(98, 29);
            this.btnRefeshHD.TabIndex = 7;
            this.btnRefeshHD.Text = "Làm mới";
            this.btnRefeshHD.UseVisualStyleBackColor = false;
            this.btnRefeshHD.Click += new System.EventHandler(this.btnRefeshHD_Click);
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.AllowUserToAddRows = false;
            this.dataGridViewHD.AllowUserToDeleteRows = false;
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaHD,
            this.dgvNgayDH,
            this.dgvMaKH,
            this.dgvMaNV,
            this.dgvTriGiaHD});
            this.dataGridViewHD.Location = new System.Drawing.Point(1, 66);
            this.dataGridViewHD.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.ReadOnly = true;
            this.dataGridViewHD.RowHeadersWidth = 62;
            this.dataGridViewHD.RowTemplate.Height = 33;
            this.dataGridViewHD.Size = new System.Drawing.Size(943, 452);
            this.dataGridViewHD.TabIndex = 1;
            // 
            // dgvTriGiaHD
            // 
            this.dgvTriGiaHD.HeaderText = "Trị giá hóa đơn";
            this.dgvTriGiaHD.MinimumWidth = 8;
            this.dgvTriGiaHD.Name = "dgvTriGiaHD";
            this.dgvTriGiaHD.ReadOnly = true;
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.HeaderText = "Mã nhân viên";
            this.dgvMaNV.MinimumWidth = 8;
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.ReadOnly = true;
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.HeaderText = "Mã khách hàng";
            this.dgvMaKH.MinimumWidth = 8;
            this.dgvMaKH.Name = "dgvMaKH";
            this.dgvMaKH.ReadOnly = true;
            // 
            // dgvNgayDH
            // 
            this.dgvNgayDH.HeaderText = "Ngày đặt hàng";
            this.dgvNgayDH.MinimumWidth = 8;
            this.dgvNgayDH.Name = "dgvNgayDH";
            this.dgvNgayDH.ReadOnly = true;
            // 
            // dgvMaHD
            // 
            this.dgvMaHD.HeaderText = "Mã hóa đơn";
            this.dgvMaHD.MinimumWidth = 8;
            this.dgvMaHD.Name = "dgvMaHD";
            this.dgvMaHD.ReadOnly = true;
            // 
            // tabSanpham
            // 
            this.tabSanpham.Controls.Add(this.dataGridViewSP);
            this.tabSanpham.Controls.Add(this.panel2);
            this.tabSanpham.Location = new System.Drawing.Point(4, 22);
            this.tabSanpham.Margin = new System.Windows.Forms.Padding(2);
            this.tabSanpham.Name = "tabSanpham";
            this.tabSanpham.Padding = new System.Windows.Forms.Padding(2);
            this.tabSanpham.Size = new System.Drawing.Size(944, 520);
            this.tabSanpham.TabIndex = 1;
            this.tabSanpham.Text = "Sản phẩm";
            this.tabSanpham.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnRefeshSP);
            this.panel2.Controls.Add(this.btnAddSP);
            this.panel2.Controls.Add(this.btnSearchSP);
            this.panel2.Controls.Add(this.textBoxSearchSP);
            this.panel2.Controls.Add(this.lblMenuSP);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 79);
            this.panel2.TabIndex = 0;
            // 
            // lblMenuSP
            // 
            this.lblMenuSP.AutoSize = true;
            this.lblMenuSP.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.lblMenuSP.ForeColor = System.Drawing.Color.White;
            this.lblMenuSP.Location = new System.Drawing.Point(2, 20);
            this.lblMenuSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuSP.Name = "lblMenuSP";
            this.lblMenuSP.Size = new System.Drawing.Size(207, 32);
            this.lblMenuSP.TabIndex = 0;
            this.lblMenuSP.Text = "Menu sản phẩm";
            // 
            // textBoxSearchSP
            // 
            this.textBoxSearchSP.Location = new System.Drawing.Point(213, 27);
            this.textBoxSearchSP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchSP.Name = "textBoxSearchSP";
            this.textBoxSearchSP.Size = new System.Drawing.Size(263, 20);
            this.textBoxSearchSP.TabIndex = 1;
            // 
            // btnSearchSP
            // 
            this.btnSearchSP.BackColor = System.Drawing.Color.White;
            this.btnSearchSP.Location = new System.Drawing.Point(494, 20);
            this.btnSearchSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchSP.Name = "btnSearchSP";
            this.btnSearchSP.Size = new System.Drawing.Size(106, 32);
            this.btnSearchSP.TabIndex = 2;
            this.btnSearchSP.Text = "Tìm kiếm";
            this.btnSearchSP.UseVisualStyleBackColor = false;
            this.btnSearchSP.Click += new System.EventHandler(this.btnSearchSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.BackColor = System.Drawing.Color.White;
            this.btnAddSP.Location = new System.Drawing.Point(617, 20);
            this.btnAddSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(119, 32);
            this.btnAddSP.TabIndex = 3;
            this.btnAddSP.Text = "Thêm sản phẩm";
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // btnRefeshSP
            // 
            this.btnRefeshSP.BackColor = System.Drawing.Color.White;
            this.btnRefeshSP.Location = new System.Drawing.Point(752, 20);
            this.btnRefeshSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefeshSP.Name = "btnRefeshSP";
            this.btnRefeshSP.Size = new System.Drawing.Size(109, 32);
            this.btnRefeshSP.TabIndex = 4;
            this.btnRefeshSP.Text = "Làm mới";
            this.btnRefeshSP.UseVisualStyleBackColor = false;
            this.btnRefeshSP.Click += new System.EventHandler(this.btnRefeshSP_Click);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.AllowUserToAddRows = false;
            this.dataGridViewSP.AllowUserToDeleteRows = false;
            this.dataGridViewSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSP,
            this.dgvTenSP,
            this.dgvDonGia,
            this.dgvTinhTrang,
            this.dgvMaLoaiSP,
            this.dgvedit,
            this.dgvdel});
            this.dataGridViewSP.Location = new System.Drawing.Point(0, 84);
            this.dataGridViewSP.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.ReadOnly = true;
            this.dataGridViewSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewSP.RowTemplate.Height = 33;
            this.dataGridViewSP.Size = new System.Drawing.Size(944, 434);
            this.dataGridViewSP.TabIndex = 1;
            this.dataGridViewSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellContentClick);
            // 
            // dgvdel
            // 
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.HeaderText = "Xóa";
            this.dgvdel.MinimumWidth = 100;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.UseColumnTextForButtonValue = true;
            this.dgvdel.Width = 150;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.HeaderText = "Sửa";
            this.dgvedit.MinimumWidth = 100;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.UseColumnTextForButtonValue = true;
            this.dgvedit.Width = 150;
            // 
            // dgvMaLoaiSP
            // 
            this.dgvMaLoaiSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMaLoaiSP.HeaderText = "Mã loại sản phẩm";
            this.dgvMaLoaiSP.MinimumWidth = 8;
            this.dgvMaLoaiSP.Name = "dgvMaLoaiSP";
            this.dgvMaLoaiSP.ReadOnly = true;
            // 
            // dgvTinhTrang
            // 
            this.dgvTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTinhTrang.HeaderText = "Tình Trạng";
            this.dgvTinhTrang.MinimumWidth = 8;
            this.dgvTinhTrang.Name = "dgvTinhTrang";
            this.dgvTinhTrang.ReadOnly = true;
            this.dgvTinhTrang.Width = 129;
            // 
            // dgvDonGia
            // 
            this.dgvDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDonGia.HeaderText = "Đơn giá";
            this.dgvDonGia.MinimumWidth = 8;
            this.dgvDonGia.Name = "dgvDonGia";
            this.dgvDonGia.ReadOnly = true;
            this.dgvDonGia.Width = 135;
            // 
            // dgvTenSP
            // 
            this.dgvTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTenSP.HeaderText = "Tên sản phẩm";
            this.dgvTenSP.MinimumWidth = 8;
            this.dgvTenSP.Name = "dgvTenSP";
            this.dgvTenSP.ReadOnly = true;
            this.dgvTenSP.Width = 150;
            // 
            // dgvMaSP
            // 
            this.dgvMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMaSP.Frozen = true;
            this.dgvMaSP.HeaderText = "Mã sản phẩm";
            this.dgvMaSP.MinimumWidth = 8;
            this.dgvMaSP.Name = "dgvMaSP";
            this.dgvMaSP.ReadOnly = true;
            this.dgvMaSP.Width = 160;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.btnRefeshHome);
            this.tabHome.Controls.Add(this.panel1);
            this.tabHome.Controls.Add(this.tabControl2);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabHome.Size = new System.Drawing.Size(944, 520);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabMenuMy);
            this.tabControl2.Controls.Add(this.tabMenuPho);
            this.tabControl2.Controls.Add(this.tabMenuCom);
            this.tabControl2.Controls.Add(this.tabMenuBun);
            this.tabControl2.Controls.Add(this.tabMenuNuoc);
            this.tabControl2.Controls.Add(this.tabMenuAll);
            this.tabControl2.Location = new System.Drawing.Point(2, 24);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(627, 496);
            this.tabControl2.TabIndex = 0;
            // 
            // tabMenuAll
            // 
            this.tabMenuAll.Controls.Add(this.dataGridViewAll);
            this.tabMenuAll.Location = new System.Drawing.Point(4, 22);
            this.tabMenuAll.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuAll.Name = "tabMenuAll";
            this.tabMenuAll.Size = new System.Drawing.Size(619, 470);
            this.tabMenuAll.TabIndex = 5;
            this.tabMenuAll.Text = "Tất cả";
            this.tabMenuAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AllowUserToAddRows = false;
            this.dataGridViewAll.AllowUserToDeleteRows = false;
            this.dataGridViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSPAll,
            this.dgvTenSPAll,
            this.dgvDonGiaAll,
            this.dgvTTAll,
            this.dgvMaLSPAll,
            this.dgvAddSLAll,
            this.dgvDelSLAll});
            this.dataGridViewAll.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.RowHeadersWidth = 62;
            this.dataGridViewAll.RowTemplate.Height = 33;
            this.dataGridViewAll.Size = new System.Drawing.Size(622, 476);
            this.dataGridViewAll.TabIndex = 0;
            // 
            // dgvDelSLAll
            // 
            this.dgvDelSLAll.FillWeight = 70F;
            this.dgvDelSLAll.HeaderText = "Xóa";
            this.dgvDelSLAll.MinimumWidth = 8;
            this.dgvDelSLAll.Name = "dgvDelSLAll";
            this.dgvDelSLAll.ReadOnly = true;
            // 
            // dgvAddSLAll
            // 
            this.dgvAddSLAll.FillWeight = 70F;
            this.dgvAddSLAll.HeaderText = "Thêm";
            this.dgvAddSLAll.MinimumWidth = 8;
            this.dgvAddSLAll.Name = "dgvAddSLAll";
            this.dgvAddSLAll.ReadOnly = true;
            // 
            // dgvMaLSPAll
            // 
            this.dgvMaLSPAll.HeaderText = "Mã loại SP";
            this.dgvMaLSPAll.MinimumWidth = 8;
            this.dgvMaLSPAll.Name = "dgvMaLSPAll";
            this.dgvMaLSPAll.ReadOnly = true;
            // 
            // dgvTTAll
            // 
            this.dgvTTAll.HeaderText = "Tình trạng";
            this.dgvTTAll.MinimumWidth = 8;
            this.dgvTTAll.Name = "dgvTTAll";
            this.dgvTTAll.ReadOnly = true;
            // 
            // dgvDonGiaAll
            // 
            this.dgvDonGiaAll.HeaderText = "Đơn giá";
            this.dgvDonGiaAll.MinimumWidth = 8;
            this.dgvDonGiaAll.Name = "dgvDonGiaAll";
            this.dgvDonGiaAll.ReadOnly = true;
            // 
            // dgvTenSPAll
            // 
            this.dgvTenSPAll.HeaderText = "Tên SP";
            this.dgvTenSPAll.MinimumWidth = 8;
            this.dgvTenSPAll.Name = "dgvTenSPAll";
            this.dgvTenSPAll.ReadOnly = true;
            // 
            // dgvMaSPAll
            // 
            this.dgvMaSPAll.HeaderText = "Mã SP";
            this.dgvMaSPAll.MinimumWidth = 8;
            this.dgvMaSPAll.Name = "dgvMaSPAll";
            this.dgvMaSPAll.ReadOnly = true;
            // 
            // tabMenuNuoc
            // 
            this.tabMenuNuoc.Controls.Add(this.dataGridViewNuoc);
            this.tabMenuNuoc.Location = new System.Drawing.Point(4, 22);
            this.tabMenuNuoc.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuNuoc.Name = "tabMenuNuoc";
            this.tabMenuNuoc.Size = new System.Drawing.Size(619, 470);
            this.tabMenuNuoc.TabIndex = 4;
            this.tabMenuNuoc.Text = "Nước";
            this.tabMenuNuoc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNuoc
            // 
            this.dataGridViewNuoc.AllowUserToAddRows = false;
            this.dataGridViewNuoc.AllowUserToDeleteRows = false;
            this.dataGridViewNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSPNuoc,
            this.dgvTenSPNuoc,
            this.dgvDonGiaNuoc,
            this.dgvTTNuoc,
            this.dgvMaLSPNuoc,
            this.dgvAddSLNuoc,
            this.dgvDelSLNuoc});
            this.dataGridViewNuoc.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewNuoc.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNuoc.Name = "dataGridViewNuoc";
            this.dataGridViewNuoc.ReadOnly = true;
            this.dataGridViewNuoc.RowHeadersWidth = 62;
            this.dataGridViewNuoc.RowTemplate.Height = 33;
            this.dataGridViewNuoc.Size = new System.Drawing.Size(615, 470);
            this.dataGridViewNuoc.TabIndex = 0;
            // 
            // dgvDelSLNuoc
            // 
            this.dgvDelSLNuoc.FillWeight = 70F;
            this.dgvDelSLNuoc.HeaderText = "Xóa";
            this.dgvDelSLNuoc.MinimumWidth = 8;
            this.dgvDelSLNuoc.Name = "dgvDelSLNuoc";
            this.dgvDelSLNuoc.ReadOnly = true;
            // 
            // dgvAddSLNuoc
            // 
            this.dgvAddSLNuoc.FillWeight = 70F;
            this.dgvAddSLNuoc.HeaderText = "Thêm";
            this.dgvAddSLNuoc.MinimumWidth = 8;
            this.dgvAddSLNuoc.Name = "dgvAddSLNuoc";
            this.dgvAddSLNuoc.ReadOnly = true;
            // 
            // dgvMaLSPNuoc
            // 
            this.dgvMaLSPNuoc.HeaderText = "Mã loại SP";
            this.dgvMaLSPNuoc.MinimumWidth = 8;
            this.dgvMaLSPNuoc.Name = "dgvMaLSPNuoc";
            this.dgvMaLSPNuoc.ReadOnly = true;
            // 
            // dgvTTNuoc
            // 
            this.dgvTTNuoc.HeaderText = "Tình trạng";
            this.dgvTTNuoc.MinimumWidth = 8;
            this.dgvTTNuoc.Name = "dgvTTNuoc";
            this.dgvTTNuoc.ReadOnly = true;
            // 
            // dgvDonGiaNuoc
            // 
            this.dgvDonGiaNuoc.HeaderText = "Đơn giá";
            this.dgvDonGiaNuoc.MinimumWidth = 8;
            this.dgvDonGiaNuoc.Name = "dgvDonGiaNuoc";
            this.dgvDonGiaNuoc.ReadOnly = true;
            // 
            // dgvTenSPNuoc
            // 
            this.dgvTenSPNuoc.HeaderText = "Tên SP";
            this.dgvTenSPNuoc.MinimumWidth = 8;
            this.dgvTenSPNuoc.Name = "dgvTenSPNuoc";
            this.dgvTenSPNuoc.ReadOnly = true;
            // 
            // dgvMaSPNuoc
            // 
            this.dgvMaSPNuoc.HeaderText = "Mã SP";
            this.dgvMaSPNuoc.MinimumWidth = 8;
            this.dgvMaSPNuoc.Name = "dgvMaSPNuoc";
            this.dgvMaSPNuoc.ReadOnly = true;
            // 
            // tabMenuBun
            // 
            this.tabMenuBun.Controls.Add(this.dataGridViewBun);
            this.tabMenuBun.Location = new System.Drawing.Point(4, 22);
            this.tabMenuBun.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuBun.Name = "tabMenuBun";
            this.tabMenuBun.Size = new System.Drawing.Size(619, 470);
            this.tabMenuBun.TabIndex = 3;
            this.tabMenuBun.Text = "Bún";
            this.tabMenuBun.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBun
            // 
            this.dataGridViewBun.AllowUserToAddRows = false;
            this.dataGridViewBun.AllowUserToDeleteRows = false;
            this.dataGridViewBun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSPBun,
            this.dgvTenSPBun,
            this.dgvDonGiaBun,
            this.dgvTTBun,
            this.dgvMaLSPBun,
            this.dgvAddSLBun,
            this.dgvDelSLBun});
            this.dataGridViewBun.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewBun.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBun.Name = "dataGridViewBun";
            this.dataGridViewBun.ReadOnly = true;
            this.dataGridViewBun.RowHeadersWidth = 62;
            this.dataGridViewBun.RowTemplate.Height = 33;
            this.dataGridViewBun.Size = new System.Drawing.Size(616, 467);
            this.dataGridViewBun.TabIndex = 0;
            // 
            // dgvDelSLBun
            // 
            this.dgvDelSLBun.FillWeight = 70F;
            this.dgvDelSLBun.HeaderText = "Xóa";
            this.dgvDelSLBun.MinimumWidth = 8;
            this.dgvDelSLBun.Name = "dgvDelSLBun";
            this.dgvDelSLBun.ReadOnly = true;
            // 
            // dgvAddSLBun
            // 
            this.dgvAddSLBun.FillWeight = 70F;
            this.dgvAddSLBun.HeaderText = "Thêm";
            this.dgvAddSLBun.MinimumWidth = 8;
            this.dgvAddSLBun.Name = "dgvAddSLBun";
            this.dgvAddSLBun.ReadOnly = true;
            // 
            // dgvMaLSPBun
            // 
            this.dgvMaLSPBun.HeaderText = "Mã loại SP";
            this.dgvMaLSPBun.MinimumWidth = 8;
            this.dgvMaLSPBun.Name = "dgvMaLSPBun";
            this.dgvMaLSPBun.ReadOnly = true;
            // 
            // dgvTTBun
            // 
            this.dgvTTBun.HeaderText = "Tình trạng";
            this.dgvTTBun.MinimumWidth = 8;
            this.dgvTTBun.Name = "dgvTTBun";
            this.dgvTTBun.ReadOnly = true;
            // 
            // dgvDonGiaBun
            // 
            this.dgvDonGiaBun.HeaderText = "Đơn giá";
            this.dgvDonGiaBun.MinimumWidth = 8;
            this.dgvDonGiaBun.Name = "dgvDonGiaBun";
            this.dgvDonGiaBun.ReadOnly = true;
            // 
            // dgvTenSPBun
            // 
            this.dgvTenSPBun.HeaderText = "Tên SP";
            this.dgvTenSPBun.MinimumWidth = 8;
            this.dgvTenSPBun.Name = "dgvTenSPBun";
            this.dgvTenSPBun.ReadOnly = true;
            // 
            // dgvMaSPBun
            // 
            this.dgvMaSPBun.HeaderText = "Mã SP";
            this.dgvMaSPBun.MinimumWidth = 8;
            this.dgvMaSPBun.Name = "dgvMaSPBun";
            this.dgvMaSPBun.ReadOnly = true;
            // 
            // tabMenuCom
            // 
            this.tabMenuCom.Controls.Add(this.dataGridViewCom);
            this.tabMenuCom.Location = new System.Drawing.Point(4, 22);
            this.tabMenuCom.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuCom.Name = "tabMenuCom";
            this.tabMenuCom.Padding = new System.Windows.Forms.Padding(2);
            this.tabMenuCom.Size = new System.Drawing.Size(619, 470);
            this.tabMenuCom.TabIndex = 2;
            this.tabMenuCom.Text = "Cơm";
            this.tabMenuCom.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCom
            // 
            this.dataGridViewCom.AllowUserToAddRows = false;
            this.dataGridViewCom.AllowUserToDeleteRows = false;
            this.dataGridViewCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSPCom,
            this.dgvTenSPCom,
            this.dgvDonGiaCom,
            this.dgvTTCom,
            this.dgvMaLSPCom,
            this.dgvAddSLCom,
            this.dgvDelSLCom});
            this.dataGridViewCom.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewCom.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCom.Name = "dataGridViewCom";
            this.dataGridViewCom.ReadOnly = true;
            this.dataGridViewCom.RowHeadersWidth = 62;
            this.dataGridViewCom.RowTemplate.Height = 33;
            this.dataGridViewCom.Size = new System.Drawing.Size(616, 464);
            this.dataGridViewCom.TabIndex = 0;
            // 
            // dgvDelSLCom
            // 
            this.dgvDelSLCom.FillWeight = 70F;
            this.dgvDelSLCom.HeaderText = "Xóa";
            this.dgvDelSLCom.MinimumWidth = 8;
            this.dgvDelSLCom.Name = "dgvDelSLCom";
            this.dgvDelSLCom.ReadOnly = true;
            // 
            // dgvAddSLCom
            // 
            this.dgvAddSLCom.FillWeight = 70F;
            this.dgvAddSLCom.HeaderText = "Thêm";
            this.dgvAddSLCom.MinimumWidth = 8;
            this.dgvAddSLCom.Name = "dgvAddSLCom";
            this.dgvAddSLCom.ReadOnly = true;
            // 
            // dgvMaLSPCom
            // 
            this.dgvMaLSPCom.HeaderText = "Mã loại SP";
            this.dgvMaLSPCom.MinimumWidth = 8;
            this.dgvMaLSPCom.Name = "dgvMaLSPCom";
            this.dgvMaLSPCom.ReadOnly = true;
            // 
            // dgvTTCom
            // 
            this.dgvTTCom.HeaderText = "Tình trạng";
            this.dgvTTCom.MinimumWidth = 8;
            this.dgvTTCom.Name = "dgvTTCom";
            this.dgvTTCom.ReadOnly = true;
            // 
            // dgvDonGiaCom
            // 
            this.dgvDonGiaCom.HeaderText = "Đơn giá";
            this.dgvDonGiaCom.MinimumWidth = 8;
            this.dgvDonGiaCom.Name = "dgvDonGiaCom";
            this.dgvDonGiaCom.ReadOnly = true;
            // 
            // dgvTenSPCom
            // 
            this.dgvTenSPCom.HeaderText = "Tên SP";
            this.dgvTenSPCom.MinimumWidth = 8;
            this.dgvTenSPCom.Name = "dgvTenSPCom";
            this.dgvTenSPCom.ReadOnly = true;
            // 
            // dgvMaSPCom
            // 
            this.dgvMaSPCom.HeaderText = "Mã SP";
            this.dgvMaSPCom.MinimumWidth = 8;
            this.dgvMaSPCom.Name = "dgvMaSPCom";
            this.dgvMaSPCom.ReadOnly = true;
            // 
            // tabMenuPho
            // 
            this.tabMenuPho.Controls.Add(this.dataGridViewPho);
            this.tabMenuPho.Location = new System.Drawing.Point(4, 22);
            this.tabMenuPho.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuPho.Name = "tabMenuPho";
            this.tabMenuPho.Padding = new System.Windows.Forms.Padding(2);
            this.tabMenuPho.Size = new System.Drawing.Size(619, 470);
            this.tabMenuPho.TabIndex = 1;
            this.tabMenuPho.Text = "Phở";
            this.tabMenuPho.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPho
            // 
            this.dataGridViewPho.AllowUserToAddRows = false;
            this.dataGridViewPho.AllowUserToDeleteRows = false;
            this.dataGridViewPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSPPho,
            this.dgvTenSPPho,
            this.dgvDonGiaPho,
            this.dgvTTPho,
            this.dgvMaLSPPho,
            this.dgvAddSLPho,
            this.dgvDelSLPho});
            this.dataGridViewPho.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewPho.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPho.Name = "dataGridViewPho";
            this.dataGridViewPho.ReadOnly = true;
            this.dataGridViewPho.RowHeadersWidth = 62;
            this.dataGridViewPho.RowTemplate.Height = 33;
            this.dataGridViewPho.Size = new System.Drawing.Size(615, 465);
            this.dataGridViewPho.TabIndex = 0;
            // 
            // dgvDelSLPho
            // 
            this.dgvDelSLPho.FillWeight = 50F;
            this.dgvDelSLPho.HeaderText = "Xóa";
            this.dgvDelSLPho.MinimumWidth = 8;
            this.dgvDelSLPho.Name = "dgvDelSLPho";
            this.dgvDelSLPho.ReadOnly = true;
            // 
            // dgvAddSLPho
            // 
            this.dgvAddSLPho.FillWeight = 50F;
            this.dgvAddSLPho.HeaderText = "Thêm";
            this.dgvAddSLPho.MinimumWidth = 8;
            this.dgvAddSLPho.Name = "dgvAddSLPho";
            this.dgvAddSLPho.ReadOnly = true;
            // 
            // dgvMaLSPPho
            // 
            this.dgvMaLSPPho.HeaderText = "Mã loại SP";
            this.dgvMaLSPPho.MinimumWidth = 8;
            this.dgvMaLSPPho.Name = "dgvMaLSPPho";
            this.dgvMaLSPPho.ReadOnly = true;
            // 
            // dgvTTPho
            // 
            this.dgvTTPho.HeaderText = "Tình trạng";
            this.dgvTTPho.MinimumWidth = 8;
            this.dgvTTPho.Name = "dgvTTPho";
            this.dgvTTPho.ReadOnly = true;
            // 
            // dgvDonGiaPho
            // 
            this.dgvDonGiaPho.HeaderText = "Đơn giá";
            this.dgvDonGiaPho.MinimumWidth = 8;
            this.dgvDonGiaPho.Name = "dgvDonGiaPho";
            this.dgvDonGiaPho.ReadOnly = true;
            // 
            // dgvTenSPPho
            // 
            this.dgvTenSPPho.HeaderText = "Tên SP";
            this.dgvTenSPPho.MinimumWidth = 8;
            this.dgvTenSPPho.Name = "dgvTenSPPho";
            this.dgvTenSPPho.ReadOnly = true;
            // 
            // dgvMaSPPho
            // 
            this.dgvMaSPPho.HeaderText = "Mã SP";
            this.dgvMaSPPho.MinimumWidth = 8;
            this.dgvMaSPPho.Name = "dgvMaSPPho";
            this.dgvMaSPPho.ReadOnly = true;
            // 
            // tabMenuMy
            // 
            this.tabMenuMy.BackColor = System.Drawing.Color.White;
            this.tabMenuMy.Controls.Add(this.dataGridViewMy);
            this.tabMenuMy.ForeColor = System.Drawing.Color.White;
            this.tabMenuMy.Location = new System.Drawing.Point(4, 22);
            this.tabMenuMy.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuMy.Name = "tabMenuMy";
            this.tabMenuMy.Padding = new System.Windows.Forms.Padding(2);
            this.tabMenuMy.Size = new System.Drawing.Size(619, 470);
            this.tabMenuMy.TabIndex = 0;
            this.tabMenuMy.Text = "Mỳ";
            // 
            // dataGridViewMy
            // 
            this.dataGridViewMy.AllowUserToAddRows = false;
            this.dataGridViewMy.AllowUserToDeleteRows = false;
            this.dataGridViewMy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSPMy,
            this.dgvTenSPMy,
            this.dgvDonGiaMy,
            this.dgvTTMy,
            this.dgvMaLSPMy,
            this.dgvAddSLMy,
            this.dgvDelSLMy});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMy.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMy.Location = new System.Drawing.Point(-2, 2);
            this.dataGridViewMy.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMy.Name = "dataGridViewMy";
            this.dataGridViewMy.ReadOnly = true;
            this.dataGridViewMy.RowHeadersWidth = 62;
            this.dataGridViewMy.RowTemplate.Height = 33;
            this.dataGridViewMy.Size = new System.Drawing.Size(622, 468);
            this.dataGridViewMy.TabIndex = 0;
            // 
            // dgvDelSLMy
            // 
            this.dgvDelSLMy.FillWeight = 50F;
            this.dgvDelSLMy.HeaderText = "Xóa";
            this.dgvDelSLMy.MinimumWidth = 8;
            this.dgvDelSLMy.Name = "dgvDelSLMy";
            this.dgvDelSLMy.ReadOnly = true;
            // 
            // dgvAddSLMy
            // 
            this.dgvAddSLMy.FillWeight = 50F;
            this.dgvAddSLMy.HeaderText = "Thêm";
            this.dgvAddSLMy.MinimumWidth = 8;
            this.dgvAddSLMy.Name = "dgvAddSLMy";
            this.dgvAddSLMy.ReadOnly = true;
            // 
            // dgvMaLSPMy
            // 
            this.dgvMaLSPMy.HeaderText = "Mã loại SP";
            this.dgvMaLSPMy.MinimumWidth = 8;
            this.dgvMaLSPMy.Name = "dgvMaLSPMy";
            this.dgvMaLSPMy.ReadOnly = true;
            // 
            // dgvTTMy
            // 
            this.dgvTTMy.HeaderText = "Tình trạng";
            this.dgvTTMy.MinimumWidth = 8;
            this.dgvTTMy.Name = "dgvTTMy";
            this.dgvTTMy.ReadOnly = true;
            // 
            // dgvDonGiaMy
            // 
            this.dgvDonGiaMy.HeaderText = "Đơn giá";
            this.dgvDonGiaMy.MinimumWidth = 8;
            this.dgvDonGiaMy.Name = "dgvDonGiaMy";
            this.dgvDonGiaMy.ReadOnly = true;
            // 
            // dgvTenSPMy
            // 
            this.dgvTenSPMy.HeaderText = "Tên SP";
            this.dgvTenSPMy.MinimumWidth = 8;
            this.dgvTenSPMy.Name = "dgvTenSPMy";
            this.dgvTenSPMy.ReadOnly = true;
            // 
            // dgvMaSPMy
            // 
            this.dgvMaSPMy.HeaderText = "Mã SP";
            this.dgvMaSPMy.MinimumWidth = 8;
            this.dgvMaSPMy.Name = "dgvMaSPMy";
            this.dgvMaSPMy.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnXuatHD);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnCheckKH);
            this.panel1.Controls.Add(this.textBoxSDT);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(633, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 518);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.lblSDT.Location = new System.Drawing.Point(13, 56);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(78, 14);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(109, 53);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(198, 20);
            this.textBoxSDT.TabIndex = 2;
            // 
            // btnCheckKH
            // 
            this.btnCheckKH.BackColor = System.Drawing.Color.White;
            this.btnCheckKH.Location = new System.Drawing.Point(190, 80);
            this.btnCheckKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckKH.Name = "btnCheckKH";
            this.btnCheckKH.Size = new System.Drawing.Size(110, 29);
            this.btnCheckKH.TabIndex = 5;
            this.btnCheckKH.Text = "Kiểm tra khách hàng";
            this.btnCheckKH.UseVisualStyleBackColor = false;
            this.btnCheckKH.Click += new System.EventHandler(this.btnCheckKH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(309, 327);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(16, 462);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 40);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Mới";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.BackColor = System.Drawing.Color.White;
            this.btnXuatHD.Location = new System.Drawing.Point(190, 462);
            this.btnXuatHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(102, 40);
            this.btnXuatHD.TabIndex = 8;
            this.btnXuatHD.Text = "Xuất hóa đơn";
            this.btnXuatHD.UseVisualStyleBackColor = false;
            // 
            // btnRefeshHome
            // 
            this.btnRefeshHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefeshHome.Location = new System.Drawing.Point(0, 3);
            this.btnRefeshHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefeshHome.Name = "btnRefeshHome";
            this.btnRefeshHome.Size = new System.Drawing.Size(67, 26);
            this.btnRefeshHome.TabIndex = 2;
            this.btnRefeshHome.Text = "Làm mới";
            this.btnRefeshHome.UseVisualStyleBackColor = false;
            this.btnRefeshHome.Click += new System.EventHandler(this.btnRefeshHome_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabSanpham);
            this.tabControl1.Controls.Add(this.tabHoadon);
            this.tabControl1.Controls.Add(this.tabPhanCa);
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 546);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 542);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán ăn";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.tabHoadon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            this.tabSanpham.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.tabHome.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabMenuAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.tabMenuNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNuoc)).EndInit();
            this.tabMenuBun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBun)).EndInit();
            this.tabMenuCom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).EndInit();
            this.tabMenuPho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPho)).EndInit();
            this.tabMenuMy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewImageColumn dataGridViewImageColumn2;
        private TabPage tabPage2;
        private Label label5;
        private DataGridView dgvPhieuChi;
        private DataGridViewTextBoxColumn dgvMaDonNH;
        private DataGridViewTextBoxColumn dgvNgayNH;
        private DataGridViewTextBoxColumn dgvMaNCCPC;
        private DataGridViewTextBoxColumn dgvTinhTrangPC;
        private DataGridViewTextBoxColumn dgvMaPC;
        private DataGridViewTextBoxColumn dgvNgayXuatPhieu;
        private DataGridViewTextBoxColumn dgvMaNLPC;
        private DataGridViewTextBoxColumn dgvDonGiaPC;
        private DataGridViewTextBoxColumn dgvSLPC;
        private DataGridViewTextBoxColumn dgvDonViPC;
        private DataGridViewTextBoxColumn dgvSoTienChi;
        private Button btnrefresh;
        private TabPage tabPage1;
        private Label label4;
        private Button buttonrefresh;
        private TextBox txtSearchKho;
        private DataGridView dgvKho;
        private DataGridViewTextBoxColumn dgvMaNL;
        private DataGridViewTextBoxColumn dgvTenNL;
        private DataGridViewTextBoxColumn dgvMaNCC;
        private DataGridViewTextBoxColumn dgvSL;
        private DataGridViewTextBoxColumn dgvDonVi;
        private DataGridViewTextBoxColumn dgvTT;
        private Button btnAddNL;
        private Button btnSearchNL;
        private TabPage tabNhanVien;
        private TabPage tabPhanCa;
        private TabPage tabHoadon;
        private DataGridView dataGridViewHD;
        private DataGridViewTextBoxColumn dgvMaHD;
        private DataGridViewTextBoxColumn dgvNgayDH;
        private DataGridViewTextBoxColumn dgvMaKH;
        private DataGridViewTextBoxColumn dgvMaNV;
        private DataGridViewTextBoxColumn dgvTriGiaHD;
        private Panel panel3;
        private Button btnRefeshHD;
        private Button btnSearchHD;
        private DateTimePicker dateTimePickerTo;
        private Label label3;
        private DateTimePicker dateTimePickerFrom;
        private Label lblFrom;
        private Label label2;
        private TabPage tabSanpham;
        private DataGridView dataGridViewSP;
        private DataGridViewTextBoxColumn dgvMaSP;
        private DataGridViewTextBoxColumn dgvTenSP;
        private DataGridViewTextBoxColumn dgvDonGia;
        private DataGridViewTextBoxColumn dgvTinhTrang;
        private DataGridViewTextBoxColumn dgvMaLoaiSP;
        private DataGridViewButtonColumn dgvedit;
        private DataGridViewButtonColumn dgvdel;
        private Panel panel2;
        private Button btnRefeshSP;
        private Button btnAddSP;
        private Button btnSearchSP;
        private TextBox textBoxSearchSP;
        private Label lblMenuSP;
        private TabPage tabHome;
        private Button btnRefeshHome;
        private Panel panel1;
        private Button btnXuatHD;
        private Button btnNew;
        private DataGridView dataGridView1;
        private Button btnCheckKH;
        private TextBox textBoxSDT;
        private Label lblSDT;
        private Label label1;
        private TabControl tabControl2;
        private TabPage tabMenuMy;
        private DataGridView dataGridViewMy;
        private DataGridViewTextBoxColumn dgvMaSPMy;
        private DataGridViewTextBoxColumn dgvTenSPMy;
        private DataGridViewTextBoxColumn dgvDonGiaMy;
        private DataGridViewTextBoxColumn dgvTTMy;
        private DataGridViewTextBoxColumn dgvMaLSPMy;
        private DataGridViewButtonColumn dgvAddSLMy;
        private DataGridViewButtonColumn dgvDelSLMy;
        private TabPage tabMenuPho;
        private DataGridView dataGridViewPho;
        private DataGridViewTextBoxColumn dgvMaSPPho;
        private DataGridViewTextBoxColumn dgvTenSPPho;
        private DataGridViewTextBoxColumn dgvDonGiaPho;
        private DataGridViewTextBoxColumn dgvTTPho;
        private DataGridViewTextBoxColumn dgvMaLSPPho;
        private DataGridViewButtonColumn dgvAddSLPho;
        private DataGridViewButtonColumn dgvDelSLPho;
        private TabPage tabMenuCom;
        private DataGridView dataGridViewCom;
        private DataGridViewTextBoxColumn dgvMaSPCom;
        private DataGridViewTextBoxColumn dgvTenSPCom;
        private DataGridViewTextBoxColumn dgvDonGiaCom;
        private DataGridViewTextBoxColumn dgvTTCom;
        private DataGridViewTextBoxColumn dgvMaLSPCom;
        private DataGridViewButtonColumn dgvAddSLCom;
        private DataGridViewButtonColumn dgvDelSLCom;
        private TabPage tabMenuBun;
        private DataGridView dataGridViewBun;
        private DataGridViewTextBoxColumn dgvMaSPBun;
        private DataGridViewTextBoxColumn dgvTenSPBun;
        private DataGridViewTextBoxColumn dgvDonGiaBun;
        private DataGridViewTextBoxColumn dgvTTBun;
        private DataGridViewTextBoxColumn dgvMaLSPBun;
        private DataGridViewButtonColumn dgvAddSLBun;
        private DataGridViewButtonColumn dgvDelSLBun;
        private TabPage tabMenuNuoc;
        private DataGridView dataGridViewNuoc;
        private DataGridViewTextBoxColumn dgvMaSPNuoc;
        private DataGridViewTextBoxColumn dgvTenSPNuoc;
        private DataGridViewTextBoxColumn dgvDonGiaNuoc;
        private DataGridViewTextBoxColumn dgvTTNuoc;
        private DataGridViewTextBoxColumn dgvMaLSPNuoc;
        private DataGridViewButtonColumn dgvAddSLNuoc;
        private DataGridViewButtonColumn dgvDelSLNuoc;
        private TabPage tabMenuAll;
        private DataGridView dataGridViewAll;
        private DataGridViewTextBoxColumn dgvMaSPAll;
        private DataGridViewTextBoxColumn dgvTenSPAll;
        private DataGridViewTextBoxColumn dgvDonGiaAll;
        private DataGridViewTextBoxColumn dgvTTAll;
        private DataGridViewTextBoxColumn dgvMaLSPAll;
        private DataGridViewButtonColumn dgvAddSLAll;
        private DataGridViewButtonColumn dgvDelSLAll;
        private TabControl tabControl1;
    }
}