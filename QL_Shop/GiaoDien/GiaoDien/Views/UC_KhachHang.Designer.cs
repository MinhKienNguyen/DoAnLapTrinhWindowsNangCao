﻿namespace GiaoDien.Views
{
    partial class UC_KhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhachHang));
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupSearch = new DevExpress.XtraEditors.GroupControl();
            this.txtmakh = new DevExpress.XtraEditors.TextEdit();
            this.txttenkh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtsdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupThongTinKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.txt_mathe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tongtien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.griKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txt_makhachhang = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSearch)).BeginInit();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinKhachHang)).BeginInit();
            this.groupThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mathe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(288, 68);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(144, 34);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(13, 40);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(114, 22);
            this.labelControl11.TabIndex = 34;
            this.labelControl11.Text = "Nhập thông tin";
            // 
            // groupSearch
            // 
            this.groupSearch.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.AppearanceCaption.Options.UseFont = true;
            this.groupSearch.Controls.Add(this.labelControl11);
            this.groupSearch.Controls.Add(this.txt_makhachhang);
            this.groupSearch.Controls.Add(this.btnTimKiem);
            this.groupSearch.Location = new System.Drawing.Point(8, 3);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(447, 111);
            this.groupSearch.TabIndex = 0;
            this.groupSearch.Text = "Thông tin tìm kiếm";
            // 
            // txtmakh
            // 
            this.txtmakh.EditValue = "";
            this.txtmakh.Location = new System.Drawing.Point(143, 38);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Properties.Appearance.Options.UseFont = true;
            this.txtmakh.Size = new System.Drawing.Size(290, 28);
            this.txtmakh.TabIndex = 3;
            // 
            // txttenkh
            // 
            this.txttenkh.EditValue = "";
            this.txttenkh.Location = new System.Drawing.Point(144, 131);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.Properties.Appearance.Options.UseFont = true;
            this.txttenkh.Size = new System.Drawing.Size(289, 28);
            this.txttenkh.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 22);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mã khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 137);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 22);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên khách hàng";
            // 
            // txtsdt
            // 
            this.txtsdt.EditValue = "";
            this.txtsdt.Location = new System.Drawing.Point(144, 176);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(0);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Properties.Appearance.Options.UseFont = true;
            this.txtsdt.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtsdt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtsdt.Size = new System.Drawing.Size(289, 28);
            this.txtsdt.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 228);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 22);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.EditValue = "";
            this.txtdiachi.Location = new System.Drawing.Point(144, 222);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Properties.Appearance.Options.UseFont = true;
            this.txtdiachi.Size = new System.Drawing.Size(289, 28);
            this.txtdiachi.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(16, 182);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 22);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Số điện thoại";
            // 
            // groupThongTinKhachHang
            // 
            this.groupThongTinKhachHang.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinKhachHang.AppearanceCaption.Options.UseFont = true;
            this.groupThongTinKhachHang.Controls.Add(this.txt_mathe);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl5);
            this.groupThongTinKhachHang.Controls.Add(this.txt_tongtien);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl3);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl6);
            this.groupThongTinKhachHang.Controls.Add(this.txtdiachi);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl4);
            this.groupThongTinKhachHang.Controls.Add(this.txtsdt);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl2);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl1);
            this.groupThongTinKhachHang.Controls.Add(this.txttenkh);
            this.groupThongTinKhachHang.Controls.Add(this.txtmakh);
            this.groupThongTinKhachHang.Location = new System.Drawing.Point(8, 120);
            this.groupThongTinKhachHang.Name = "groupThongTinKhachHang";
            this.groupThongTinKhachHang.Size = new System.Drawing.Size(447, 303);
            this.groupThongTinKhachHang.TabIndex = 29;
            this.groupThongTinKhachHang.Text = "Thông Tin khách hàng";
            // 
            // txt_mathe
            // 
            this.txt_mathe.EditValue = "";
            this.txt_mathe.Location = new System.Drawing.Point(144, 85);
            this.txt_mathe.Name = "txt_mathe";
            this.txt_mathe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathe.Properties.Appearance.Options.UseFont = true;
            this.txt_mathe.Size = new System.Drawing.Size(289, 28);
            this.txt_mathe.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 91);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 22);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Mã thẻ";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.EditValue = "";
            this.txt_tongtien.Location = new System.Drawing.Point(144, 270);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Properties.Appearance.Options.UseFont = true;
            this.txt_tongtien.Size = new System.Drawing.Size(289, 28);
            this.txt_tongtien.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 276);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 22);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Tổng tiền";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Location = new System.Drawing.Point(13, 429);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(442, 116);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "Chức năng thực hiện";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(12, 45);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 44);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(165, 45);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 44);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(310, 45);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 44);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // griKhachHang
            // 
            this.griKhachHang.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.griKhachHang.Appearance.Row.Options.UseFont = true;
            this.griKhachHang.AppearancePrint.Row.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.griKhachHang.AppearancePrint.Row.Options.UseFont = true;
            this.griKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.CustomerCode,
            this.gridColumn2,
            this.CustName,
            this.CustPhone,
            this.CustAdress,
            this.gridColumn3});
            this.griKhachHang.GridControl = this.gridControl1;
            this.griKhachHang.Name = "griKhachHang";
            this.griKhachHang.OptionsBehavior.ReadOnly = true;
            this.griKhachHang.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.griKhachHang.OptionsView.ShowGroupPanel = false;
            this.griKhachHang.Click += new System.EventHandler(this.griKhachHang_Click);
            this.griKhachHang.DoubleClick += new System.EventHandler(this.griKhachHang_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "ROW";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 59;
            // 
            // CustomerCode
            // 
            this.CustomerCode.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustomerCode.AppearanceCell.Options.UseFont = true;
            this.CustomerCode.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustomerCode.AppearanceHeader.Options.UseFont = true;
            this.CustomerCode.AppearanceHeader.Options.UseTextOptions = true;
            this.CustomerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustomerCode.Caption = "Mã khách hàng";
            this.CustomerCode.FieldName = "MaKhachHang";
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.Visible = true;
            this.CustomerCode.VisibleIndex = 1;
            this.CustomerCode.Width = 120;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã BarCde";
            this.gridColumn2.FieldName = "BarCde";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 100;
            // 
            // CustName
            // 
            this.CustName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustName.AppearanceCell.Options.UseFont = true;
            this.CustName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustName.AppearanceHeader.Options.UseFont = true;
            this.CustName.AppearanceHeader.Options.UseTextOptions = true;
            this.CustName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustName.Caption = "Tên khách hàng";
            this.CustName.FieldName = "TenKhachHang";
            this.CustName.Name = "CustName";
            this.CustName.Visible = true;
            this.CustName.VisibleIndex = 3;
            this.CustName.Width = 199;
            // 
            // CustPhone
            // 
            this.CustPhone.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustPhone.AppearanceCell.Options.UseFont = true;
            this.CustPhone.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustPhone.AppearanceHeader.Options.UseFont = true;
            this.CustPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.CustPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustPhone.Caption = "Số điện thoại";
            this.CustPhone.FieldName = "SDT_KH";
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.Visible = true;
            this.CustPhone.VisibleIndex = 4;
            this.CustPhone.Width = 169;
            // 
            // CustAdress
            // 
            this.CustAdress.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustAdress.AppearanceCell.Options.UseFont = true;
            this.CustAdress.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CustAdress.AppearanceHeader.Options.UseFont = true;
            this.CustAdress.AppearanceHeader.Options.UseTextOptions = true;
            this.CustAdress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustAdress.Caption = "Địa chỉ";
            this.CustAdress.FieldName = "DiaChiKhachHang";
            this.CustAdress.Name = "CustAdress";
            this.CustAdress.Visible = true;
            this.CustAdress.VisibleIndex = 5;
            this.CustAdress.Width = 233;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Tổng tiền tích";
            this.gridColumn3.FieldName = "TichTien";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 133;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(461, 3);
            this.gridControl1.MainView = this.griKhachHang;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(887, 542);
            this.gridControl1.TabIndex = 31;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griKhachHang});
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.EditValue = "";
            this.txt_makhachhang.Location = new System.Drawing.Point(142, 34);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhachhang.Properties.Appearance.Options.UseFont = true;
            this.txt_makhachhang.Size = new System.Drawing.Size(291, 28);
            this.txt_makhachhang.TabIndex = 33;
            this.txt_makhachhang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_makhachhang_KeyDown);
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupThongTinKhachHang);
            this.Controls.Add(this.groupSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1351, 548);
            ((System.ComponentModel.ISupportInitialize)(this.groupSearch)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinKhachHang)).EndInit();
            this.groupThongTinKhachHang.ResumeLayout(false);
            this.groupThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mathe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupSearch;
        private DevExpress.XtraEditors.TextEdit txtmakh;
        private DevExpress.XtraEditors.TextEdit txttenkh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtsdt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupThongTinKhachHang;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView griKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn CustName;
        private DevExpress.XtraGrid.Columns.GridColumn CustPhone;
        private DevExpress.XtraGrid.Columns.GridColumn CustAdress;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txt_tongtien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.TextEdit txt_mathe;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_makhachhang;
    }
}
