namespace QuanLyQA
{
    partial class BangTinhLuong
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
            this.dataGridView1_BangLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_BangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_BangLuong
            // 
            this.dataGridView1_BangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_BangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1_BangLuong.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1_BangLuong.Name = "dataGridView1_BangLuong";
            this.dataGridView1_BangLuong.RowHeadersWidth = 51;
            this.dataGridView1_BangLuong.RowTemplate.Height = 24;
            this.dataGridView1_BangLuong.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1_BangLuong.TabIndex = 0;
            // 
            // BangTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1_BangLuong);
            this.Name = "BangTinhLuong";
            this.Text = "BangTinhLuong";
            this.Load += new System.EventHandler(this.BangTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_BangLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_BangLuong;
    }
}