using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThemSanPhamForm : Form
    {
        public MainForm formCalled;

        public ThemSanPhamForm()
        {
            InitializeComponent();
            setting_AddSPForm();
        }

        //-------setting form thêm sp----------------
        public void setting_AddSPForm()
        {
            comboBoxCatalog.Items.Clear();
            BUS_Catalog catalog = new BUS_Catalog();
            List<Catalog> catalogs = catalog.getAllCatalog();
            for (int i = 0; i < catalogs.Count; i++)
            {
                comboBoxCatalog.Items.Add(catalogs[i].ID + "(" + catalogs[i].Catalog_Name + ")");
            }
            comboBoxCatalog.SelectedIndex = 0;
        }

        //-----------nút submit-------------------
        private void submitAddSP(object sender, EventArgs e)
        {
            BUS_Product product = new BUS_Product();
            BUS_ProductDetail productDetail = new BUS_ProductDetail();

            if (!textBoxID.Text.Equals("") && !textBoxTenSP.Text.Equals("") && !textBoxSoLuong.Text.Equals("") && !textBoxGia.Text.Equals("") && !textBoxDetail.Text.Equals("") && !product.ktTonTaiId(textBoxID.Text) && textBoxSoLuong.Text.All(char.IsDigit) && textBoxGia.Text.All(char.IsDigit))
            {
                String catalog = comboBoxCatalog.GetItemText(comboBoxCatalog.SelectedItem);
                String catalogId = catalog.Split('(')[0];

                product.addSP(new Product(textBoxID.Text, textBoxTenSP.Text, catalogId, Int32.Parse(textBoxSoLuong.Text), textBoxGia.Text));
                productDetail.addSPDetail(new ProductDetail(textBoxID.Text, textBoxDetail.Text));

                formCalled.setting_DSSP("");
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
