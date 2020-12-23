namespace GUI
{
    partial class ThemHoaDonForm
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
            this.labelTiTle = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelKhachHang = new System.Windows.Forms.Label();
            this.labelShipper = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.labelNgayTao = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelNgayShip = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKhachHang = new System.Windows.Forms.TextBox();
            this.textBoxShipper = new System.Windows.Forms.TextBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.textBoxNgayTao = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxNgayGiao = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTiTle
            // 
            this.labelTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiTle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTiTle.Location = new System.Drawing.Point(0, 9);
            this.labelTiTle.Name = "labelTiTle";
            this.labelTiTle.Size = new System.Drawing.Size(800, 47);
            this.labelTiTle.TabIndex = 1;
            this.labelTiTle.Text = "Thêm Hóa Đơn";
            this.labelTiTle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(6, 77);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(309, 32);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID Hóa Đơn : ";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(6, 141);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(309, 32);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Tên Hóa Đơn : ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKhachHang
            // 
            this.labelKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhachHang.Location = new System.Drawing.Point(6, 205);
            this.labelKhachHang.Name = "labelKhachHang";
            this.labelKhachHang.Size = new System.Drawing.Size(309, 32);
            this.labelKhachHang.TabIndex = 6;
            this.labelKhachHang.Text = "Mã Khách Hàng : ";
            this.labelKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelShipper
            // 
            this.labelShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShipper.Location = new System.Drawing.Point(6, 269);
            this.labelShipper.Name = "labelShipper";
            this.labelShipper.Size = new System.Drawing.Size(309, 32);
            this.labelShipper.TabIndex = 8;
            this.labelShipper.Text = "Mã Shipper : ";
            this.labelShipper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(6, 333);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(309, 32);
            this.labelTongTien.TabIndex = 10;
            this.labelTongTien.Text = "Tổng Tiền : ";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNgayTao
            // 
            this.labelNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTao.Location = new System.Drawing.Point(6, 397);
            this.labelNgayTao.Name = "labelNgayTao";
            this.labelNgayTao.Size = new System.Drawing.Size(309, 32);
            this.labelNgayTao.TabIndex = 12;
            this.labelNgayTao.Text = "Ngày Tạo Hóa Đơn : ";
            this.labelNgayTao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(6, 461);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(309, 32);
            this.labelDiaChi.TabIndex = 14;
            this.labelDiaChi.Text = "Địa Chỉ Giao Hàng : ";
            this.labelDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNgayShip
            // 
            this.labelNgayShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayShip.Location = new System.Drawing.Point(6, 525);
            this.labelNgayShip.Name = "labelNgayShip";
            this.labelNgayShip.Size = new System.Drawing.Size(309, 32);
            this.labelNgayShip.TabIndex = 16;
            this.labelNgayShip.Text = "Ngày Giao Hàng : ";
            this.labelNgayShip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(321, 82);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(397, 26);
            this.textBoxID.TabIndex = 17;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(321, 146);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(397, 26);
            this.textBoxName.TabIndex = 18;
            // 
            // textBoxKhachHang
            // 
            this.textBoxKhachHang.Location = new System.Drawing.Point(321, 210);
            this.textBoxKhachHang.Name = "textBoxKhachHang";
            this.textBoxKhachHang.Size = new System.Drawing.Size(397, 26);
            this.textBoxKhachHang.TabIndex = 19;
            // 
            // textBoxShipper
            // 
            this.textBoxShipper.Location = new System.Drawing.Point(321, 274);
            this.textBoxShipper.Name = "textBoxShipper";
            this.textBoxShipper.Size = new System.Drawing.Size(397, 26);
            this.textBoxShipper.TabIndex = 20;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Enabled = false;
            this.textBoxTongTien.Location = new System.Drawing.Point(321, 338);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(397, 26);
            this.textBoxTongTien.TabIndex = 21;
            this.textBoxTongTien.Text = "0";
            // 
            // textBoxNgayTao
            // 
            this.textBoxNgayTao.Location = new System.Drawing.Point(321, 402);
            this.textBoxNgayTao.Name = "textBoxNgayTao";
            this.textBoxNgayTao.Size = new System.Drawing.Size(397, 26);
            this.textBoxNgayTao.TabIndex = 22;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(321, 466);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(397, 26);
            this.textBoxDiaChi.TabIndex = 23;
            // 
            // textBoxNgayGiao
            // 
            this.textBoxNgayGiao.Location = new System.Drawing.Point(321, 530);
            this.textBoxNgayGiao.Name = "textBoxNgayGiao";
            this.textBoxNgayGiao.Size = new System.Drawing.Size(397, 26);
            this.textBoxNgayGiao.TabIndex = 24;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(330, 595);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(159, 46);
            this.buttonSubmit.TabIndex = 25;
            this.buttonSubmit.Text = "Thêm";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.submitAddHD);
            // 
            // ThemHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNgayGiao);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxNgayTao);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.textBoxShipper);
            this.Controls.Add(this.textBoxKhachHang);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelNgayShip);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelNgayTao);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.labelShipper);
            this.Controls.Add(this.labelKhachHang);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTiTle);
            this.Name = "ThemHoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTiTle;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelKhachHang;
        private System.Windows.Forms.Label labelShipper;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label labelNgayTao;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelNgayShip;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKhachHang;
        private System.Windows.Forms.TextBox textBoxShipper;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.TextBox textBoxNgayTao;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxNgayGiao;
        private System.Windows.Forms.Button buttonSubmit;
    }
}