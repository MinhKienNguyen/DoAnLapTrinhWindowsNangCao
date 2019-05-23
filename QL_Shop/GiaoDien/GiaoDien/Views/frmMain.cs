using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using GiaoDien.Models;
using GiaoDien.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string tenNhanVien;
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        private string tenDangNhap;
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        

        NguoiDungNhomNgDungModel _nguoiDungNhomNgDungModel = new NguoiDungNhomNgDungModel();
        PhanQuyenModel _phanQuyenModel = new PhanQuyenModel();
        public frmMain()
        {
            InitializeComponent();
            Skins();
        }


        public void Skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel them = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            them.LookAndFeel.SkinName = "Office 2010 Blue";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không ?","Thông báo !", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void AddTab(XtraTabControl XtraTabCha, string TabNameAdd, UserControl UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage)
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab (Đây là tên nhé)
            TAbAdd.Name = "Tab";
            // Tên của nó là đối số như đã nói ở trên
            TAbAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            TAbAdd.Controls.Add(UserControl);
            // Dock cho nó tràn hết TAb con đó
            UserControl.Dock = DockStyle.Fill;
            // Quăng nó lên TAb Cha (XtraTabCha là đối số thứ nhất như đã nói ở trên)
            XtraTabCha.TabPages.Add(TAbAdd);
        }

        private void AddTabControl(UserControl userControl, string itemTabName)
        {
            bool isExists = false;
            foreach (XtraTabPage tabItem in xtraTabControl.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    xtraTabControl.SelectedTabPage = tabItem;
                }
            }
            if (isExists == false)
            {
                AddTab(xtraTabControl, itemTabName, userControl);
            }
        }

        /// <summary>
        /// xtraTabControl_CloseButtonClick -- sự kiện đóng tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl.TabPages.RemoveAt(xtraTabControl.SelectedTabPageIndex);
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }

        /// <summary>
        /// xtraTabControl_ControlAdded -- sự kiện add tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }

        /// <summary>
        /// btnnhanvien_ItemClick -- sự kiện load form nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_NhanVien nv = new UC_NhanVien();
            AddTabControl(nv, "Thông tin nhân viên");
            
        }

        private void btItemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_MangHinh mh = new UC_MangHinh();
            AddTabControl(mh,"Màng hình");
        }

        private void btnthemngdungvaonhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_NguoiDungNhomNguoiDung themnv = new UC_NguoiDungNhomNguoiDung();
            AddTabControl(themnv,"Người dùng nhóm người dùng");
        }

        private void FindMenuPhanQuyen(RibbonControl ribbonControl, string pScreenName)
        {
            foreach (RibbonPage RibPage in ribbonControl.Pages)
            {

                foreach (RibbonPageGroup RibPageGroup in RibPage.Groups)
                {
                    int PageGroup = 0;
                    int CounBarItem = 0;

                    foreach (BarItemLink BarItem in RibPageGroup.ItemLinks)
                    {
                        if (BarItem.GetType() == typeof(BarSubItemLink))
                        {
                            BarSubItemLink bsi = (BarSubItemLink)(BarItem);
                            foreach (BarItemLink bi in bsi.VisibleLinks)
                            {
                                foreach (string strValue in bi.Item.Tag.ToString().Split('|'))
                                {
                                    if (pScreenName.Contains(strValue))
                                    {
                                        bi.Item.Visibility = BarItemVisibility.Always;
                                        PageGroup = 1;
                                        CounBarItem = 1;
                                    }
                                }
                            }
                            if (CounBarItem == 1)
                            {
                                BarItem.Item.Visibility = BarItemVisibility.Always;
                            }
                        }
                        else
                        {
                            if (BarItem.Item.Tag == null)
                            {
                                BarItem.Item.Visibility = BarItemVisibility.Never;
                            }
                            else if (pScreenName.Contains(BarItem.Item.Tag.ToString()))
                            {
                                BarItem.Item.Visibility = BarItemVisibility.Always;
                                PageGroup = 1;
                            }
                        }
                    }
                    if (PageGroup == 1)
                    {
                        RibPage.Visible = true;
                        RibPageGroup.Visible = true;
                    }

                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            labelTK.Caption = TenNhanVien.ToString();
            lableTim.Caption = DateTime.Now.ToString();
            DataTable dtNhomND = _nguoiDungNhomNgDungModel.GetMaNhomNguoiDung(TenDangNhap.ToString());
            if (dtNhomND == null || dtNhomND.Rows.Count <= 0)
            {
                FindMenuPhanQuyen(this.ribbonControl1, "");
            }
            foreach(DataRow dr in dtNhomND.Rows)
            {
                DataTable dtQuyen = _phanQuyenModel.GetDataManHinh(dr["MaNhom"].ToString());
                foreach(DataRow row in dtQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.ribbonControl1, row[0].ToString());
                }
            }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmDN.Show();
        }

        private void btnphanquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_PhanQuyen pq = new UC_PhanQuyen();
            AddTabControl(pq, "Phân quyền");
        }

        private void btnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_DanhMucHangHoa hh = new UC_DanhMucHangHoa();
            AddTabControl(hh, "Danh mục hàng hóa");
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_DonHangNCC dh = new UC_DonHangNCC();
            AddTabControl(dh,"Đơn hàng từ nhà cung cấp");
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            popop_DoiMK pop_DoiMk = new popop_DoiMK();
            pop_DoiMk.ShowDialog();
        }

        private void btnqlnguoidung_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnkhuyenmai_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnkhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_KhachHang kh = new UC_KhachHang();
            AddTabControl(kh, "Danh mục khách hàng");
        }

        private void btnloai_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_NhaCungCap ncc = new UC_NhaCungCap();
            AddTabControl(ncc, "Danh mục nhà cung cấp");
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_NhapHang uC_Nhap = new UC_NhapHang();
            AddTabControl(uC_Nhap, "Nhập hàng");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_BanHang bh = new UC_BanHang();
            AddTabControl(bh, "Bán hàng");
        }

        private void btnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_HoaDon uc_hoadon = new UC_HoaDon();
            AddTabControl(uc_hoadon, "Hóa đơn");
        }
    }
}
