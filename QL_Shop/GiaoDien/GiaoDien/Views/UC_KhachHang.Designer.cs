namespace GiaoDien.Views
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
            this.txt_makhachhang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupSearch = new DevExpress.XtraEditors.GroupControl();
            this.lblTenKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.txt_tenkhachhang = new DevExpress.XtraEditors.TextEdit();
            this.txtmakh = new DevExpress.XtraEditors.TextEdit();
            this.txttenkh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtsdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupThongTinKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.griKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSearch)).BeginInit();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinKhachHang)).BeginInit();
            this.groupThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(275, 104);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 34);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.EditValue = "";
            this.txt_makhachhang.Location = new System.Drawing.Point(128, 31);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhachhang.Properties.Appearance.Options.UseFont = true;
            this.txt_makhachhang.Size = new System.Drawing.Size(279, 26);
            this.txt_makhachhang.TabIndex = 33;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(14, 34);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(96, 19);
            this.labelControl11.TabIndex = 34;
            this.labelControl11.Text = "Mã khách hàng:";
            // 
            // groupSearch
            // 
            this.groupSearch.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.AppearanceCaption.Options.UseFont = true;
            this.groupSearch.Controls.Add(this.lblTenKhachHang);
            this.groupSearch.Controls.Add(this.txt_tenkhachhang);
            this.groupSearch.Controls.Add(this.labelControl11);
            this.groupSearch.Controls.Add(this.txt_makhachhang);
            this.groupSearch.Controls.Add(this.btnTimKiem);
            this.groupSearch.Location = new System.Drawing.Point(8, 29);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(447, 151);
            this.groupSearch.TabIndex = 0;
            this.groupSearch.Text = "Tìm kiếm";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Appearance.Options.UseFont = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(14, 66);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(98, 19);
            this.lblTenKhachHang.TabIndex = 36;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.EditValue = "";
            this.txt_tenkhachhang.Location = new System.Drawing.Point(128, 63);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkhachhang.Properties.Appearance.Options.UseFont = true;
            this.txt_tenkhachhang.Size = new System.Drawing.Size(279, 26);
            this.txt_tenkhachhang.TabIndex = 35;
            // 
            // txtmakh
            // 
            this.txtmakh.EditValue = "";
            this.txtmakh.Enabled = false;
            this.txtmakh.Location = new System.Drawing.Point(128, 41);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Properties.Appearance.Options.UseFont = true;
            this.txtmakh.Size = new System.Drawing.Size(278, 26);
            this.txtmakh.TabIndex = 3;
            // 
            // txttenkh
            // 
            this.txttenkh.EditValue = "";
            this.txttenkh.Location = new System.Drawing.Point(128, 76);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.Properties.Appearance.Options.UseFont = true;
            this.txttenkh.Size = new System.Drawing.Size(278, 26);
            this.txttenkh.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mã khách hàng::";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên khách hàng:";
            // 
            // txtsdt
            // 
            this.txtsdt.EditValue = "";
            this.txtsdt.Location = new System.Drawing.Point(127, 109);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(0);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Properties.Appearance.Options.UseFont = true;
            this.txtsdt.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtsdt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtsdt.Size = new System.Drawing.Size(279, 26);
            this.txtsdt.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 19);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.EditValue = "";
            this.txtdiachi.Location = new System.Drawing.Point(127, 144);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Properties.Appearance.Options.UseFont = true;
            this.txtdiachi.Size = new System.Drawing.Size(279, 26);
            this.txtdiachi.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 19);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Số điện thoại:";
            // 
            // groupThongTinKhachHang
            // 
            this.groupThongTinKhachHang.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinKhachHang.AppearanceCaption.Options.UseFont = true;
            this.groupThongTinKhachHang.Controls.Add(this.labelControl6);
            this.groupThongTinKhachHang.Controls.Add(this.txtdiachi);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl4);
            this.groupThongTinKhachHang.Controls.Add(this.txtsdt);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl2);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl1);
            this.groupThongTinKhachHang.Controls.Add(this.txttenkh);
            this.groupThongTinKhachHang.Controls.Add(this.txtmakh);
            this.groupThongTinKhachHang.Location = new System.Drawing.Point(8, 186);
            this.groupThongTinKhachHang.Name = "groupThongTinKhachHang";
            this.groupThongTinKhachHang.Size = new System.Drawing.Size(447, 190);
            this.groupThongTinKhachHang.TabIndex = 29;
            this.groupThongTinKhachHang.Text = "Thông Tin khách hàng:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Location = new System.Drawing.Point(8, 382);
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
            this.griKhachHang.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.griKhachHang.Appearance.Row.Options.UseFont = true;
            this.griKhachHang.AppearancePrint.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.griKhachHang.AppearancePrint.Row.Options.UseFont = true;
            this.griKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerCode,
            this.CustName,
            this.CustPhone,
            this.CustAdress});
            this.griKhachHang.GridControl = this.gridControl1;
            this.griKhachHang.Name = "griKhachHang";
            this.griKhachHang.OptionsBehavior.ReadOnly = true;
            this.griKhachHang.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.griKhachHang.OptionsView.ShowGroupPanel = false;
            this.griKhachHang.Click += new System.EventHandler(this.griKhachHang_Click);
            // 
            // CustomerCode
            // 
            this.CustomerCode.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCode.AppearanceCell.Options.UseFont = true;
            this.CustomerCode.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCode.AppearanceHeader.Options.UseFont = true;
            this.CustomerCode.AppearanceHeader.Options.UseTextOptions = true;
            this.CustomerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustomerCode.Caption = "Mã khách hàng";
            this.CustomerCode.FieldName = "MaKhachHang";
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.Visible = true;
            this.CustomerCode.VisibleIndex = 0;
            this.CustomerCode.Width = 50;
            // 
            // CustName
            // 
            this.CustName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.AppearanceCell.Options.UseFont = true;
            this.CustName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.AppearanceHeader.Options.UseFont = true;
            this.CustName.AppearanceHeader.Options.UseTextOptions = true;
            this.CustName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustName.Caption = "Tên khách hàng";
            this.CustName.FieldName = "TenKhachHang";
            this.CustName.Name = "CustName";
            this.CustName.Visible = true;
            this.CustName.VisibleIndex = 1;
            this.CustName.Width = 70;
            // 
            // CustPhone
            // 
            this.CustPhone.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPhone.AppearanceCell.Options.UseFont = true;
            this.CustPhone.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPhone.AppearanceHeader.Options.UseFont = true;
            this.CustPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.CustPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustPhone.Caption = "Số điện thoại";
            this.CustPhone.FieldName = "SDT_KH";
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.Visible = true;
            this.CustPhone.VisibleIndex = 2;
            this.CustPhone.Width = 50;
            // 
            // CustAdress
            // 
            this.CustAdress.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAdress.AppearanceCell.Options.UseFont = true;
            this.CustAdress.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAdress.AppearanceHeader.Options.UseFont = true;
            this.CustAdress.AppearanceHeader.Options.UseTextOptions = true;
            this.CustAdress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustAdress.Caption = "Địa chỉ";
            this.CustAdress.FieldName = "DiaChiKhachHang";
            this.CustAdress.Name = "CustAdress";
            this.CustAdress.Visible = true;
            this.CustAdress.VisibleIndex = 3;
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
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupThongTinKhachHang);
            this.Controls.Add(this.groupSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1351, 548);
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSearch)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinKhachHang)).EndInit();
            this.groupThongTinKhachHang.ResumeLayout(false);
            this.groupThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txt_makhachhang;
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
        private DevExpress.XtraEditors.LabelControl lblTenKhachHang;
        private DevExpress.XtraEditors.TextEdit txt_tenkhachhang;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}
