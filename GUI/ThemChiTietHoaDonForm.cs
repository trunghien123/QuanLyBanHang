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
    public partial class ThemChiTietHoaDonForm : Form
    {
        public MainForm formCalled;

        public ThemChiTietHoaDonForm()
        {
            InitializeComponent();

            settingAddChiTietHD();
        }

        //setting thêm thông tin chi tiết hóa đơn
        public void settingAddChiTietHD()
        {
            //set thông tin cho combobox sản phẩm
            comboBoxSPSP.Items.Clear();

            BUS_Product product = new BUS_Product();
            List<Product> products = product.getProduct("");
            for (int i = 0; i < products.Count; i++)
            {
                comboBoxSPSP.Items.Add(products[i].ID + "(" + products[i].Product_Name + ")");
            }

            //set thông tin cho combobox combo
            comboBoxCombo.Items.Clear();

            BUS_Combo combo = new BUS_Combo();
            List<Combo> combos = combo.getAllCombo();
            for (int i = 0; i < combos.Count; i++)
            {
                comboBoxCombo.Items.Add(combos[i].ID + "(" + combos[i].Combo_Name + ")");
            }
        }

        //set giá khi combobox sản phẩm thay đổi
        private void comboBoxSPChange(object sender, EventArgs e)
        {
            BUS_Product product = new BUS_Product();
            List<Product> productDTO = new List<Product>();

            productDTO  = product.getProduct(comboBoxSPSP.SelectedItem.ToString().Split('(')[0]);
            textBoxGiaSP.Text = productDTO[0].Price;

        }

        //Nút thêm chi tiết hóa đơn theo sản phẩm
        private void addChiTietHDSP(object sender, EventArgs e)
        {
            BUS_Invoice invoice = new BUS_Invoice();
            BUS_Product product = new BUS_Product();

            String sp = comboBoxSPSP.GetItemText(comboBoxSPSP.SelectedItem);
            
            if(!textBoxIDHDSP.Text.Equals("") && !sp.Equals("") && !textBoxSoLuongSP.Text.Equals("") && textBoxSoLuongSP.Text.All(char.IsDigit) && invoice.ktTonTaiHoaDonId(textBoxIDHDSP.Text))
            {
                String spId = sp.Split('(')[0];
                
                if(product.ktSoLuongSPTheoId(spId, int.Parse(textBoxSoLuongSP.Text)))
                {
                    BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();

                    int soLuongFinal = product.getSoLuongSP(spId) - int.Parse(textBoxSoLuongSP.Text);

                    int tongTien = invoice.getTongTien(textBoxIDHDSP.Text);
                    int tongTienFinal = tongTien + (int.Parse(textBoxSoLuongSP.Text) * int.Parse(textBoxGiaSP.Text));

                    invoiceDetail.addChiTietHD(new InvoiceDetail(0, textBoxIDHDSP.Text, spId, "", int.Parse(textBoxSoLuongSP.Text), textBoxGiaSP.Text));
                    product.updateSoLuongSP(spId, soLuongFinal);
                    invoice.updateTongTien(textBoxIDHDSP.Text, Convert.ToString(tongTienFinal));

                    formCalled.setting_DSHD("");
                    formCalled.setting_DSSP("");
                }
            }
        }

        //Nút thêm chi tiết hóa đơn theo Combo
        private void addChiTietHDCombo(object sender, EventArgs e)
        {
            BUS_Invoice invoice = new BUS_Invoice();
            BUS_Product product = new BUS_Product();
            BUS_Combo combo = new BUS_Combo();

            String cb = comboBoxCombo.GetItemText(comboBoxCombo.SelectedItem);

            if (!textBoxIDHDCombo.Text.Equals("") && !cb.Equals("") && !textBoxSoLuongCombo.Text.Equals("") && textBoxSoLuongCombo.Text.All(char.IsDigit) && invoice.ktTonTaiHoaDonId(textBoxIDHDCombo.Text) && int.Parse(textBoxSoLuongCombo.Text) != 0)
            {
                bool canAdd = true;
                
                String cbId = cb.Split('(')[0];
                String productList = combo.getProductList(cbId);
                String[] productIds = productList.Split(';');

                for(int i = 0; i < productIds.Length; i++)
                {
                    if(product.getSoLuongSP(productIds[i]) <= int.Parse(textBoxSoLuongCombo.Text) && product.getSoLuongSP(productIds[i]) == 0)
                    {
                        canAdd = false;
                    }
                }

                if (canAdd)
                {
                    BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();

                    for(int i = 0; i < productIds.Length; i++)
                    {
                        int soLuongFinal = product.getSoLuongSP(productIds[i]) - int.Parse(textBoxSoLuongCombo.Text);
                        product.updateSoLuongSP(productIds[i], soLuongFinal);
                    }

                    int tongTien = invoice.getTongTien(textBoxIDHDCombo.Text);
                    int tongTienFinal = tongTien + (int.Parse(textBoxSoLuongCombo.Text) * int.Parse(textBoxGiaCombo.Text));

                    invoiceDetail.addChiTietHD(new InvoiceDetail(0, textBoxIDHDCombo.Text, "", cbId, int.Parse(textBoxSoLuongCombo.Text), textBoxGiaCombo.Text));
                    
                    invoice.updateTongTien(textBoxIDHDCombo.Text, Convert.ToString(tongTienFinal));

                    formCalled.setting_DSHD("");
                    formCalled.setting_DSSP("");
                }
            }
        }

        //set giá khi combobox Combo thay đổi
        private void comboBoxComboChange(object sender, EventArgs e)
        {
            BUS_Combo combo = new BUS_Combo();

            String cb = comboBoxCombo.GetItemText(comboBoxCombo.SelectedItem);
            String cbId = cb.Split('(')[0];

            String giaCombo = combo.getPriceWithId(cbId);
            textBoxGiaCombo.Text = giaCombo;
        }
    }
}
