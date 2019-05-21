using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Tile;

namespace GiaoDien.Views
{
    partial class UC_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhanVien));
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.ColImageNV = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.NameNV = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmployessName = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongtinnhanvien = new DevExpress.XtraEditors.GroupControl();
            this.lkuChucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.imgChonAnh = new System.Windows.Forms.PictureBox();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.grdNhanVien = new DevExpress.XtraGrid.GridControl();
            this.tileViewNhanVien = new DevExpress.XtraGrid.Views.Tile.TileView();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployessName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtinnhanvien)).BeginInit();
            this.groupThongtinnhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChonAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // ColImageNV
            // 
            this.ColImageNV.Caption = "tileViewColumn1";
            this.ColImageNV.ColumnEdit = this.repositoryItemImageEdit1;
            this.ColImageNV.FieldName = "HinhAnhNV";
            this.ColImageNV.MinWidth = 23;
            this.ColImageNV.Name = "ColImageNV";
            this.ColImageNV.Visible = true;
            this.ColImageNV.VisibleIndex = 0;
            this.ColImageNV.Width = 87;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // NameNV
            // 
            this.NameNV.Caption = "tileViewColumn1";
            this.NameNV.FieldName = "TenNhanVien";
            this.NameNV.MinWidth = 23;
            this.NameNV.Name = "NameNV";
            this.NameNV.Visible = true;
            this.NameNV.VisibleIndex = 1;
            this.NameNV.Width = 87;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtEmployessName);
            this.groupControl2.Controls.Add(this.btnTimKiem);
            this.groupControl2.Location = new System.Drawing.Point(3, 4);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(421, 116);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Thông tin tìm kiếm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 22);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tên nhân viên:";
            // 
            // txtEmployessName
            // 
            this.txtEmployessName.Location = new System.Drawing.Point(168, 33);
            this.txtEmployessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployessName.Name = "txtEmployessName";
            this.txtEmployessName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployessName.Properties.Appearance.Options.UseFont = true;
            this.txtEmployessName.Size = new System.Drawing.Size(250, 28);
            this.txtEmployessName.TabIndex = 3;
            this.txtEmployessName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployessName_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(296, 70);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 39);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupThongtinnhanvien
            // 
            this.groupThongtinnhanvien.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongtinnhanvien.Appearance.Options.UseFont = true;
            this.groupThongtinnhanvien.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongtinnhanvien.AppearanceCaption.Options.UseFont = true;
            this.groupThongtinnhanvien.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupThongtinnhanvien.Controls.Add(this.lkuChucVu);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl5);
            this.groupThongtinnhanvien.Controls.Add(this.txtPass);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl3);
            this.groupThongtinnhanvien.Controls.Add(this.txtUser);
            this.groupThongtinnhanvien.Controls.Add(this.imgChonAnh);
            this.groupThongtinnhanvien.Controls.Add(this.btnChon);
            this.groupThongtinnhanvien.Controls.Add(this.btnThem);
            this.groupThongtinnhanvien.Controls.Add(this.rdoNu);
            this.groupThongtinnhanvien.Controls.Add(this.rdoNam);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl2);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl11);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl12);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl13);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl14);
            this.groupThongtinnhanvien.Controls.Add(this.labelControl15);
            this.groupThongtinnhanvien.Controls.Add(this.txtDiaChi);
            this.groupThongtinnhanvien.Controls.Add(this.txtSDT);
            this.groupThongtinnhanvien.Controls.Add(this.txtTenNV);
            this.groupThongtinnhanvien.Controls.Add(this.txtMaNV);
            this.groupThongtinnhanvien.Controls.Add(this.btnLuu);
            this.groupThongtinnhanvien.Controls.Add(this.btnXoa);
            this.groupThongtinnhanvien.Location = new System.Drawing.Point(3, 116);
            this.groupThongtinnhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupThongtinnhanvien.Name = "groupThongtinnhanvien";
            this.groupThongtinnhanvien.Size = new System.Drawing.Size(421, 551);
            this.groupThongtinnhanvien.TabIndex = 11;
            this.groupThongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // lkuChucVu
            // 
            this.lkuChucVu.Location = new System.Drawing.Point(143, 448);
            this.lkuChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkuChucVu.Name = "lkuChucVu";
            this.lkuChucVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkuChucVu.Properties.Appearance.Options.UseFont = true;
            this.lkuChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuChucVu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhom", "Mã loại chức vụ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhom", "Tên loại chức vụ")});
            this.lkuChucVu.Properties.NullText = "";
            this.lkuChucVu.Size = new System.Drawing.Size(275, 28);
            this.lkuChucVu.TabIndex = 43;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(36, 404);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 22);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "PassWord";
            // 
            // txtPass
            // 
            this.txtPass.EditValue = "";
            this.txtPass.Location = new System.Drawing.Point(143, 400);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Size = new System.Drawing.Size(275, 28);
            this.txtPass.TabIndex = 41;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 353);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 22);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "UserName";
            // 
            // txtUser
            // 
            this.txtUser.EditValue = "";
            this.txtUser.Location = new System.Drawing.Point(143, 350);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(275, 28);
            this.txtUser.TabIndex = 39;
            // 
            // imgChonAnh
            // 
            this.imgChonAnh.Location = new System.Drawing.Point(7, 34);
            this.imgChonAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgChonAnh.Name = "imgChonAnh";
            this.imgChonAnh.Size = new System.Drawing.Size(117, 113);
            this.imgChonAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgChonAnh.TabIndex = 38;
            this.imgChonAnh.TabStop = false;
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.ImageOptions.Image")));
            this.btnChon.Location = new System.Drawing.Point(5, 155);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(124, 47);
            this.btnChon.TabIndex = 37;
            this.btnChon.Text = "Chọn hình";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(7, 496);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 44);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(247, 302);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(5);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(56, 26);
            this.rdoNu.TabIndex = 32;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(143, 302);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(5);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(68, 26);
            this.rdoNam.TabIndex = 31;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 452);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 22);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Chức vụ";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(36, 304);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(71, 22);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "Giới tính";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(36, 261);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(58, 22);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "Địa chỉ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(36, 210);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(104, 22);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "Số điện thoại";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(142, 118);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(110, 22);
            this.labelControl14.TabIndex = 25;
            this.labelControl14.Text = "Tên nhân viên";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(143, 42);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(106, 22);
            this.labelControl15.TabIndex = 24;
            this.labelControl15.Text = "Mã nhân viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.EditValue = "";
            this.txtDiaChi.Location = new System.Drawing.Point(143, 257);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(275, 28);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtSDT
            // 
            this.txtSDT.EditValue = "";
            this.txtSDT.Location = new System.Drawing.Point(143, 207);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtSDT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSDT.Size = new System.Drawing.Size(275, 28);
            this.txtSDT.TabIndex = 22;
            // 
            // txtTenNV
            // 
            this.txtTenNV.EditValue = "";
            this.txtTenNV.Location = new System.Drawing.Point(142, 151);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenNV.Size = new System.Drawing.Size(275, 28);
            this.txtTenNV.TabIndex = 21;
            // 
            // txtMaNV
            // 
            this.txtMaNV.EditValue = "";
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(142, 76);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(275, 28);
            this.txtMaNV.TabIndex = 20;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(189, 496);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 44);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(328, 496);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grdNhanVien
            // 
            this.grdNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdNhanVien.Location = new System.Drawing.Point(429, 4);
            this.grdNhanVien.MainView = this.tileViewNhanVien;
            this.grdNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdNhanVien.Name = "grdNhanVien";
            this.grdNhanVien.Size = new System.Drawing.Size(1143, 663);
            this.grdNhanVien.TabIndex = 12;
            this.grdNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewNhanVien});
            // 
            // tileViewNhanVien
            // 
            this.tileViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColImageNV,
            this.NameNV});
            this.tileViewNhanVien.DetailHeight = 431;
            this.tileViewNhanVien.GridControl = this.grdNhanVien;
            this.tileViewNhanVien.Name = "tileViewNhanVien";
            this.tileViewNhanVien.OptionsTiles.ColumnCount = 4;
            this.tileViewNhanVien.OptionsTiles.IndentBetweenGroups = 44;
            this.tileViewNhanVien.OptionsTiles.IndentBetweenItems = 1;
            this.tileViewNhanVien.OptionsTiles.ItemSize = new System.Drawing.Size(250, 300);
            this.tileViewNhanVien.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileViewNhanVien.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileViewNhanVien.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileViewNhanVien.OptionsTiles.RowCount = 0;
            this.tileViewNhanVien.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            tableRowDefinition1.Length.Value = 132D;
            tableRowDefinition2.Length.Value = 32D;
            this.tileViewNhanVien.TileRows.Add(tableRowDefinition1);
            this.tileViewNhanVien.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Column = this.ColImageNV;
            tileViewItemElement1.Text = "ColImageNV";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.NameNV;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "NameNV";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileViewNhanVien.TileTemplate.Add(tileViewItemElement1);
            this.tileViewNhanVien.TileTemplate.Add(tileViewItemElement2);
            this.tileViewNhanVien.ItemDoubleClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileViewNhanVien_ItemDoubleClick);
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.grdNhanVien);
            this.Controls.Add(this.groupThongtinnhanvien);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1576, 674);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployessName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongtinnhanvien)).EndInit();
            this.groupThongtinnhanvien.ResumeLayout(false);
            this.groupThongtinnhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChonAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmployessName;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.GroupControl groupThongtinnhanvien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private System.Windows.Forms.PictureBox imgChonAnh;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LookUpEdit lkuChucVu;
        private GridControl grdNhanVien;
        private TileView tileViewNhanVien;
        private TileViewColumn ColImageNV;
        private TileViewColumn NameNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}
