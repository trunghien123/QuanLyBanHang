namespace GUI
{
    partial class ThemChiTietHoaDonForm
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
            this.panelAddNormalProduct = new System.Windows.Forms.Panel();
            this.buttonSubmitSP = new System.Windows.Forms.Button();
            this.comboBoxSPSP = new System.Windows.Forms.ComboBox();
            this.textBoxSoLuongSP = new System.Windows.Forms.TextBox();
            this.textBoxGiaSP = new System.Windows.Forms.TextBox();
            this.textBoxIDHDSP = new System.Windows.Forms.TextBox();
            this.labelGiaSP = new System.Windows.Forms.Label();
            this.labelSoLuongSP = new System.Windows.Forms.Label();
            this.labelSPSP = new System.Windows.Forms.Label();
            this.labelIDHDSP = new System.Windows.Forms.Label();
            this.labelTitleAddNormalProduct = new System.Windows.Forms.Label();
            this.panelAddProductCombo = new System.Windows.Forms.Panel();
            this.buttonSubmitCombo = new System.Windows.Forms.Button();
            this.comboBoxCombo = new System.Windows.Forms.ComboBox();
            this.textBoxGiaCombo = new System.Windows.Forms.TextBox();
            this.textBoxSoLuongCombo = new System.Windows.Forms.TextBox();
            this.textBoxIDHDCombo = new System.Windows.Forms.TextBox();
            this.labelGiaCombo = new System.Windows.Forms.Label();
            this.labelSoLuongCombo = new System.Windows.Forms.Label();
            this.labelSPCombo = new System.Windows.Forms.Label();
            this.labelIDHDCombo = new System.Windows.Forms.Label();
            this.labelAddProductCombo = new System.Windows.Forms.Label();
            this.panelAddNormalProduct.SuspendLayout();
            this.panelAddProductCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTiTle
            // 
            this.labelTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiTle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTiTle.Location = new System.Drawing.Point(12, 9);
            this.labelTiTle.Name = "labelTiTle";
            this.labelTiTle.Size = new System.Drawing.Size(1100, 47);
            this.labelTiTle.TabIndex = 2;
            this.labelTiTle.Text = "Thêm Chi Tiết Hóa Đơn";
            this.labelTiTle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddNormalProduct
            // 
            this.panelAddNormalProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddNormalProduct.Controls.Add(this.buttonSubmitSP);
            this.panelAddNormalProduct.Controls.Add(this.comboBoxSPSP);
            this.panelAddNormalProduct.Controls.Add(this.textBoxSoLuongSP);
            this.panelAddNormalProduct.Controls.Add(this.textBoxGiaSP);
            this.panelAddNormalProduct.Controls.Add(this.textBoxIDHDSP);
            this.panelAddNormalProduct.Controls.Add(this.labelGiaSP);
            this.panelAddNormalProduct.Controls.Add(this.labelSoLuongSP);
            this.panelAddNormalProduct.Controls.Add(this.labelSPSP);
            this.panelAddNormalProduct.Controls.Add(this.labelIDHDSP);
            this.panelAddNormalProduct.Controls.Add(this.labelTitleAddNormalProduct);
            this.panelAddNormalProduct.Location = new System.Drawing.Point(12, 59);
            this.panelAddNormalProduct.Name = "panelAddNormalProduct";
            this.panelAddNormalProduct.Size = new System.Drawing.Size(553, 522);
            this.panelAddNormalProduct.TabIndex = 3;
            // 
            // buttonSubmitSP
            // 
            this.buttonSubmitSP.Location = new System.Drawing.Point(211, 393);
            this.buttonSubmitSP.Name = "buttonSubmitSP";
            this.buttonSubmitSP.Size = new System.Drawing.Size(159, 46);
            this.buttonSubmitSP.TabIndex = 26;
            this.buttonSubmitSP.Text = "Thêm";
            this.buttonSubmitSP.UseVisualStyleBackColor = true;
            this.buttonSubmitSP.Click += new System.EventHandler(this.addChiTietHDSP);
            // 
            // comboBoxSPSP
            // 
            this.comboBoxSPSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSPSP.FormattingEnabled = true;
            this.comboBoxSPSP.Location = new System.Drawing.Point(247, 160);
            this.comboBoxSPSP.Name = "comboBoxSPSP";
            this.comboBoxSPSP.Size = new System.Drawing.Size(241, 28);
            this.comboBoxSPSP.TabIndex = 21;
            this.comboBoxSPSP.SelectedIndexChanged += new System.EventHandler(this.comboBoxSPChange);
            // 
            // textBoxSoLuongSP
            // 
            this.textBoxSoLuongSP.Location = new System.Drawing.Point(246, 227);
            this.textBoxSoLuongSP.Name = "textBoxSoLuongSP";
            this.textBoxSoLuongSP.Size = new System.Drawing.Size(242, 26);
            this.textBoxSoLuongSP.TabIndex = 20;
            // 
            // textBoxGiaSP
            // 
            this.textBoxGiaSP.Enabled = false;
            this.textBoxGiaSP.Location = new System.Drawing.Point(246, 290);
            this.textBoxGiaSP.Name = "textBoxGiaSP";
            this.textBoxGiaSP.Size = new System.Drawing.Size(242, 26);
            this.textBoxGiaSP.TabIndex = 19;
            this.textBoxGiaSP.Text = "0";
            // 
            // textBoxIDHDSP
            // 
            this.textBoxIDHDSP.Location = new System.Drawing.Point(246, 98);
            this.textBoxIDHDSP.Name = "textBoxIDHDSP";
            this.textBoxIDHDSP.Size = new System.Drawing.Size(242, 26);
            this.textBoxIDHDSP.TabIndex = 18;
            // 
            // labelGiaSP
            // 
            this.labelGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaSP.Location = new System.Drawing.Point(4, 285);
            this.labelGiaSP.Name = "labelGiaSP";
            this.labelGiaSP.Size = new System.Drawing.Size(236, 32);
            this.labelGiaSP.TabIndex = 10;
            this.labelGiaSP.Text = "Giá : ";
            this.labelGiaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSoLuongSP
            // 
            this.labelSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongSP.Location = new System.Drawing.Point(4, 221);
            this.labelSoLuongSP.Name = "labelSoLuongSP";
            this.labelSoLuongSP.Size = new System.Drawing.Size(236, 32);
            this.labelSoLuongSP.TabIndex = 8;
            this.labelSoLuongSP.Text = "Số Lượng : ";
            this.labelSoLuongSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSPSP
            // 
            this.labelSPSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSPSP.Location = new System.Drawing.Point(4, 157);
            this.labelSPSP.Name = "labelSPSP";
            this.labelSPSP.Size = new System.Drawing.Size(236, 32);
            this.labelSPSP.TabIndex = 6;
            this.labelSPSP.Text = "Sản Phẩm : ";
            this.labelSPSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIDHDSP
            // 
            this.labelIDHDSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDHDSP.Location = new System.Drawing.Point(4, 93);
            this.labelIDHDSP.Name = "labelIDHDSP";
            this.labelIDHDSP.Size = new System.Drawing.Size(236, 32);
            this.labelIDHDSP.TabIndex = 4;
            this.labelIDHDSP.Text = "ID Hóa Đơn : ";
            this.labelIDHDSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleAddNormalProduct
            // 
            this.labelTitleAddNormalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAddNormalProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitleAddNormalProduct.Location = new System.Drawing.Point(3, 9);
            this.labelTitleAddNormalProduct.Name = "labelTitleAddNormalProduct";
            this.labelTitleAddNormalProduct.Size = new System.Drawing.Size(547, 47);
            this.labelTitleAddNormalProduct.TabIndex = 3;
            this.labelTitleAddNormalProduct.Text = "Thêm Theo Sản Phẩm";
            this.labelTitleAddNormalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddProductCombo
            // 
            this.panelAddProductCombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddProductCombo.Controls.Add(this.buttonSubmitCombo);
            this.panelAddProductCombo.Controls.Add(this.comboBoxCombo);
            this.panelAddProductCombo.Controls.Add(this.textBoxGiaCombo);
            this.panelAddProductCombo.Controls.Add(this.textBoxSoLuongCombo);
            this.panelAddProductCombo.Controls.Add(this.textBoxIDHDCombo);
            this.panelAddProductCombo.Controls.Add(this.labelGiaCombo);
            this.panelAddProductCombo.Controls.Add(this.labelSoLuongCombo);
            this.panelAddProductCombo.Controls.Add(this.labelSPCombo);
            this.panelAddProductCombo.Controls.Add(this.labelIDHDCombo);
            this.panelAddProductCombo.Controls.Add(this.labelAddProductCombo);
            this.panelAddProductCombo.Location = new System.Drawing.Point(571, 59);
            this.panelAddProductCombo.Name = "panelAddProductCombo";
            this.panelAddProductCombo.Size = new System.Drawing.Size(541, 522);
            this.panelAddProductCombo.TabIndex = 4;
            // 
            // buttonSubmitCombo
            // 
            this.buttonSubmitCombo.Location = new System.Drawing.Point(202, 393);
            this.buttonSubmitCombo.Name = "buttonSubmitCombo";
            this.buttonSubmitCombo.Size = new System.Drawing.Size(159, 46);
            this.buttonSubmitCombo.TabIndex = 27;
            this.buttonSubmitCombo.Text = "Thêm";
            this.buttonSubmitCombo.UseVisualStyleBackColor = true;
            this.buttonSubmitCombo.Click += new System.EventHandler(this.addChiTietHDCombo);
            // 
            // comboBoxCombo
            // 
            this.comboBoxCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombo.FormattingEnabled = true;
            this.comboBoxCombo.Location = new System.Drawing.Point(247, 162);
            this.comboBoxCombo.Name = "comboBoxCombo";
            this.comboBoxCombo.Size = new System.Drawing.Size(241, 28);
            this.comboBoxCombo.TabIndex = 22;
            this.comboBoxCombo.SelectedIndexChanged += new System.EventHandler(this.comboBoxComboChange);
            // 
            // textBoxGiaCombo
            // 
            this.textBoxGiaCombo.Enabled = false;
            this.textBoxGiaCombo.Location = new System.Drawing.Point(246, 290);
            this.textBoxGiaCombo.Name = "textBoxGiaCombo";
            this.textBoxGiaCombo.Size = new System.Drawing.Size(242, 26);
            this.textBoxGiaCombo.TabIndex = 21;
            this.textBoxGiaCombo.Text = "0";
            // 
            // textBoxSoLuongCombo
            // 
            this.textBoxSoLuongCombo.Location = new System.Drawing.Point(246, 226);
            this.textBoxSoLuongCombo.Name = "textBoxSoLuongCombo";
            this.textBoxSoLuongCombo.Size = new System.Drawing.Size(242, 26);
            this.textBoxSoLuongCombo.TabIndex = 20;
            // 
            // textBoxIDHDCombo
            // 
            this.textBoxIDHDCombo.Location = new System.Drawing.Point(246, 98);
            this.textBoxIDHDCombo.Name = "textBoxIDHDCombo";
            this.textBoxIDHDCombo.Size = new System.Drawing.Size(242, 26);
            this.textBoxIDHDCombo.TabIndex = 19;
            // 
            // labelGiaCombo
            // 
            this.labelGiaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaCombo.Location = new System.Drawing.Point(4, 285);
            this.labelGiaCombo.Name = "labelGiaCombo";
            this.labelGiaCombo.Size = new System.Drawing.Size(236, 32);
            this.labelGiaCombo.TabIndex = 8;
            this.labelGiaCombo.Text = "Giá : ";
            this.labelGiaCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSoLuongCombo
            // 
            this.labelSoLuongCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongCombo.Location = new System.Drawing.Point(4, 221);
            this.labelSoLuongCombo.Name = "labelSoLuongCombo";
            this.labelSoLuongCombo.Size = new System.Drawing.Size(236, 32);
            this.labelSoLuongCombo.TabIndex = 7;
            this.labelSoLuongCombo.Text = "Số Lượng : ";
            this.labelSoLuongCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSPCombo
            // 
            this.labelSPCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSPCombo.Location = new System.Drawing.Point(4, 155);
            this.labelSPCombo.Name = "labelSPCombo";
            this.labelSPCombo.Size = new System.Drawing.Size(236, 32);
            this.labelSPCombo.TabIndex = 6;
            this.labelSPCombo.Text = "Combo : ";
            this.labelSPCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIDHDCombo
            // 
            this.labelIDHDCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDHDCombo.Location = new System.Drawing.Point(4, 93);
            this.labelIDHDCombo.Name = "labelIDHDCombo";
            this.labelIDHDCombo.Size = new System.Drawing.Size(236, 32);
            this.labelIDHDCombo.TabIndex = 5;
            this.labelIDHDCombo.Text = "ID Hóa Đơn : ";
            this.labelIDHDCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddProductCombo
            // 
            this.labelAddProductCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProductCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAddProductCombo.Location = new System.Drawing.Point(3, 9);
            this.labelAddProductCombo.Name = "labelAddProductCombo";
            this.labelAddProductCombo.Size = new System.Drawing.Size(532, 47);
            this.labelAddProductCombo.TabIndex = 4;
            this.labelAddProductCombo.Text = "Thêm Theo Combo";
            this.labelAddProductCombo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemChiTietHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 593);
            this.Controls.Add(this.panelAddProductCombo);
            this.Controls.Add(this.panelAddNormalProduct);
            this.Controls.Add(this.labelTiTle);
            this.Name = "ThemChiTietHoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemChiTietHoaDonForm";
            this.panelAddNormalProduct.ResumeLayout(false);
            this.panelAddNormalProduct.PerformLayout();
            this.panelAddProductCombo.ResumeLayout(false);
            this.panelAddProductCombo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTiTle;
        private System.Windows.Forms.Panel panelAddNormalProduct;
        private System.Windows.Forms.Label labelTitleAddNormalProduct;
        private System.Windows.Forms.Panel panelAddProductCombo;
        private System.Windows.Forms.Label labelAddProductCombo;
        private System.Windows.Forms.Label labelGiaSP;
        private System.Windows.Forms.Label labelSoLuongSP;
        private System.Windows.Forms.Label labelSPSP;
        private System.Windows.Forms.Label labelIDHDSP;
        private System.Windows.Forms.ComboBox comboBoxSPSP;
        private System.Windows.Forms.TextBox textBoxSoLuongSP;
        private System.Windows.Forms.TextBox textBoxGiaSP;
        private System.Windows.Forms.TextBox textBoxIDHDSP;
        private System.Windows.Forms.Button buttonSubmitSP;
        private System.Windows.Forms.Button buttonSubmitCombo;
        private System.Windows.Forms.ComboBox comboBoxCombo;
        private System.Windows.Forms.TextBox textBoxGiaCombo;
        private System.Windows.Forms.TextBox textBoxSoLuongCombo;
        private System.Windows.Forms.TextBox textBoxIDHDCombo;
        private System.Windows.Forms.Label labelGiaCombo;
        private System.Windows.Forms.Label labelSoLuongCombo;
        private System.Windows.Forms.Label labelSPCombo;
        private System.Windows.Forms.Label labelIDHDCombo;
    }
}