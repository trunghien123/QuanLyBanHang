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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            setting_DSSP("");
            setting_DSHD("");
            setting_DSCB();
        }

//---------------------------------------------------------------------SẢN PHẨM---------------------------------------------------------------------------
        //danh sách sản phẩm
        public void setting_DSSP(String search)
        {
            listViewDSSP.Items.Clear();// xóa hết item trong listview

            BUS_Product product = new BUS_Product();
            List<Product> productList = product.getProduct(search);
            
            for(int i = 0; i < productList.Count; i++)
            {
                string[] arr = new string[5];
                arr[0] = productList[i].ID;
                arr[1] = productList[i].Product_Name;
                arr[2] = productList[i].Catalog_ID;
                arr[3] = Convert.ToString(productList[i].Amount);
                arr[4] = productList[i].Price;

                listViewDSSP.Items.Add(new ListViewItem(arr));
            }
        }

        //setting thong tin sp
        private void thongTinSP(object sender, MouseEventArgs e)
        {
            //set thông tin cho comboboxcatalog
            comboBoxCatalog.Items.Clear();

            BUS_Catalog catalog = new BUS_Catalog();
            List<Catalog> catalogs = catalog.getAllCatalog();
            for (int i = 0; i < catalogs.Count; i++)
            {
                comboBoxCatalog.Items.Add(catalogs[i].ID + "(" + catalogs[i].Catalog_Name + ")");
            }

            //setting thông tin sản phẩm
            BUS_ProductDetail productDetailt = new BUS_ProductDetail();
            ProductDetail productDetailtDTO = productDetailt.getProductDetail(listViewDSSP.SelectedItems[0].SubItems[0].Text);

            textBoxID.Text = listViewDSSP.SelectedItems[0].SubItems[0].Text;
            textBoxTenSP.Text = listViewDSSP.SelectedItems[0].SubItems[1].Text;
            comboBoxCatalog.SelectedIndex = comboBoxCatalog.Items.IndexOf(listViewDSSP.SelectedItems[0].SubItems[2].Text);
            textBoxSoLuong.Text = listViewDSSP.SelectedItems[0].SubItems[3].Text;
            textBoxGia.Text = listViewDSSP.SelectedItems[0].SubItems[4].Text;
            textBoxDetail.Text = productDetailtDTO.Product_Detail;
        }

        //----------------------------------------------các button----------------------------------------------------------------------------
        //search button
        private void search(object sender, EventArgs e)
        {
            setting_DSSP(textBoxSearchSP.Text);// nạp lại item
        }

        //sua button
        private void suaSP(object sender, EventArgs e)
        {
            if(!textBoxID.Text.Equals("") && !textBoxTenSP.Text.Equals("") && !textBoxSoLuong.Text.Equals("") 
                && !textBoxGia.Text.Equals("") && !textBoxDetail.Text.Equals("") && textBoxSoLuong.Text.All(char.IsDigit)
                && textBoxGia.Text.All(char.IsDigit))
            {
                BUS_Product product = new BUS_Product();
                BUS_ProductDetail productDetail = new BUS_ProductDetail();

                String catalog = comboBoxCatalog.GetItemText(comboBoxCatalog.SelectedItem);
                String catalogId = catalog.Split('(')[0];
                Product productDTO = new Product(textBoxID.Text, textBoxTenSP.Text, catalogId, Int32.Parse(textBoxSoLuong.Text), textBoxGia.Text);
                ProductDetail productDetailDTO = new ProductDetail(textBoxID.Text, textBoxDetail.Text);

                product.updateSP(productDTO);
                productDetail.updateSPDetail(productDetailDTO);

                setting_DSSP("");//set lại DSSP
            }
        }

        //xóa button
        private void xoaSP(object sender, EventArgs e)
        {
            if(!textBoxID.Text.Equals(""))
            {
                BUS_Product product = new BUS_Product();
                BUS_ProductDetail productDetail = new BUS_ProductDetail();
                BUS_Combo combo = new BUS_Combo();

                if(!combo.ktSPTrongCombo(textBoxID.Text))
                {
                    product.deleteSP(textBoxID.Text);
                    productDetail.deleteSPDetail(textBoxID.Text);
                }

                setting_DSSP("");//set lại DSSP
            }
        }

        //Nút mở form đăng nhập
        private void openAddProductForm(object sender, EventArgs e)
        {
            ThemSanPhamForm themSanPhamForm = new ThemSanPhamForm();
            themSanPhamForm.formCalled = this;
            themSanPhamForm.Show();
        }

        //------------------------------------------------------------------------Hết Button phần sản phẩm--------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------Hết phần sản phẩm--------------------------------------------------------------------------
        //----------------------------------------------------------------------COMBO--------------------------------------------------------------------------------------------------//
        public void setting_DSCB()
        {
            listViewCombo.Items.Clear();// xóa hết item trong listview

            BUS_Combo combo = new BUS_Combo();
            List<Combo> comboList = combo.getAllCombo();

            for (int i = 0; i < comboList.Count; i++)
            {
                string[] arr = new string[7];
                arr[0] = comboList[i].ID;
                arr[1] = comboList[i].Combo_Name;
                //arr[2] = comboList[i].Product_List;
                String cb = combo.getProductList(comboList[i].ID);
                arr[2] = cb;
                arr[3] = comboList[i].StartDate;
                arr[4] = comboList[i].EndDate;
                arr[5] = comboList[i].ToTalMoney;
                arr[6] = comboList[i].Discount;

                listViewCombo.Items.Add(new ListViewItem(arr));
            }
        }

        //setting thông tin combo
        private void thongtinCombo(object sender, MouseEventArgs e)
        {
            listBoxListCurrent.Items.Clear();
            listBoxListAll.Items.Clear();

            textBoxCBID.Text = listViewCombo.SelectedItems[0].SubItems[0].Text;
            textBoxCBName.Text = listViewCombo.SelectedItems[0].SubItems[1].Text;
            textBoxCBstart.Text = listViewCombo.SelectedItems[0].SubItems[3].Text;
            textBoxCBend.Text = listViewCombo.SelectedItems[0].SubItems[4].Text;
            textBoxCBPrice.Text = listViewCombo.SelectedItems[0].SubItems[5].Text;
            discountCB.Text = listViewCombo.SelectedItems[0].SubItems[6].Text;
            String[] listProduct = listViewCombo.SelectedItems[0].SubItems[2].Text.Split(';');
            for(int i = 0; i < listProduct.Length-1; i++)
            {
                listBoxListCurrent.Items.Add(listProduct[i]);
            }
            
            BUS_Product product = new BUS_Product();
            String[] listProductName = product.getAllProductName().Split(';');
            for (int i = 0; i < listProductName.Length; i++)
            {
                listBoxListAll.Items.Add(listProductName[i]);
            }
        }

        private void AddProductList(object sender, EventArgs e)
        {
            if (listBoxListCurrent.Items.Contains(listBoxListAll.SelectedItem))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong Combo");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm vào Combo thành công");
                listBoxListCurrent.Items.Add(listBoxListAll.SelectedItem);
            }
        }
        private void substractProductList(object sender, EventArgs e)
        {
            listBoxListCurrent.Items.RemoveAt(listBoxListCurrent.SelectedIndex);
        }


        private void suaCombo(object sender, EventArgs e)
        {
            BUS_Product product = new BUS_Product();
            String productList = null;
            for(int i = 0; i< listBoxListCurrent.Items.Count; i++)
            {
                productList += product.getProductIdWithName( listBoxListCurrent.Items[i].ToString()) + ';';
            }
            if(!textBoxCBID.Text.Equals("") && !textBoxCBName.Text.Equals("") && !textBoxCBstart.Text.Equals("") && !textBoxCBend.Text.Equals("") && !textBoxCBPrice.Text.Equals("") && !discountCB.Text.Equals(""))
            {
                 BUS_Combo combo = new BUS_Combo();
                 double discountMoneyInt = Int32.Parse(textBoxCBPrice.Text) - (Int32.Parse(textBoxCBPrice.Text) * Int32.Parse(discountCB.Text)) / 100;
                 string discountMoney = discountMoneyInt.ToString();
                 Combo comboDTO = new Combo(textBoxCBID.Text, textBoxCBName.Text,productList, textBoxCBstart.Text, textBoxCBend.Text, textBoxCBPrice.Text, discountCB.Text, discountMoney);
                 combo.updateCombo(comboDTO);

                 setting_DSCB();
            }
        }

        private void xoaCombo(object sender, EventArgs e)
        {
            if (!textBoxCBID.Text.Equals(""))
            {
                BUS_Combo combo = new BUS_Combo();
                combo.deleteCombo(textBoxCBID.Text);

                setting_DSCB();
            }
        }



        //-----------------------------------------------------------------------HÓA ĐƠN-------------------------------------------------------------------------------
        //danh sách hóa đơn
        public void setting_DSHD(String search)
        {
            listViewDSHD.Items.Clear();// xóa hết item trong listview

            BUS_Invoice invoice = new BUS_Invoice();
            List<Invoice> invoiceList = invoice.getInvoice(search);

            for (int i = 0; i < invoiceList.Count; i++)
            {
                string[] arr = new string[8];
                arr[0] = invoiceList[i].ID;
                arr[1] = invoiceList[i].Invoice_Name;
                arr[2] = invoiceList[i].Customer_ID;
                arr[3] = invoiceList[i].Shipper_ID;
                arr[4] = invoiceList[i].TotalMoney;
                arr[5] = invoiceList[i].CreatedDate;
                arr[6] = invoiceList[i].CustomerAddress;
                arr[7] = invoiceList[i].ShipDate;

                listViewDSHD.Items.Add(new ListViewItem(arr));
            }
        }

        //setting thông tin hóa đơn
        private void thongTinHD(object sender, MouseEventArgs e)
        {
            textBoxHDID.Text = listViewDSHD.SelectedItems[0].SubItems[0].Text;
            textBoxTenHD.Text = listViewDSHD.SelectedItems[0].SubItems[1].Text;
            textBoxKhachHangHD.Text = listViewDSHD.SelectedItems[0].SubItems[2].Text;
            textBoxShipperHD.Text = listViewDSHD.SelectedItems[0].SubItems[3].Text;
            textBoxTongTienHD.Text = listViewDSHD.SelectedItems[0].SubItems[4].Text;
            textBoxNgayTaoHD.Text = listViewDSHD.SelectedItems[0].SubItems[5].Text;
            textBoxDiaChiHD.Text = listViewDSHD.SelectedItems[0].SubItems[6].Text;
            textBoxNgayGiaoHD.Text = listViewDSHD.SelectedItems[0].SubItems[7].Text;
        }

        //------------------------------------------Các button------------------------------------------------
        //search HD
        private void searchHoaDon(object sender, EventArgs e)
        {
            setting_DSHD(textBoxSearchHD.Text);
        }

        //Nút mở form thêm hóa đơn
        private void openAddInvoiceForm(object sender, EventArgs e)
        {
            ThemHoaDonForm themHoaDonForm = new ThemHoaDonForm();
            themHoaDonForm.formCalled = this;
            themHoaDonForm.Show();
        }

        //nút sửa thông tin hóa đơn
        private void suaThongTinHoaDon(object sender, EventArgs e)
        {
            BUS_Invoice invoice = new BUS_Invoice();
            BUS_Customer customer = new BUS_Customer();
            BUS_Employee employee = new BUS_Employee();

            if (!textBoxHDID.Text.Equals("") && !textBoxTenHD.Text.Equals("") && !textBoxKhachHangHD.Text.Equals("") && !textBoxShipperHD.Text.Equals("") && !textBoxTongTienHD.Text.Equals("") && !textBoxNgayTaoHD.Text.Equals("") && !textBoxDiaChiHD.Text.Equals("") && !textBoxNgayGiaoHD.Text.Equals("") && customer.ktTonTaiKhachHangTheoId(textBoxKhachHangHD.Text) && employee.ktTonTaiShipperTheoId(textBoxShipperHD.Text))
            {
                invoice.updateInvoice(new Invoice(textBoxHDID.Text, textBoxTenHD.Text, textBoxKhachHangHD.Text, textBoxShipperHD.Text, textBoxTongTienHD.Text, textBoxNgayTaoHD.Text, textBoxDiaChiHD.Text, textBoxNgayGiaoHD.Text));

                setting_DSHD("");
            }
        }

        //nút xóa hóa đơn
        private void xoaThongTinHoaDon(object sender, EventArgs e)
        {
            if(!textBoxHDID.Text.Equals(""))
            {
                BUS_Invoice invoice = new BUS_Invoice();
                BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();

                invoiceDetail.deleteChiTietHDTheoHDId(textBoxHDID.Text);
                invoice.deleteHoaDonTheoId(textBoxHDID.Text);

                setting_DSHD("");
            }
        }

        //-----------------------------------------------Hết button hóa đơn-----------------------------------------------------------------------

//-------------------------------------------------------------Hết phần hóa đơn---------------------------------------------------------------------------



//---------------------------------------------------------------------CHI TIẾT HÓA ĐƠN------------------------------------------------------------
        //danh sách chi tiết hóa đơn
        public void setting_DSChiTietHD(String search)
        {
            listViewChiTietHD.Items.Clear();// xóa hết item trong listview

            BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();
            List<InvoiceDetail> invoiceDetailList = invoiceDetail.getInvoiceDetail(search);

            for (int i = 0; i < invoiceDetailList.Count; i++)
            {
                string[] arr = new string[8];
                arr[0] = Convert.ToString(invoiceDetailList[i].ID);
                arr[1] = invoiceDetailList[i].Invoice_ID;
                arr[2] = invoiceDetailList[i].Product_ID;
                arr[3] = invoiceDetailList[i].Combo_ID;
                arr[4] = Convert.ToString(invoiceDetailList[i].Amount);
                arr[5] = invoiceDetailList[i].Price;

                listViewChiTietHD.Items.Add(new ListViewItem(arr));
            }
        }

        //setting thông tin chi tiết Hóa đơn
        private void thongTinChiTietHD(object sender, MouseEventArgs e)
        {
            textBoxIDChiTietHD.Text = listViewChiTietHD.SelectedItems[0].SubItems[0].Text;
            textBoxIDHDChiTietHD.Text = listViewChiTietHD.SelectedItems[0].SubItems[1].Text;
            textBoxSPChiTietHD.Text = listViewChiTietHD.SelectedItems[0].SubItems[2].Text;
            textBoxComboChiTietHD.Text = listViewChiTietHD.SelectedItems[0].SubItems[3].Text;
            textBoxSoLuongChiTietHD.Text = listViewChiTietHD.SelectedItems[0].SubItems[4].Text;
            textBoxGiaChiTietHD.Text = listViewChiTietHD.SelectedItems[0].SubItems[5].Text;
        }

        //---------------------------------------------------Các button chi tiết hóa đơn----------------------------------------------------------
        //nút search cho tiết hóa đơn
        private void searchChiTietHD(object sender, EventArgs e)
        {
            setting_DSChiTietHD(textBoxSearchChiTietHD.Text);
        }

        //mở form thêm chi tiết hóa đơn
        private void openAddChiTietHD(object sender, EventArgs e)
        {
            ThemChiTietHoaDonForm themChiTietHoaDonForm = new ThemChiTietHoaDonForm();
            themChiTietHoaDonForm.formCalled = this;
            themChiTietHoaDonForm.Show();
        }

        //xóa chi tiết hóa đơn
        private void xoaChiTietHD(object sender, EventArgs e)
        {
            if(!textBoxIDChiTietHD.Text.Equals(""))
            {
                if(!textBoxSPChiTietHD.Text.Equals(""))
                {
                    BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();
                    BUS_Invoice invoice = new BUS_Invoice();
                    BUS_Product product = new BUS_Product();

                    InvoiceDetail invoiceDetailDTO = invoiceDetail.getInvoiceDetailWithId(textBoxIDChiTietHD.Text);
                    int tienCanXoa = int.Parse(invoiceDetailDTO.Price) * invoiceDetailDTO.Amount;
                    int tongTienFinal = invoice.getTongTien(textBoxIDHDChiTietHD.Text) - tienCanXoa;

                    int soLuongFinal = product.getSoLuongSP(textBoxSPChiTietHD.Text) + invoiceDetailDTO.Amount;

                    invoice.updateTongTien(textBoxIDHDChiTietHD.Text, Convert.ToString(tongTienFinal));
                    product.updateSoLuongSP(textBoxSPChiTietHD.Text, soLuongFinal);
                    invoiceDetail.deleteChiTietHDTheoId(textBoxIDChiTietHD.Text);
                }
                else
                {
                    BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();
                    BUS_Combo combo = new BUS_Combo();
                    BUS_Invoice invoice = new BUS_Invoice();
                    BUS_Product product = new BUS_Product();

                    InvoiceDetail invoiceDetailDTO = invoiceDetail.getInvoiceDetailWithId(textBoxIDChiTietHD.Text);

                    //tăng số lượng sản phẩm sau khi xóa
                    String productList = combo.getProductList(textBoxComboChiTietHD.Text);
                    String[] productIds = productList.Split(';');

                    for (int i = 0; i < productIds.Length; i++)
                    {
                        int soLuongFinal = product.getSoLuongSP(productIds[i]) + invoiceDetailDTO.Amount;

                        product.updateSoLuongSP(productIds[i], soLuongFinal);
                    }

                    int tienCanXoa = int.Parse(invoiceDetailDTO.Price) * invoiceDetailDTO.Amount;
                    int tongTienFinal = invoice.getTongTien(textBoxIDHDChiTietHD.Text) - tienCanXoa;

                    invoice.updateTongTien(textBoxIDHDChiTietHD.Text, Convert.ToString(tongTienFinal));
                    invoiceDetail.deleteChiTietHDTheoId(textBoxIDChiTietHD.Text);
                }

                setting_DSChiTietHD(textBoxIDHDChiTietHD.Text);
                setting_DSHD("");
                setting_DSSP("");
            }
        }

        //Sửa chi tiết hóa đơn
        private void suaChiTietHD(object sender, EventArgs e)
        {
            if (!textBoxIDChiTietHD.Text.Equals("") && !textBoxSoLuongChiTietHD.Text.Equals("") && textBoxSoLuongChiTietHD.Text.All(char.IsDigit) && int.Parse(textBoxSoLuongChiTietHD.Text) != 0)
            {
                if (!textBoxSPChiTietHD.Text.Equals(""))
                {
                   
                    BUS_Product product = new BUS_Product();
                    BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();
                    BUS_Invoice invoice = new BUS_Invoice();

                    InvoiceDetail invoiceDetailDTO = invoiceDetail.getInvoiceDetailWithId(textBoxIDChiTietHD.Text);

                    if (product.getSoLuongSP(textBoxSPChiTietHD.Text) + invoiceDetailDTO.Amount >= int.Parse(textBoxSoLuongChiTietHD.Text))
                    {
                        int tienCu = int.Parse(invoiceDetailDTO.Price) * invoiceDetailDTO.Amount;
                        int tienMoi = int.Parse(invoiceDetailDTO.Price) * int.Parse(textBoxSoLuongChiTietHD.Text);
                        int tongTienFinal = invoice.getTongTien(textBoxIDHDChiTietHD.Text) - tienCu + tienMoi;

                        int soLuongFinal = product.getSoLuongSP(textBoxSPChiTietHD.Text) + (invoiceDetailDTO.Amount - int.Parse(textBoxSoLuongChiTietHD.Text));

                        invoice.updateTongTien(textBoxIDHDChiTietHD.Text, Convert.ToString(tongTienFinal));
                        product.updateSoLuongSP(textBoxSPChiTietHD.Text, soLuongFinal);
                        invoiceDetail.updateChiTietHDTheoId(int.Parse(textBoxIDChiTietHD.Text), int.Parse(textBoxSoLuongChiTietHD.Text));
                    }

                }
                else
                {
                    BUS_InvoiceDetail invoiceDetail = new BUS_InvoiceDetail();
                    BUS_Combo combo = new BUS_Combo();
                    BUS_Invoice invoice = new BUS_Invoice();
                    BUS_Product product = new BUS_Product();

                    InvoiceDetail invoiceDetailDTO = invoiceDetail.getInvoiceDetailWithId(textBoxIDChiTietHD.Text);

                    //tăng số lượng sản phẩm sau khi xóa
                    String productList = combo.getProductList(textBoxComboChiTietHD.Text);
                    String[] productIds = productList.Split(';');

                    bool canUpdate = true;

                    for (int i = 0; i < productIds.Length; i++)
                    {
                        if (product.getSoLuongSP(productIds[i]) + invoiceDetailDTO.Amount < int.Parse(textBoxSoLuongChiTietHD.Text))
                        {
                            canUpdate = false;
                        }
                    }

                    if(canUpdate)
                    {
                        for (int i = 0; i < productIds.Length; i++)
                        {
                            if (product.getSoLuongSP(productIds[i]) + invoiceDetailDTO.Amount >= int.Parse(textBoxSoLuongChiTietHD.Text))
                            {
                                int soLuongFinal = product.getSoLuongSP(productIds[i]) + (invoiceDetailDTO.Amount - int.Parse(textBoxSoLuongChiTietHD.Text));

                                product.updateSoLuongSP(productIds[i], soLuongFinal);
                            }
                        }

                        int tienCu = int.Parse(invoiceDetailDTO.Price) * invoiceDetailDTO.Amount;
                        int tienMoi = int.Parse(invoiceDetailDTO.Price) * int.Parse(textBoxSoLuongChiTietHD.Text);
                        int tongTienFinal = invoice.getTongTien(textBoxIDHDChiTietHD.Text) - tienCu + tienMoi;

                        invoice.updateTongTien(textBoxIDHDChiTietHD.Text, Convert.ToString(tongTienFinal));
                        invoiceDetail.updateChiTietHDTheoId(int.Parse(textBoxIDChiTietHD.Text), int.Parse(textBoxSoLuongChiTietHD.Text));
                    }
                }

                setting_DSChiTietHD(textBoxIDHDChiTietHD.Text);
                setting_DSHD("");
                setting_DSSP("");
            }
        }

        private void textBoxDiaChiHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCombo_Click(object sender, EventArgs e)
        {
            
        }

       










        //---------------------------------------------------Hết button chi tiết hóa đơn-----------------------------------------------------------

        //-------------------------------------------------------------------Hết phần chi tiết hóa đơn-----------------------------------------------------
    }
}
