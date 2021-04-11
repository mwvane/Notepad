namespace Notepad
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.btnMinimase = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximase = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCounter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveAs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPaste = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCopy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timeMenuSlider = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeSearchSlider = new System.Windows.Forms.Timer(this.components);
            this.pnlText = new System.Windows.Forms.Panel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlDrag.Controls.Add(this.btnMinimase);
            this.pnlDrag.Controls.Add(this.btnMaximase);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(842, 26);
            this.pnlDrag.TabIndex = 0;
            this.pnlDrag.DoubleClick += new System.EventHandler(this.pnlDrag_DoubleClick);
            // 
            // btnMinimase
            // 
            this.btnMinimase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimase.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimase.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimase.Image")));
            this.btnMinimase.ImageActive = null;
            this.btnMinimase.Location = new System.Drawing.Point(770, 2);
            this.btnMinimase.Name = "btnMinimase";
            this.btnMinimase.Size = new System.Drawing.Size(20, 20);
            this.btnMinimase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimase.TabIndex = 0;
            this.btnMinimase.TabStop = false;
            this.btnMinimase.Zoom = 10;
            this.btnMinimase.Click += new System.EventHandler(this.btnMinimase_Click);
            // 
            // btnMaximase
            // 
            this.btnMaximase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximase.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximase.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximase.Image")));
            this.btnMaximase.ImageActive = null;
            this.btnMaximase.Location = new System.Drawing.Point(794, 2);
            this.btnMaximase.Name = "btnMaximase";
            this.btnMaximase.Size = new System.Drawing.Size(20, 20);
            this.btnMaximase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximase.TabIndex = 0;
            this.btnMaximase.TabStop = false;
            this.btnMaximase.Zoom = 10;
            this.btnMaximase.Click += new System.EventHandler(this.btnMaximase_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(818, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlMenu.Controls.Add(this.btnCounter);
            this.pnlMenu.Controls.Add(this.btnCut);
            this.pnlMenu.Controls.Add(this.btnSaveAs);
            this.pnlMenu.Controls.Add(this.btnPaste);
            this.pnlMenu.Controls.Add(this.btnCopy);
            this.pnlMenu.Controls.Add(this.btnSave);
            this.pnlMenu.Controls.Add(this.btnOpen);
            this.pnlMenu.Controls.Add(this.btnNew);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 26);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(40, 511);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnCounter
            // 
            this.btnCounter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCounter.BackColor = System.Drawing.Color.Transparent;
            this.btnCounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCounter.BorderRadius = 0;
            this.btnCounter.ButtonText = "         Counter";
            this.btnCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCounter.DisabledColor = System.Drawing.Color.Gray;
            this.btnCounter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCounter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCounter.Iconimage")));
            this.btnCounter.Iconimage_right = null;
            this.btnCounter.Iconimage_right_Selected = null;
            this.btnCounter.Iconimage_Selected = null;
            this.btnCounter.IconMarginLeft = 0;
            this.btnCounter.IconMarginRight = 0;
            this.btnCounter.IconRightVisible = true;
            this.btnCounter.IconRightZoom = 0D;
            this.btnCounter.IconVisible = true;
            this.btnCounter.IconZoom = 38D;
            this.btnCounter.IsTab = false;
            this.btnCounter.Location = new System.Drawing.Point(-6, 460);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCounter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnCounter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCounter.selected = false;
            this.btnCounter.Size = new System.Drawing.Size(221, 48);
            this.btnCounter.TabIndex = 1;
            this.btnCounter.Text = "         Counter";
            this.btnCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCounter.Textcolor = System.Drawing.Color.White;
            this.btnCounter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // btnCut
            // 
            this.btnCut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCut.BackColor = System.Drawing.Color.Transparent;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCut.BorderRadius = 0;
            this.btnCut.ButtonText = "         Cut";
            this.btnCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCut.DisabledColor = System.Drawing.Color.Gray;
            this.btnCut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCut.Iconimage")));
            this.btnCut.Iconimage_right = null;
            this.btnCut.Iconimage_right_Selected = null;
            this.btnCut.Iconimage_Selected = null;
            this.btnCut.IconMarginLeft = 0;
            this.btnCut.IconMarginRight = 0;
            this.btnCut.IconRightVisible = true;
            this.btnCut.IconRightZoom = 0D;
            this.btnCut.IconVisible = true;
            this.btnCut.IconZoom = 40D;
            this.btnCut.IsTab = false;
            this.btnCut.Location = new System.Drawing.Point(-6, 403);
            this.btnCut.Name = "btnCut";
            this.btnCut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnCut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCut.selected = false;
            this.btnCut.Size = new System.Drawing.Size(221, 48);
            this.btnCut.TabIndex = 1;
            this.btnCut.Text = "         Cut";
            this.btnCut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCut.Textcolor = System.Drawing.Color.White;
            this.btnCut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveAs.BorderRadius = 0;
            this.btnSaveAs.ButtonText = "         Save as...";
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveAs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveAs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Iconimage")));
            this.btnSaveAs.Iconimage_right = null;
            this.btnSaveAs.Iconimage_right_Selected = null;
            this.btnSaveAs.Iconimage_Selected = null;
            this.btnSaveAs.IconMarginLeft = 0;
            this.btnSaveAs.IconMarginRight = 0;
            this.btnSaveAs.IconRightVisible = true;
            this.btnSaveAs.IconRightZoom = 0D;
            this.btnSaveAs.IconVisible = true;
            this.btnSaveAs.IconZoom = 36D;
            this.btnSaveAs.IsTab = false;
            this.btnSaveAs.Location = new System.Drawing.Point(-6, 243);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSaveAs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnSaveAs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveAs.selected = false;
            this.btnSaveAs.Size = new System.Drawing.Size(221, 48);
            this.btnSaveAs.TabIndex = 1;
            this.btnSaveAs.Text = "         Save as...";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAs.Textcolor = System.Drawing.Color.White;
            this.btnSaveAs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPaste.BackColor = System.Drawing.Color.Transparent;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaste.BorderRadius = 0;
            this.btnPaste.ButtonText = "         Paste";
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.DisabledColor = System.Drawing.Color.Gray;
            this.btnPaste.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPaste.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPaste.Iconimage")));
            this.btnPaste.Iconimage_right = null;
            this.btnPaste.Iconimage_right_Selected = null;
            this.btnPaste.Iconimage_Selected = null;
            this.btnPaste.IconMarginLeft = 0;
            this.btnPaste.IconMarginRight = 0;
            this.btnPaste.IconRightVisible = true;
            this.btnPaste.IconRightZoom = 0D;
            this.btnPaste.IconVisible = true;
            this.btnPaste.IconZoom = 43D;
            this.btnPaste.IsTab = false;
            this.btnPaste.Location = new System.Drawing.Point(-6, 349);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPaste.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnPaste.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPaste.selected = false;
            this.btnPaste.Size = new System.Drawing.Size(221, 48);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "         Paste";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaste.Textcolor = System.Drawing.Color.White;
            this.btnPaste.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.BorderRadius = 0;
            this.btnCopy.ButtonText = "         Copy";
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.DisabledColor = System.Drawing.Color.Gray;
            this.btnCopy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCopy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCopy.Iconimage")));
            this.btnCopy.Iconimage_right = null;
            this.btnCopy.Iconimage_right_Selected = null;
            this.btnCopy.Iconimage_Selected = null;
            this.btnCopy.IconMarginLeft = 0;
            this.btnCopy.IconMarginRight = 0;
            this.btnCopy.IconRightVisible = true;
            this.btnCopy.IconRightZoom = 0D;
            this.btnCopy.IconVisible = true;
            this.btnCopy.IconZoom = 40D;
            this.btnCopy.IsTab = false;
            this.btnCopy.Location = new System.Drawing.Point(-6, 295);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCopy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnCopy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCopy.selected = false;
            this.btnCopy.Size = new System.Drawing.Size(221, 48);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "         Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Textcolor = System.Drawing.Color.White;
            this.btnCopy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "         Save...";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 36D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(-6, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(221, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "         Save...";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.BorderRadius = 0;
            this.btnOpen.ButtonText = "         Open...";
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOpen.Iconimage")));
            this.btnOpen.Iconimage_right = null;
            this.btnOpen.Iconimage_right_Selected = null;
            this.btnOpen.Iconimage_Selected = null;
            this.btnOpen.IconMarginLeft = 0;
            this.btnOpen.IconMarginRight = 0;
            this.btnOpen.IconRightVisible = true;
            this.btnOpen.IconRightZoom = 0D;
            this.btnOpen.IconVisible = true;
            this.btnOpen.IconZoom = 40D;
            this.btnOpen.IsTab = false;
            this.btnOpen.Location = new System.Drawing.Point(-6, 135);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOpen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpen.selected = false;
            this.btnOpen.Size = new System.Drawing.Size(221, 48);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "         Open...";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Textcolor = System.Drawing.Color.White;
            this.btnOpen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.BorderRadius = 0;
            this.btnNew.ButtonText = "         New...";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.DisabledColor = System.Drawing.Color.Gray;
            this.btnNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNew.Iconimage")));
            this.btnNew.Iconimage_right = null;
            this.btnNew.Iconimage_right_Selected = null;
            this.btnNew.Iconimage_Selected = null;
            this.btnNew.IconMarginLeft = 0;
            this.btnNew.IconMarginRight = 0;
            this.btnNew.IconRightVisible = true;
            this.btnNew.IconRightZoom = 0D;
            this.btnNew.IconVisible = true;
            this.btnNew.IconZoom = 40D;
            this.btnNew.IsTab = false;
            this.btnNew.Location = new System.Drawing.Point(-6, 84);
            this.btnNew.Name = "btnNew";
            this.btnNew.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.btnNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNew.selected = false;
            this.btnNew.Size = new System.Drawing.Size(221, 48);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "         New...";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Textcolor = System.Drawing.Color.White;
            this.btnNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(8, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(22, 22);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timeMenuSlider
            // 
            this.timeMenuSlider.Interval = 1;
            this.timeMenuSlider.Tick += new System.EventHandler(this.timeMenuSlider_Tick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(10, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 0;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.pictureBox1);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(56, 32);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSearch.Size = new System.Drawing.Size(40, 57);
            this.pnlSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(60, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 13);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timeSearchSlider
            // 
            this.timeSearchSlider.Interval = 1;
            this.timeSearchSlider.Tick += new System.EventHandler(this.timeSearchSlider_Tick);
            // 
            // pnlText
            // 
            this.pnlText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlText.Controls.Add(this.rtbText);
            this.pnlText.Location = new System.Drawing.Point(66, 110);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(771, 427);
            this.pnlText.TabIndex = 4;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.Control;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(0, 0);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(771, 427);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.Click += new System.EventHandler(this.rTxtText_Click);
            this.rtbText.TextChanged += new System.EventHandler(this.rTxtText_TextChanged);
            this.rtbText.Enter += new System.EventHandler(this.rtbText_Enter);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(385, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(155, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 537);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDrag);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notepad";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.pnlDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimase;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximase;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timeMenuSlider;
        private Bunifu.Framework.UI.BunifuFlatButton btnNew;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpen;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveAs;
        private Bunifu.Framework.UI.BunifuFlatButton btnCut;
        private Bunifu.Framework.UI.BunifuFlatButton btnPaste;
        private Bunifu.Framework.UI.BunifuFlatButton btnCopy;
        private Bunifu.Framework.UI.BunifuFlatButton btnCounter;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timeSearchSlider;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lblResult;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

