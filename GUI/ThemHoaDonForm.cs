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
    public partial class ThemHoaDonForm : Form
    {
        public MainForm formCalled;

        public ThemHoaDonForm()
        {
            InitializeComponent();
        }

        //Thêm Hóa đơn
        private void submitAddHD(object sender, EventArgs e)
        {
            BUS_Invoice invoice = new BUS_Invoice();
            BUS_Customer customer = new BUS_Customer();
            BUS_Employee employee = new BUS_Employee();

            if(!textBoxID.Text.Equals("") && !textBoxName.Text.Equals("") && !textBoxKhachHang.Text.Equals("") && !textBoxShipper.Text.Equals("") && !textBoxNgayTao.Text.Equals("") && !textBoxDiaChi.Text.Equals("") && !textBoxNgayGiao.Text.Equals("") && !invoice.ktTonTaiHoaDonId(textBoxID.Text) && customer.ktTonTaiKhachHangTheoId(textBoxKhachHang.Text) && employee.ktTonTaiShipperTheoId(textBoxShipper.Text))
            {
                invoice.addHoaDon(new Invoice(textBoxID.Text, textBoxName.Text, textBoxKhachHang.Text, textBoxShipper.Text, textBoxTongTien.Text, textBoxNgayTao.Text, textBoxDiaChi.Text, textBoxNgayGiao.Text));
                
                formCalled.setting_DSHD("");
            }
        }
    }
}
