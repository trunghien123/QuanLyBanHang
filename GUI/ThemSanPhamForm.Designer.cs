namespace GUI
{
    partial class ThemSanPhamForm
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
            this.labelCatalog = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTenSP = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.comboBoxCatalog = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelThongTinSP = new System.Windows.Forms.Label();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTiTle
            // 
            this.labelTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiTle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTiTle.Location = new System.Drawing.Point(1, 7);
            this.labelTiTle.Name = "labelTiTle";
            this.labelTiTle.Size = new System.Drawing.Size(711, 38);
            this.labelTiTle.TabIndex = 0;
            this.labelTiTle.Text = "Thêm Sản Phẩm";
            this.labelTiTle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(42, 83);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(239, 26);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID Sản Phẩm : ";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(42, 134);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(239, 26);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tên Sản Phẩm : ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCatalog
            // 
            this.labelCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalog.Location = new System.Drawing.Point(42, 186);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(239, 26);
            this.labelCatalog.TabIndex = 3;
            this.labelCatalog.Text = "Catalog : ";
            this.labelCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(42, 237);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(239, 26);
            this.labelSoLuong.TabIndex = 4;
            this.labelSoLuong.Text = "Số Lượng : ";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGia
            // 
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(42, 288);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(239, 26);
            this.labelGia.TabIndex = 5;
            this.labelGia.Text = "Giá Sản Phẩm : ";
            this.labelGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(286, 87);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(353, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxTenSP
            // 
            this.textBoxTenSP.Location = new System.Drawing.Point(286, 138);
            this.textBoxTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenSP.Name = "textBoxTenSP";
            this.textBoxTenSP.Size = new System.Drawing.Size(353, 22);
            this.textBoxTenSP.TabIndex = 7;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(286, 241);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(353, 22);
            this.textBoxSoLuong.TabIndex = 9;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(286, 292);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(353, 22);
            this.textBoxGia.TabIndex = 10;
            // 
            // comboBoxCatalog
            // 
            this.comboBoxCatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCatalog.FormattingEnabled = true;
            this.comboBoxCatalog.Location = new System.Drawing.Point(287, 188);
            this.comboBoxCatalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCatalog.Name = "comboBoxCatalog";
            this.comboBoxCatalog.Size = new System.Drawing.Size(352, 24);
            this.comboBoxCatalog.TabIndex = 11;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(286, 446);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(141, 37);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Thêm";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelThongTinSP
            // 
            this.labelThongTinSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongTinSP.Location = new System.Drawing.Point(42, 339);
            this.labelThongTinSP.Name = "labelThongTinSP";
            this.labelThongTinSP.Size = new System.Drawing.Size(239, 26);
            this.labelThongTinSP.TabIndex = 14;
            this.labelThongTinSP.Text = "Thông Tin Sản Phẩm : ";
            this.labelThongTinSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Location = new System.Drawing.Point(286, 343);
            this.textBoxDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Size = new System.Drawing.Size(353, 80);
            this.textBoxDetail.TabIndex = 15;
            // 
            // ThemSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 526);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.labelThongTinSP);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxCatalog);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxTenSP);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelCatalog);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTiTle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemSanPhamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemSanPhamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTiTle;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCatalog;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTenSP;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.ComboBox comboBoxCatalog;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelThongTinSP;
        private System.Windows.Forms.TextBox textBoxDetail;
    }
}