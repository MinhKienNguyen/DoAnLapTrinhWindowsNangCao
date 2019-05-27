namespace GiaoDien.Views
{
    partial class UC_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HoaDon));
            this.btntimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.bt_inlaihd = new DevExpress.XtraEditors.SimpleButton();
            this.grdHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridViewhoadon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nvlap = new System.Windows.Forms.TextBox();
            this.dtime_denngay = new DevExpress.XtraEditors.DateEdit();
            this.dtime_TuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_denngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_denngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_TuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_TuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiem
            // 
            this.btntimkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Appearance.Options.UseFont = true;
            this.btntimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.ImageOptions.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(1205, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(135, 33);
            this.btntimkiem.TabIndex = 59;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // bt_inlaihd
            // 
            this.bt_inlaihd.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inlaihd.Appearance.Options.UseFont = true;
            this.bt_inlaihd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_inlaihd.ImageOptions.Image")));
            this.bt_inlaihd.Location = new System.Drawing.Point(1064, 5);
            this.bt_inlaihd.Name = "bt_inlaihd";
            this.bt_inlaihd.Size = new System.Drawing.Size(135, 33);
            this.bt_inlaihd.TabIndex = 60;
            this.bt_inlaihd.Text = "In lại hóa đơn";
            this.bt_inlaihd.Click += new System.EventHandler(this.bt_inlaihd_Click);
            // 
            // grdHoaDon
            // 
            this.grdHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdHoaDon.Location = new System.Drawing.Point(0, 145);
            this.grdHoaDon.MainView = this.gridViewhoadon;
            this.grdHoaDon.Name = "grdHoaDon";
            this.grdHoaDon.Size = new System.Drawing.Size(1350, 403);
            this.grdHoaDon.TabIndex = 66;
            this.grdHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewhoadon});
            // 
            // gridViewhoadon
            // 
            this.gridViewhoadon.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridViewhoadon.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewhoadon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridViewhoadon.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewhoadon.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridViewhoadon.Appearance.Row.Options.UseFont = true;
            this.gridViewhoadon.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridViewhoadon.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewhoadon.AppearancePrint.Row.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridViewhoadon.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewhoadon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn1,
            this.TrangThai});
            this.gridViewhoadon.GridControl = this.grdHoaDon;
            this.gridViewhoadon.GroupCount = 1;
            this.gridViewhoadon.Name = "gridViewhoadon";
            this.gridViewhoadon.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewhoadon.OptionsBehavior.ReadOnly = true;
            this.gridViewhoadon.OptionsPrint.AllowMultilineHeaders = true;
            this.gridViewhoadon.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridViewhoadon.OptionsSelection.MultiSelect = true;
            this.gridViewhoadon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewhoadon.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewhoadon.OptionsView.ShowGroupPanel = false;
            this.gridViewhoadon.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewhoadon.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewhoadon_RowStyle);
            this.gridViewhoadon.DoubleClick += new System.EventHandler(this.gridViewhoadon_DoubleClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Mã hàng";
            this.gridColumn6.FieldName = "MaHangHoa";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 101;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Tên hàng";
            this.gridColumn7.FieldName = "TenHangHoa";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 210;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Màu";
            this.gridColumn9.FieldName = "TenMau";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 102;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "Size";
            this.gridColumn10.FieldName = "TenSize";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 72;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Số Lượng";
            this.gridColumn4.FieldName = "SoLuong";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 85;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Đơn vị tính";
            this.gridColumn3.FieldName = "TenDonViTinh";
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Đơn giá";
            this.gridColumn2.FieldName = "GiaBan";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 76;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Thành tiền";
            this.gridColumn5.FieldName = "ThanhTien";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            this.gridColumn5.Width = 141;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hóa đơn";
            this.gridColumn1.FieldName = "GROUPBY";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 81;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.MinWidth = 21;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 81;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bt_inlaihd);
            this.panelControl1.Controls.Add(this.btntimkiem);
            this.panelControl1.Location = new System.Drawing.Point(3, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1345, 43);
            this.panelControl1.TabIndex = 67;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.txt_nvlap);
            this.panelControl2.Controls.Add(this.dtime_denngay);
            this.panelControl2.Controls.Add(this.dtime_TuNgay);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txt_mahd);
            this.panelControl2.Location = new System.Drawing.Point(3, 49);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1345, 90);
            this.panelControl2.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nhân viên lập";
            // 
            // txt_nvlap
            // 
            this.txt_nvlap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nvlap.Location = new System.Drawing.Point(778, 12);
            this.txt_nvlap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nvlap.Name = "txt_nvlap";
            this.txt_nvlap.Size = new System.Drawing.Size(562, 26);
            this.txt_nvlap.TabIndex = 75;
            // 
            // dtime_denngay
            // 
            this.dtime_denngay.EditValue = null;
            this.dtime_denngay.Location = new System.Drawing.Point(778, 50);
            this.dtime_denngay.Name = "dtime_denngay";
            this.dtime_denngay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_denngay.Properties.Appearance.Options.UseFont = true;
            this.dtime_denngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtime_denngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtime_denngay.Size = new System.Drawing.Size(562, 26);
            this.dtime_denngay.TabIndex = 74;
            this.dtime_denngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtime_denngay_KeyDown);
            // 
            // dtime_TuNgay
            // 
            this.dtime_TuNgay.EditValue = null;
            this.dtime_TuNgay.Location = new System.Drawing.Point(94, 48);
            this.dtime_TuNgay.Name = "dtime_TuNgay";
            this.dtime_TuNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_TuNgay.Properties.Appearance.Options.UseFont = true;
            this.dtime_TuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtime_TuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtime_TuNgay.Size = new System.Drawing.Size(566, 26);
            this.dtime_TuNgay.TabIndex = 73;
            this.dtime_TuNgay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtime_TuNgay_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 19);
            this.labelControl4.TabIndex = 72;
            this.labelControl4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.Location = new System.Drawing.Point(94, 10);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(567, 26);
            this.txt_mahd.TabIndex = 69;
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grdHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(1350, 548);
            this.Load += new System.EventHandler(this.UC_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_denngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_denngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_TuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtime_TuNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btntimkiem;
        private DevExpress.XtraEditors.SimpleButton bt_inlaihd;
        private DevExpress.XtraGrid.GridControl grdHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewhoadon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nvlap;
        private DevExpress.XtraEditors.DateEdit dtime_denngay;
        private DevExpress.XtraEditors.DateEdit dtime_TuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
    }
}
