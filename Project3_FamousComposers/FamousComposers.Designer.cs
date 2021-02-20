namespace Project3_FamousComposers
{
    partial class FamousComposers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamousComposers));
            this.mnuComposers = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresentStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresentEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresentSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresentSortName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresentSortYear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageSearchName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpComposers = new System.Windows.Forms.ToolTip(this.components);
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lstComposers = new System.Windows.Forms.ListBox();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblCompTitle = new System.Windows.Forms.Label();
            this.lblCompYear = new System.Windows.Forms.Label();
            this.lblCompLocation = new System.Windows.Forms.Label();
            this.lnkLink = new System.Windows.Forms.LinkLabel();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.ofdComposers = new System.Windows.Forms.OpenFileDialog();
            this.pdForm = new System.Drawing.Printing.PrintDocument();
            this.ppdComposers = new System.Windows.Forms.PrintPreviewDialog();
            this.pdSelection = new System.Drawing.Printing.PrintDocument();
            this.mnuComposers.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuComposers
            // 
            this.mnuComposers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuPresent,
            this.mnuManage,
            this.mnuHelp});
            this.mnuComposers.Location = new System.Drawing.Point(0, 0);
            this.mnuComposers.Name = "mnuComposers";
            this.mnuComposers.Size = new System.Drawing.Size(784, 24);
            this.mnuComposers.TabIndex = 0;
            this.mnuComposers.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileLoad,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.ToolTipText = "Create new composer database";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.Size = new System.Drawing.Size(180, 22);
            this.mnuFileLoad.Text = "L&oad";
            this.mnuFileLoad.ToolTipText = "Load existing composer database";
            this.mnuFileLoad.Click += new System.EventHandler(this.mnuFileLoad_Click);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuPresent
            // 
            this.mnuPresent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPresentStart,
            this.mnuPresentEnd,
            this.mnuPresentSort});
            this.mnuPresent.Name = "mnuPresent";
            this.mnuPresent.Size = new System.Drawing.Size(58, 20);
            this.mnuPresent.Text = "P&resent";
            // 
            // mnuPresentStart
            // 
            this.mnuPresentStart.Name = "mnuPresentStart";
            this.mnuPresentStart.Size = new System.Drawing.Size(167, 22);
            this.mnuPresentStart.Text = "Start Presentation";
            this.mnuPresentStart.Click += new System.EventHandler(this.mnuPresentStart_Click);
            // 
            // mnuPresentEnd
            // 
            this.mnuPresentEnd.Name = "mnuPresentEnd";
            this.mnuPresentEnd.Size = new System.Drawing.Size(167, 22);
            this.mnuPresentEnd.Text = "End Presentation";
            this.mnuPresentEnd.Click += new System.EventHandler(this.mnuPresentEnd_Click);
            // 
            // mnuPresentSort
            // 
            this.mnuPresentSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPresentSortName,
            this.mnuPresentSortYear});
            this.mnuPresentSort.Name = "mnuPresentSort";
            this.mnuPresentSort.Size = new System.Drawing.Size(167, 22);
            this.mnuPresentSort.Text = "Sort";
            // 
            // mnuPresentSortName
            // 
            this.mnuPresentSortName.CheckOnClick = true;
            this.mnuPresentSortName.Name = "mnuPresentSortName";
            this.mnuPresentSortName.Size = new System.Drawing.Size(106, 22);
            this.mnuPresentSortName.Text = "Name";
            this.mnuPresentSortName.ToolTipText = "Sort by composer first name";
            this.mnuPresentSortName.Click += new System.EventHandler(this.mnuPresentSortName_Click);
            // 
            // mnuPresentSortYear
            // 
            this.mnuPresentSortYear.CheckOnClick = true;
            this.mnuPresentSortYear.Name = "mnuPresentSortYear";
            this.mnuPresentSortYear.Size = new System.Drawing.Size(106, 22);
            this.mnuPresentSortYear.Text = "Year";
            this.mnuPresentSortYear.ToolTipText = "Sort by composition debut year";
            this.mnuPresentSortYear.Click += new System.EventHandler(this.mnuPresentSortYear_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageAdd,
            this.mnuManageEdit,
            this.mnuManageDelete,
            this.mnuManageSearch});
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(113, 20);
            this.mnuManage.Text = "&Manage Database";
            // 
            // mnuManageAdd
            // 
            this.mnuManageAdd.Name = "mnuManageAdd";
            this.mnuManageAdd.Size = new System.Drawing.Size(180, 22);
            this.mnuManageAdd.Text = "Add";
            this.mnuManageAdd.ToolTipText = "Add new composer to database";
            this.mnuManageAdd.Click += new System.EventHandler(this.mnuManageAdd_Click);
            // 
            // mnuManageEdit
            // 
            this.mnuManageEdit.Name = "mnuManageEdit";
            this.mnuManageEdit.Size = new System.Drawing.Size(180, 22);
            this.mnuManageEdit.Text = "Edit";
            this.mnuManageEdit.ToolTipText = "Edit selected composer";
            this.mnuManageEdit.Click += new System.EventHandler(this.mnuManageEdit_Click);
            // 
            // mnuManageDelete
            // 
            this.mnuManageDelete.Name = "mnuManageDelete";
            this.mnuManageDelete.Size = new System.Drawing.Size(180, 22);
            this.mnuManageDelete.Text = "Delete";
            this.mnuManageDelete.ToolTipText = "Delete selected composer";
            this.mnuManageDelete.Click += new System.EventHandler(this.mnuManageDelete_Click);
            // 
            // mnuManageSearch
            // 
            this.mnuManageSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageSearchName});
            this.mnuManageSearch.Name = "mnuManageSearch";
            this.mnuManageSearch.Size = new System.Drawing.Size(180, 22);
            this.mnuManageSearch.Text = "Search";
            // 
            // mnuManageSearchName
            // 
            this.mnuManageSearchName.Name = "mnuManageSearchName";
            this.mnuManageSearchName.Size = new System.Drawing.Size(180, 22);
            this.mnuManageSearchName.Text = "Name";
            this.mnuManageSearchName.ToolTipText = "Search database by composer name";
            this.mnuManageSearchName.Click += new System.EventHandler(this.mnuManageSearchName_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(13, 40);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(391, 43);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Famous Music Composers";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Linen;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(430, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Composer:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Linen;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(313, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 19);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title of notable composition:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Linen;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(327, 192);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(181, 19);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year composition debuted:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Linen;
            this.lblLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(296, 229);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(212, 19);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location of debut performance:";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.BackColor = System.Drawing.Color.Linen;
            this.lblSynopsis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsis.Location = new System.Drawing.Point(439, 264);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(69, 19);
            this.lblSynopsis.TabIndex = 6;
            this.lblSynopsis.Text = "Synopsis:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.BackColor = System.Drawing.Color.Linen;
            this.lblLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(355, 359);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(153, 19);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Link to YouTube video:";
            // 
            // lstComposers
            // 
            this.lstComposers.BackColor = System.Drawing.Color.Linen;
            this.lstComposers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComposers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComposers.FormattingEnabled = true;
            this.lstComposers.ItemHeight = 19;
            this.lstComposers.Location = new System.Drawing.Point(26, 110);
            this.lstComposers.Name = "lstComposers";
            this.lstComposers.Size = new System.Drawing.Size(227, 268);
            this.lstComposers.TabIndex = 8;
            this.lstComposers.SelectedIndexChanged += new System.EventHandler(this.lstComposers_SelectedIndexChanged);
            this.lstComposers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstComposers_MouseDoubleClick);
            // 
            // lblCompName
            // 
            this.lblCompName.BackColor = System.Drawing.Color.Linen;
            this.lblCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.Location = new System.Drawing.Point(520, 112);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(239, 27);
            this.lblCompName.TabIndex = 9;
            this.lblCompName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompTitle
            // 
            this.lblCompTitle.BackColor = System.Drawing.Color.Linen;
            this.lblCompTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompTitle.Location = new System.Drawing.Point(520, 151);
            this.lblCompTitle.Name = "lblCompTitle";
            this.lblCompTitle.Size = new System.Drawing.Size(239, 27);
            this.lblCompTitle.TabIndex = 10;
            this.lblCompTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompYear
            // 
            this.lblCompYear.BackColor = System.Drawing.Color.Linen;
            this.lblCompYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompYear.Location = new System.Drawing.Point(520, 188);
            this.lblCompYear.Name = "lblCompYear";
            this.lblCompYear.Size = new System.Drawing.Size(239, 27);
            this.lblCompYear.TabIndex = 11;
            this.lblCompYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompLocation
            // 
            this.lblCompLocation.BackColor = System.Drawing.Color.Linen;
            this.lblCompLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompLocation.Location = new System.Drawing.Point(520, 225);
            this.lblCompLocation.Name = "lblCompLocation";
            this.lblCompLocation.Size = new System.Drawing.Size(239, 27);
            this.lblCompLocation.TabIndex = 12;
            this.lblCompLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkLink
            // 
            this.lnkLink.ActiveLinkColor = System.Drawing.Color.DarkOliveGreen;
            this.lnkLink.BackColor = System.Drawing.Color.Linen;
            this.lnkLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLink.LinkColor = System.Drawing.Color.Black;
            this.lnkLink.Location = new System.Drawing.Point(520, 355);
            this.lnkLink.Name = "lnkLink";
            this.lnkLink.Size = new System.Drawing.Size(239, 27);
            this.lnkLink.TabIndex = 14;
            this.lnkLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLink_LinkClicked);
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.BackColor = System.Drawing.Color.Linen;
            this.txtSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSynopsis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSynopsis.Location = new System.Drawing.Point(520, 262);
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.ReadOnly = true;
            this.txtSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSynopsis.Size = new System.Drawing.Size(239, 83);
            this.txtSynopsis.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(26, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 30);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(178, 443);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 30);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(330, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 30);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresent.Location = new System.Drawing.Point(482, 443);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(125, 30);
            this.btnPresent.TabIndex = 19;
            this.btnPresent.Text = "&Start Presentation";
            this.btnPresent.UseVisualStyleBackColor = false;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(634, 443);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(125, 30);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // ofdComposers
            // 
            this.ofdComposers.FileName = "openFileDialog1";
            // 
            // pdForm
            // 
            this.pdForm.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdForm_PrintPage);
            // 
            // ppdComposers
            // 
            this.ppdComposers.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdComposers.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdComposers.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdComposers.Enabled = true;
            this.ppdComposers.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdComposers.Icon")));
            this.ppdComposers.Name = "ppdComposers";
            this.ppdComposers.Visible = false;
            // 
            // pdSelection
            // 
            this.pdSelection.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdSelection_PrintPage);
            // 
            // FamousComposers
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project3_FamousComposers.Properties.Resources.shutterstock_558325894;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(784, 494);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.lnkLink);
            this.Controls.Add(this.lblCompLocation);
            this.Controls.Add(this.lblCompYear);
            this.Controls.Add(this.lblCompTitle);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.lstComposers);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.mnuComposers);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuComposers;
            this.MaximizeBox = false;
            this.Name = "FamousComposers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Famous Music Composers";
            this.mnuComposers.ResumeLayout(false);
            this.mnuComposers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuComposers;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuPresent;
        private System.Windows.Forms.ToolStripMenuItem mnuPresentStart;
        private System.Windows.Forms.ToolStripMenuItem mnuPresentEnd;
        private System.Windows.Forms.ToolStripMenuItem mnuPresentSort;
        private System.Windows.Forms.ToolStripMenuItem mnuPresentSortName;
        private System.Windows.Forms.ToolStripMenuItem mnuPresentSortYear;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuManageAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuManageEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuManageDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolTip ttpComposers;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.ListBox lstComposers;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblCompTitle;
        private System.Windows.Forms.Label lblCompYear;
        private System.Windows.Forms.Label lblCompLocation;
        private System.Windows.Forms.LinkLabel lnkLink;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.OpenFileDialog ofdComposers;
        private System.Windows.Forms.ToolStripMenuItem mnuManageSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuManageSearchName;
        private System.Drawing.Printing.PrintDocument pdForm;
        private System.Windows.Forms.PrintPreviewDialog ppdComposers;
        private System.Drawing.Printing.PrintDocument pdSelection;
    }
}

