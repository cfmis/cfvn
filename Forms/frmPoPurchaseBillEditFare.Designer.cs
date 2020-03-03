namespace cfvn.Forms
{
    partial class frmPoPurchaseBillEditFare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoPurchaseBillEditFare));
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.bdnav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnItemAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnItemDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.qty = new DevExpress.XtraEditors.TextEdit();
            this.lbltransport_mode = new System.Windows.Forms.Label();
            this.unit_code = new DevExpress.XtraEditors.LookUpEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.price = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.txtfare_sum = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.txtgoods_id = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.txtver = new DevExpress.XtraEditors.TextEdit();
            this.txtorg_fare_id = new DevExpress.XtraEditors.TextEdit();
            this.luefare_id = new DevExpress.XtraEditors.LookUpEdit();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnav)).BeginInit();
            this.bdnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfare_sum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgoods_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtorg_fare_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luefare_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(3, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 104;
            this.label12.Tag = "t_fare_id";
            this.label12.Text = "附加費用編號";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 106;
            this.label2.Tag = "t_fare_name";
            this.label2.Text = "附加費用名稱";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtname
            // 
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(113, 104);
            this.txtname.Name = "txtname";
            this.txtname.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtname.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtname.Properties.MaxLength = 250;
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(454, 22);
            this.txtname.TabIndex = 105;
            this.txtname.Tag = "2";
            // 
            // bdnav
            // 
            this.bdnav.AddNewItem = null;
            this.bdnav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdnav.AutoSize = false;
            this.bdnav.CountItem = this.bindingNavigatorCountItem;
            this.bdnav.DeleteItem = null;
            this.bdnav.Dock = System.Windows.Forms.DockStyle.None;
            this.bdnav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnItemAdd,
            this.toolStripSeparator1,
            this.btnItemDel,
            this.toolStripSeparator2,
            this.btnExit});
            this.bdnav.Location = new System.Drawing.Point(3, 2);
            this.bdnav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnav.Name = "bdnav";
            this.bdnav.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnav.Size = new System.Drawing.Size(574, 33);
            this.bdnav.TabIndex = 107;
            this.bdnav.Text = "bindingNavigator1";
            this.bdnav.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bdnav_ItemClicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 30);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Image = global::cfvn.Properties.Resources.p_add_Item;
            this.btnItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(73, 30);
            this.btnItemAdd.Text = "項目新增";
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnItemDel
            // 
            this.btnItemDel.Image = global::cfvn.Properties.Resources.DeleteMR;
            this.btnItemDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(73, 30);
            this.btnItemDel.Text = "項目刪除";
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Image = global::cfvn.Properties.Resources.p_exitsystem;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 30);
            this.btnExit.Text = "關閉";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 117;
            this.label6.Tag = "t_qty";
            this.label6.Text = "數量";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qty
            // 
            this.qty.EnterMoveNextControl = true;
            this.qty.Location = new System.Drawing.Point(113, 131);
            this.qty.Name = "qty";
            this.qty.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.qty.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.qty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.qty.Properties.DisplayFormat.FormatString = "n0";
            this.qty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.qty.Properties.EditFormat.FormatString = "n0";
            this.qty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.qty.Properties.Mask.EditMask = "n0";
            this.qty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.qty.Properties.ReadOnly = true;
            this.qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qty.Size = new System.Drawing.Size(139, 22);
            this.qty.TabIndex = 116;
            this.qty.Tag = "2";
            this.qty.Leave += new System.EventHandler(this.qty_Leave);
            // 
            // lbltransport_mode
            // 
            this.lbltransport_mode.Location = new System.Drawing.Point(290, 135);
            this.lbltransport_mode.Name = "lbltransport_mode";
            this.lbltransport_mode.Size = new System.Drawing.Size(122, 14);
            this.lbltransport_mode.TabIndex = 226;
            this.lbltransport_mode.Tag = "t_unit";
            this.lbltransport_mode.Text = "單位";
            this.lbltransport_mode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unit_code
            // 
            this.unit_code.EditValue = "";
            this.unit_code.Enabled = false;
            this.unit_code.EnterMoveNextControl = true;
            this.unit_code.Location = new System.Drawing.Point(413, 131);
            this.unit_code.Name = "unit_code";
            this.unit_code.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unit_code.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.unit_code.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.unit_code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unit_code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.unit_code.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.unit_code.Properties.DropDownRows = 12;
            this.unit_code.Properties.ImmediatePopup = true;
            this.unit_code.Properties.NullText = "";
            this.unit_code.Properties.PopupWidth = 130;
            this.unit_code.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.unit_code.Properties.ShowHeader = false;
            this.unit_code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.unit_code.Size = new System.Drawing.Size(154, 22);
            this.unit_code.TabIndex = 225;
            this.unit_code.Tag = "2";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 232;
            this.label10.Tag = "t_price";
            this.label10.Text = "單價";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // price
            // 
            this.price.EnterMoveNextControl = true;
            this.price.Location = new System.Drawing.Point(113, 160);
            this.price.Name = "price";
            this.price.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.price.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.price.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.price.Properties.Mask.EditMask = "n2";
            this.price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.price.Properties.ReadOnly = true;
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price.Size = new System.Drawing.Size(139, 22);
            this.price.TabIndex = 231;
            this.price.Tag = "2";
            this.price.Leave += new System.EventHandler(this.price_Leave);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(290, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 242;
            this.label16.Tag = "t_fare_sum";
            this.label16.Text = "費用金額";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfare_sum
            // 
            this.txtfare_sum.Enabled = false;
            this.txtfare_sum.EnterMoveNextControl = true;
            this.txtfare_sum.Location = new System.Drawing.Point(413, 160);
            this.txtfare_sum.Name = "txtfare_sum";
            this.txtfare_sum.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtfare_sum.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtfare_sum.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtfare_sum.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtfare_sum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtfare_sum.Properties.Mask.EditMask = "n2";
            this.txtfare_sum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtfare_sum.Properties.MaxLength = 18;
            this.txtfare_sum.Properties.ReadOnly = true;
            this.txtfare_sum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfare_sum.Size = new System.Drawing.Size(154, 22);
            this.txtfare_sum.TabIndex = 241;
            this.txtfare_sum.Tag = "1";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(293, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 17);
            this.label20.TabIndex = 250;
            this.label20.Tag = "t_goods_id";
            this.label20.Text = "貨品編碼";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgoods_id
            // 
            this.txtgoods_id.Enabled = false;
            this.txtgoods_id.EnterMoveNextControl = true;
            this.txtgoods_id.Location = new System.Drawing.Point(413, 77);
            this.txtgoods_id.Name = "txtgoods_id";
            this.txtgoods_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtgoods_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtgoods_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtgoods_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id.Properties.ReadOnly = true;
            this.txtgoods_id.Size = new System.Drawing.Size(154, 22);
            this.txtgoods_id.TabIndex = 249;
            this.txtgoods_id.Tag = "2";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(413, 48);
            this.txtid.Name = "txtid";
            this.txtid.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtid.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Properties.MaxLength = 18;
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 258;
            this.txtid.Tag = "2";
            // 
            // txtver
            // 
            this.txtver.Enabled = false;
            this.txtver.Location = new System.Drawing.Point(538, 48);
            this.txtver.Name = "txtver";
            this.txtver.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtver.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtver.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtver.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtver.Properties.MaxLength = 5;
            this.txtver.Properties.ReadOnly = true;
            this.txtver.Size = new System.Drawing.Size(29, 22);
            this.txtver.TabIndex = 259;
            this.txtver.Tag = "2";
            // 
            // txtorg_fare_id
            // 
            this.txtorg_fare_id.Enabled = false;
            this.txtorg_fare_id.Location = new System.Drawing.Point(253, 104);
            this.txtorg_fare_id.Name = "txtorg_fare_id";
            this.txtorg_fare_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtorg_fare_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtorg_fare_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtorg_fare_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtorg_fare_id.Properties.MaxLength = 10;
            this.txtorg_fare_id.Properties.ReadOnly = true;
            this.txtorg_fare_id.Size = new System.Drawing.Size(52, 22);
            this.txtorg_fare_id.TabIndex = 260;
            this.txtorg_fare_id.Tag = "2";
            // 
            // luefare_id
            // 
            this.luefare_id.EditValue = "";
            this.luefare_id.Enabled = false;
            this.luefare_id.EnterMoveNextControl = true;
            this.luefare_id.Location = new System.Drawing.Point(113, 77);
            this.luefare_id.Name = "luefare_id";
            this.luefare_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luefare_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luefare_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luefare_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luefare_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luefare_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "name")});
            this.luefare_id.Properties.ImmediatePopup = true;
            this.luefare_id.Properties.MaxLength = 18;
            this.luefare_id.Properties.NullText = "";
            this.luefare_id.Properties.PopupWidth = 150;
            this.luefare_id.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.luefare_id.Properties.ShowHeader = false;
            this.luefare_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luefare_id.Size = new System.Drawing.Size(139, 22);
            this.luefare_id.TabIndex = 18;
            this.luefare_id.Tag = "2";
            this.luefare_id.Leave += new System.EventHandler(this.luefare_id_Leave);
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(296, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 17);
            this.lblID.TabIndex = 261;
            this.lblID.Tag = "t_id";
            this.lblID.Text = "編號";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPoPurchaseBillEditFare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(577, 265);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtver);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtgoods_id);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtfare_sum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.price);
            this.Controls.Add(this.lbltransport_mode);
            this.Controls.Add(this.unit_code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.bdnav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.luefare_id);
            this.Controls.Add(this.txtorg_fare_id);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPoPurchaseBillEditFare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FareEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPoPurchaseBillEditFare_FormClosed);
            this.Load += new System.EventHandler(this.frmPoPurchaseBillEditFare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnav)).EndInit();
            this.bdnav.ResumeLayout(false);
            this.bdnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfare_sum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgoods_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtorg_fare_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luefare_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtname;
        private System.Windows.Forms.BindingNavigator bdnav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit qty;
        private System.Windows.Forms.Label lbltransport_mode;
        private DevExpress.XtraEditors.LookUpEdit unit_code;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit price;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit txtfare_sum;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.TextEdit txtgoods_id;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnItemAdd;
        private System.Windows.Forms.ToolStripButton btnItemDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.TextEdit txtver;
        private DevExpress.XtraEditors.TextEdit txtorg_fare_id;
        private DevExpress.XtraEditors.LookUpEdit luefare_id;
        private System.Windows.Forms.Label lblID;
    }
}