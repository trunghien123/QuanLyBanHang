namespace GUI
{
    partial class ThemComboForm
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
            this.textBoxPriceCB = new System.Windows.Forms.TextBox();
            this.labelThongTinSP = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxTenCB = new System.Windows.Forms.TextBox();
            this.textBoxCBID = new System.Windows.Forms.TextBox();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelCatalog = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.listBoxAllProduct = new System.Windows.Forms.ListBox();
            this.listBoxCurrentProduct = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonSubstractProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTiTle
            // 
            this.labelTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiTle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTiTle.Location = new System.Drawing.Point(26, 9);
            this.labelTiTle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTiTle.Name = "labelTiTle";
            this.labelTiTle.Size = new System.Drawing.Size(533, 31);
            this.labelTiTle.TabIndex = 1;
            this.labelTiTle.Text = "Thêm Combo";
            this.labelTiTle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPriceCB
            // 
            this.textBoxPriceCB.Location = new System.Drawing.Point(220, 309);
            this.textBoxPriceCB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPriceCB.Multiline = true;
            this.textBoxPriceCB.Name = "textBoxPriceCB";
            this.textBoxPriceCB.Size = new System.Drawing.Size(266, 26);
            this.textBoxPriceCB.TabIndex = 28;
            // 
            // labelThongTinSP
            // 
            this.labelThongTinSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongTinSP.Location = new System.Drawing.Point(38, 305);
            this.labelThongTinSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThongTinSP.Name = "labelThongTinSP";
            this.labelThongTinSP.Size = new System.Drawing.Size(179, 21);
            this.labelThongTinSP.TabIndex = 27;
            this.labelThongTinSP.Text = "Giá Combo : ";
            this.labelThongTinSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(220, 392);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(106, 30);
            this.buttonSubmit.TabIndex = 26;
            this.buttonSubmit.Text = "Thêm";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(220, 267);
            this.textBoxEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(266, 20);
            this.textBoxEndDate.TabIndex = 24;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(220, 226);
            this.textBoxStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(266, 20);
            this.textBoxStartDate.TabIndex = 23;
            // 
            // textBoxTenCB
            // 
            this.textBoxTenCB.Location = new System.Drawing.Point(220, 98);
            this.textBoxTenCB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenCB.Name = "textBoxTenCB";
            this.textBoxTenCB.Size = new System.Drawing.Size(266, 20);
            this.textBoxTenCB.TabIndex = 22;
            // 
            // textBoxCBID
            // 
            this.textBoxCBID.Location = new System.Drawing.Point(220, 57);
            this.textBoxCBID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBID.Name = "textBoxCBID";
            this.textBoxCBID.Size = new System.Drawing.Size(266, 20);
            this.textBoxCBID.TabIndex = 21;
            // 
            // labelGia
            // 
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(38, 264);
            this.labelGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(179, 21);
            this.labelGia.TabIndex = 20;
            this.labelGia.Text = "Ngày kết thúc: ";
            this.labelGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(38, 223);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(179, 21);
            this.labelSoLuong.TabIndex = 19;
            this.labelSoLuong.Text = "Ngày bắt đầu : ";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCatalog
            // 
            this.labelCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalog.Location = new System.Drawing.Point(38, 137);
            this.labelCatalog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(179, 21);
            this.labelCatalog.TabIndex = 18;
            this.labelCatalog.Text = "Danh sách sản phẩm :";
            this.labelCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(38, 95);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(179, 21);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Tên Combo : ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(38, 53);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(179, 21);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID Combo : ";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Phần trăm giảm : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(220, 349);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDiscount.Multiline = true;
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(266, 26);
            this.textBoxDiscount.TabIndex = 28;
            // 
            // listBoxAllProduct
            // 
            this.listBoxAllProduct.FormattingEnabled = true;
            this.listBoxAllProduct.Location = new System.Drawing.Point(220, 126);
            this.listBoxAllProduct.Name = "listBoxAllProduct";
            this.listBoxAllProduct.Size = new System.Drawing.Size(117, 95);
            this.listBoxAllProduct.TabIndex = 29;
            // 
            // listBoxCurrentProduct
            // 
            this.listBoxCurrentProduct.FormattingEnabled = true;
            this.listBoxCurrentProduct.Location = new System.Drawing.Point(424, 126);
            this.listBoxCurrentProduct.Name = "listBoxCurrentProduct";
            this.listBoxCurrentProduct.Size = new System.Drawing.Size(120, 95);
            this.listBoxCurrentProduct.TabIndex = 30;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(343, 137);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 31;
            this.buttonAddProduct.Text = "Thêm";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonSubstractProduct
            // 
            this.buttonSubstractProduct.Location = new System.Drawing.Point(343, 179);
            this.buttonSubstractProduct.Name = "buttonSubstractProduct";
            this.buttonSubstractProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonSubstractProduct.TabIndex = 31;
            this.buttonSubstractProduct.Text = "Xóa";
            this.buttonSubstractProduct.UseVisualStyleBackColor = true;
            // 
            // ThemComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 440);
            this.Controls.Add(this.buttonSubstractProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.listBoxCurrentProduct);
            this.Controls.Add(this.listBoxAllProduct);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxPriceCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelThongTinSP);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.textBoxTenCB);
            this.Controls.Add(this.textBoxCBID);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelCatalog);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTiTle);
            this.Name = "ThemComboForm";
            this.Text = "ThemComboForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTiTle;
        private System.Windows.Forms.TextBox textBoxPriceCB;
        private System.Windows.Forms.Label labelThongTinSP;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxTenCB;
        private System.Windows.Forms.TextBox textBoxCBID;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelCatalog;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.ListBox listBoxAllProduct;
        private System.Windows.Forms.ListBox listBoxCurrentProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonSubstractProduct;
    }
}