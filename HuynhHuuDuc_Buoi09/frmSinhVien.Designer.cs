namespace HuynhHuuDuc_Buoi09
{
    partial class frmSinhVien
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
            this.btn_HienThiDuLieu = new System.Windows.Forms.Button();
            this.lsV_SinhVien = new System.Windows.Forms.ListView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HienThiDuLieu
            // 
            this.btn_HienThiDuLieu.Location = new System.Drawing.Point(36, 22);
            this.btn_HienThiDuLieu.Name = "btn_HienThiDuLieu";
            this.btn_HienThiDuLieu.Size = new System.Drawing.Size(115, 23);
            this.btn_HienThiDuLieu.TabIndex = 0;
            this.btn_HienThiDuLieu.Text = "Hiển thị dữ liệu";
            this.btn_HienThiDuLieu.UseVisualStyleBackColor = true;
            this.btn_HienThiDuLieu.Click += new System.EventHandler(this.btn_HienThiDuLieu_Click);
            // 
            // lsV_SinhVien
            // 
            this.lsV_SinhVien.Location = new System.Drawing.Point(36, 66);
            this.lsV_SinhVien.Name = "lsV_SinhVien";
            this.lsV_SinhVien.Size = new System.Drawing.Size(507, 247);
            this.lsV_SinhVien.TabIndex = 1;
            this.lsV_SinhVien.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(468, 332);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(269, 19);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(152, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm Sinh Viên";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 388);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lsV_SinhVien);
            this.Controls.Add(this.btn_HienThiDuLieu);
            this.Name = "frmSinhVien";
            this.Text = "Danh sách Sinh Viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HienThiDuLieu;
        private System.Windows.Forms.ListView lsV_SinhVien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
    }
}

