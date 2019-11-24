
namespace Final_Project
{
    partial class frmBookCDDVDShop
    {

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
        internal void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookCDDVDShop));
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateCDOrchestra = new System.Windows.Forms.Button();
            this.btnCreateCDChamber = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.txtProductUPC = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtBookCISCISArea = new System.Windows.Forms.ComboBox();
            this.lblCIS = new System.Windows.Forms.Label();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBookISBNRight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookISBNLeft = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.grpDVD = new System.Windows.Forms.GroupBox();
            this.txtDVDReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtDVDRunTime = new System.Windows.Forms.TextBox();
            this.txtDVDLeadActor = new System.Windows.Forms.TextBox();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblLeadActor = new System.Windows.Forms.Label();
            this.grpCDClassical = new System.Windows.Forms.GroupBox();
            this.txtCDChamberInstrumentList = new System.Windows.Forms.TextBox();
            this.txtCDOrchestraConductor = new System.Windows.Forms.TextBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblOrchestraMusic = new System.Windows.Forms.Label();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.lblCDChamber = new System.Windows.Forms.Label();
            this.txtCDClassicalArtists = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtCDClassicalLabel = new System.Windows.Forms.TextBox();
            this.lblLabe = new System.Windows.Forms.Label();
            this.btnSearchUPC = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductUPCSearch = new System.Windows.Forms.TextBox();
            this.toolTipHints = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProgTitle = new System.Windows.Forms.Label();
            this.lblInstruct1 = new System.Windows.Forms.Label();
            this.lblInstruct2 = new System.Windows.Forms.Label();
            this.grpProduct.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpDVD.SuspendLayout();
            this.grpCDClassical.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.BackgroundImage = global::Final_Project.Properties.Resources.black_red_metal_background_71775_391;
            this.btnCreateBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateBook.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateBook.Location = new System.Drawing.Point(31, 173);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(132, 57);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.BtnCreateBook_Click);
            // 
            // btnCreateBookCIS
            // 
            this.btnCreateBookCIS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateBookCIS.BackgroundImage")));
            this.btnCreateBookCIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateBookCIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateBookCIS.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBookCIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateBookCIS.Location = new System.Drawing.Point(31, 262);
            this.btnCreateBookCIS.Name = "btnCreateBookCIS";
            this.btnCreateBookCIS.Size = new System.Drawing.Size(132, 64);
            this.btnCreateBookCIS.TabIndex = 1;
            this.btnCreateBookCIS.Text = "Create CIS Book";
            this.btnCreateBookCIS.UseVisualStyleBackColor = true;
            this.btnCreateBookCIS.Click += new System.EventHandler(this.BtnCreateBookCIS_Click);
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateDVD.BackgroundImage")));
            this.btnCreateDVD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateDVD.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateDVD.Location = new System.Drawing.Point(31, 351);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(132, 67);
            this.btnCreateDVD.TabIndex = 2;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            this.btnCreateDVD.Click += new System.EventHandler(this.BtnCreateDVD_Click);
            // 
            // btnCreateCDOrchestra
            // 
            this.btnCreateCDOrchestra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateCDOrchestra.BackgroundImage")));
            this.btnCreateCDOrchestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateCDOrchestra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateCDOrchestra.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCDOrchestra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateCDOrchestra.Location = new System.Drawing.Point(31, 436);
            this.btnCreateCDOrchestra.Name = "btnCreateCDOrchestra";
            this.btnCreateCDOrchestra.Size = new System.Drawing.Size(132, 68);
            this.btnCreateCDOrchestra.TabIndex = 3;
            this.btnCreateCDOrchestra.Text = "Create CD Orchestra";
            this.btnCreateCDOrchestra.UseVisualStyleBackColor = true;
            this.btnCreateCDOrchestra.Click += new System.EventHandler(this.BtnCreateCDOrchestra_Click);
            // 
            // btnCreateCDChamber
            // 
            this.btnCreateCDChamber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateCDChamber.BackgroundImage")));
            this.btnCreateCDChamber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateCDChamber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateCDChamber.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCDChamber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateCDChamber.Location = new System.Drawing.Point(31, 530);
            this.btnCreateCDChamber.Name = "btnCreateCDChamber";
            this.btnCreateCDChamber.Size = new System.Drawing.Size(132, 64);
            this.btnCreateCDChamber.TabIndex = 4;
            this.btnCreateCDChamber.Text = "Create CD Chamber";
            this.btnCreateCDChamber.UseVisualStyleBackColor = true;
            this.btnCreateCDChamber.Click += new System.EventHandler(this.BtnCreateCDChamber_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.BackColor = System.Drawing.Color.Transparent;
            this.grpProduct.Controls.Add(this.lblPrice);
            this.grpProduct.Controls.Add(this.txtProductQuantity);
            this.grpProduct.Controls.Add(this.txtProductTitle);
            this.grpProduct.Controls.Add(this.txtProductUPC);
            this.grpProduct.Controls.Add(this.lblTitle);
            this.grpProduct.Controls.Add(this.lblQuantity);
            this.grpProduct.Controls.Add(this.lblUPC);
            this.grpProduct.Controls.Add(this.txtProductPrice);
            this.grpProduct.Enabled = false;
            this.grpProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpProduct.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduct.ForeColor = System.Drawing.Color.Coral;
            this.grpProduct.Location = new System.Drawing.Point(236, 112);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(0);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(997, 96);
            this.grpProduct.TabIndex = 11;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            this.grpProduct.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(250, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(893, 36);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(51, 32);
            this.txtProductQuantity.TabIndex = 8;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Location = new System.Drawing.Point(538, 33);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(258, 32);
            this.txtProductTitle.TabIndex = 7;
            // 
            // txtProductUPC
            // 
            this.txtProductUPC.Location = new System.Drawing.Point(87, 33);
            this.txtProductUPC.Name = "txtProductUPC";
            this.txtProductUPC.Size = new System.Drawing.Size(141, 32);
            this.txtProductUPC.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(462, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 21);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(812, 39);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 21);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(36, 36);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(45, 21);
            this.lblUPC.TabIndex = 0;
            this.lblUPC.Text = "UPC";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(301, 33);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(141, 32);
            this.txtProductPrice.TabIndex = 6;
            // 
            // grpBook
            // 
            this.grpBook.BackColor = System.Drawing.Color.Transparent;
            this.grpBook.Controls.Add(this.txtBookCISCISArea);
            this.grpBook.Controls.Add(this.lblCIS);
            this.grpBook.Controls.Add(this.txtBookPages);
            this.grpBook.Controls.Add(this.lblPages);
            this.grpBook.Controls.Add(this.txtBookAuthor);
            this.grpBook.Controls.Add(this.lblAuthor);
            this.grpBook.Controls.Add(this.txtBookISBNRight);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Controls.Add(this.txtBookISBNLeft);
            this.grpBook.Controls.Add(this.lblISBN);
            this.grpBook.Enabled = false;
            this.grpBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBook.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBook.ForeColor = System.Drawing.Color.Coral;
            this.grpBook.Location = new System.Drawing.Point(236, 214);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(997, 96);
            this.grpBook.TabIndex = 12;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            this.grpBook.Visible = false;
            // 
            // txtBookCISCISArea
            // 
            this.txtBookCISCISArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBookCISCISArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBookCISCISArea.Enabled = false;
            this.txtBookCISCISArea.FormattingEnabled = true;
            this.txtBookCISCISArea.Items.AddRange(new object[] {
            "Networking",
            "Software Design",
            "Operating System",
            "Java",
            "Python",
            "Other"});
            this.txtBookCISCISArea.Location = new System.Drawing.Point(771, 41);
            this.txtBookCISCISArea.Name = "txtBookCISCISArea";
            this.txtBookCISCISArea.Size = new System.Drawing.Size(220, 28);
            this.txtBookCISCISArea.TabIndex = 16;
            this.txtBookCISCISArea.Visible = false;
            // 
            // lblCIS
            // 
            this.lblCIS.AutoSize = true;
            this.lblCIS.Enabled = false;
            this.lblCIS.Location = new System.Drawing.Point(793, 18);
            this.lblCIS.Name = "lblCIS";
            this.lblCIS.Size = new System.Drawing.Size(133, 21);
            this.lblCIS.TabIndex = 15;
            this.lblCIS.Text = "CIS Book Area";
            this.lblCIS.Visible = false;
            // 
            // txtBookPages
            // 
            this.txtBookPages.Location = new System.Drawing.Point(653, 43);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(51, 32);
            this.txtBookPages.TabIndex = 14;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(586, 45);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(58, 21);
            this.lblPages.TabIndex = 13;
            this.lblPages.Text = "Pages";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(322, 37);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(258, 32);
            this.txtBookAuthor.TabIndex = 9;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(236, 48);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(67, 21);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author";
            // 
            // txtBookISBNRight
            // 
            this.txtBookISBNRight.Location = new System.Drawing.Point(158, 45);
            this.txtBookISBNRight.Name = "txtBookISBNRight";
            this.txtBookISBNRight.Size = new System.Drawing.Size(55, 32);
            this.txtBookISBNRight.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "--";
            // 
            // txtBookISBNLeft
            // 
            this.txtBookISBNLeft.Location = new System.Drawing.Point(87, 43);
            this.txtBookISBNLeft.Name = "txtBookISBNLeft";
            this.txtBookISBNLeft.Size = new System.Drawing.Size(55, 32);
            this.txtBookISBNLeft.TabIndex = 9;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(23, 48);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(58, 21);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN";
            // 
            // grpDVD
            // 
            this.grpDVD.BackColor = System.Drawing.Color.Transparent;
            this.grpDVD.Controls.Add(this.txtDVDReleaseDate);
            this.grpDVD.Controls.Add(this.txtDVDRunTime);
            this.grpDVD.Controls.Add(this.txtDVDLeadActor);
            this.grpDVD.Controls.Add(this.lblRunTime);
            this.grpDVD.Controls.Add(this.lblReleaseDate);
            this.grpDVD.Controls.Add(this.lblLeadActor);
            this.grpDVD.Enabled = false;
            this.grpDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDVD.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDVD.ForeColor = System.Drawing.Color.Coral;
            this.grpDVD.Location = new System.Drawing.Point(236, 322);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Size = new System.Drawing.Size(997, 96);
            this.grpDVD.TabIndex = 12;
            this.grpDVD.TabStop = false;
            this.grpDVD.Text = "DVD";
            this.grpDVD.Visible = false;
            // 
            // txtDVDReleaseDate
            // 
            this.txtDVDReleaseDate.Location = new System.Drawing.Point(466, 43);
            this.txtDVDReleaseDate.Name = "txtDVDReleaseDate";
            this.txtDVDReleaseDate.Size = new System.Drawing.Size(271, 32);
            this.txtDVDReleaseDate.TabIndex = 14;
            // 
            // txtDVDRunTime
            // 
            this.txtDVDRunTime.Location = new System.Drawing.Point(903, 40);
            this.txtDVDRunTime.Name = "txtDVDRunTime";
            this.txtDVDRunTime.Size = new System.Drawing.Size(62, 32);
            this.txtDVDRunTime.TabIndex = 13;
            // 
            // txtDVDLeadActor
            // 
            this.txtDVDLeadActor.Location = new System.Drawing.Point(119, 45);
            this.txtDVDLeadActor.Name = "txtDVDLeadActor";
            this.txtDVDLeadActor.Size = new System.Drawing.Size(203, 32);
            this.txtDVDLeadActor.TabIndex = 11;
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Location = new System.Drawing.Point(777, 43);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(84, 21);
            this.lblRunTime.TabIndex = 10;
            this.lblRunTime.Text = "Run Time";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(343, 51);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(117, 21);
            this.lblReleaseDate.TabIndex = 9;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblLeadActor
            // 
            this.lblLeadActor.AutoSize = true;
            this.lblLeadActor.Location = new System.Drawing.Point(18, 48);
            this.lblLeadActor.Name = "lblLeadActor";
            this.lblLeadActor.Size = new System.Drawing.Size(95, 21);
            this.lblLeadActor.TabIndex = 8;
            this.lblLeadActor.Text = "Lead Actor";
            // 
            // grpCDClassical
            // 
            this.grpCDClassical.BackColor = System.Drawing.Color.Transparent;
            this.grpCDClassical.Controls.Add(this.txtCDChamberInstrumentList);
            this.grpCDClassical.Controls.Add(this.txtCDOrchestraConductor);
            this.grpCDClassical.Controls.Add(this.lblConductor);
            this.grpCDClassical.Controls.Add(this.lblOrchestraMusic);
            this.grpCDClassical.Controls.Add(this.lblInstrument);
            this.grpCDClassical.Controls.Add(this.lblCDChamber);
            this.grpCDClassical.Controls.Add(this.txtCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.lblArtist);
            this.grpCDClassical.Controls.Add(this.txtCDClassicalLabel);
            this.grpCDClassical.Controls.Add(this.lblLabe);
            this.grpCDClassical.Enabled = false;
            this.grpCDClassical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpCDClassical.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCDClassical.ForeColor = System.Drawing.Color.Coral;
            this.grpCDClassical.Location = new System.Drawing.Point(236, 436);
            this.grpCDClassical.Name = "grpCDClassical";
            this.grpCDClassical.Size = new System.Drawing.Size(997, 209);
            this.grpCDClassical.TabIndex = 13;
            this.grpCDClassical.TabStop = false;
            this.grpCDClassical.Text = "CD Classical";
            this.grpCDClassical.Visible = false;
            // 
            // txtCDChamberInstrumentList
            // 
            this.txtCDChamberInstrumentList.Enabled = false;
            this.txtCDChamberInstrumentList.Location = new System.Drawing.Point(548, 126);
            this.txtCDChamberInstrumentList.Name = "txtCDChamberInstrumentList";
            this.txtCDChamberInstrumentList.Size = new System.Drawing.Size(248, 32);
            this.txtCDChamberInstrumentList.TabIndex = 28;
            this.txtCDChamberInstrumentList.Visible = false;
            // 
            // txtCDOrchestraConductor
            // 
            this.txtCDOrchestraConductor.Enabled = false;
            this.txtCDOrchestraConductor.Location = new System.Drawing.Point(192, 126);
            this.txtCDOrchestraConductor.Name = "txtCDOrchestraConductor";
            this.txtCDOrchestraConductor.Size = new System.Drawing.Size(141, 32);
            this.txtCDOrchestraConductor.TabIndex = 27;
            this.txtCDOrchestraConductor.Visible = false;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Enabled = false;
            this.lblConductor.Location = new System.Drawing.Point(83, 130);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(93, 21);
            this.lblConductor.TabIndex = 26;
            this.lblConductor.Text = "Conductor";
            this.lblConductor.Visible = false;
            // 
            // lblOrchestraMusic
            // 
            this.lblOrchestraMusic.AutoSize = true;
            this.lblOrchestraMusic.Enabled = false;
            this.lblOrchestraMusic.Location = new System.Drawing.Point(155, 94);
            this.lblOrchestraMusic.Name = "lblOrchestraMusic";
            this.lblOrchestraMusic.Size = new System.Drawing.Size(142, 21);
            this.lblOrchestraMusic.TabIndex = 24;
            this.lblOrchestraMusic.Text = "Orchestra Music";
            this.lblOrchestraMusic.Visible = false;
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Enabled = false;
            this.lblInstrument.Location = new System.Drawing.Point(429, 129);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(103, 21);
            this.lblInstrument.TabIndex = 23;
            this.lblInstrument.Text = "Instrument";
            this.lblInstrument.Visible = false;
            // 
            // lblCDChamber
            // 
            this.lblCDChamber.AutoSize = true;
            this.lblCDChamber.Enabled = false;
            this.lblCDChamber.Location = new System.Drawing.Point(555, 94);
            this.lblCDChamber.Name = "lblCDChamber";
            this.lblCDChamber.Size = new System.Drawing.Size(137, 21);
            this.lblCDChamber.TabIndex = 21;
            this.lblCDChamber.Text = "Chamber Music";
            this.lblCDChamber.Visible = false;
            // 
            // txtCDClassicalArtists
            // 
            this.txtCDClassicalArtists.Location = new System.Drawing.Point(513, 47);
            this.txtCDClassicalArtists.Name = "txtCDClassicalArtists";
            this.txtCDClassicalArtists.Size = new System.Drawing.Size(248, 32);
            this.txtCDClassicalArtists.TabIndex = 20;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(457, 47);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(58, 21);
            this.lblArtist.TabIndex = 19;
            this.lblArtist.Text = "Artist";
            // 
            // txtCDClassicalLabel
            // 
            this.txtCDClassicalLabel.Location = new System.Drawing.Point(119, 42);
            this.txtCDClassicalLabel.Name = "txtCDClassicalLabel";
            this.txtCDClassicalLabel.Size = new System.Drawing.Size(258, 32);
            this.txtCDClassicalLabel.TabIndex = 17;
            // 
            // lblLabe
            // 
            this.lblLabe.AutoSize = true;
            this.lblLabe.Location = new System.Drawing.Point(59, 47);
            this.lblLabe.Name = "lblLabe";
            this.lblLabe.Size = new System.Drawing.Size(53, 21);
            this.lblLabe.TabIndex = 18;
            this.lblLabe.Text = "Label";
            // 
            // btnSearchUPC
            // 
            this.btnSearchUPC.BackgroundImage = global::Final_Project.Properties.Resources.black_red_metal_background_71775_391;
            this.btnSearchUPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchUPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchUPC.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearchUPC.Location = new System.Drawing.Point(1301, 14);
            this.btnSearchUPC.Name = "btnSearchUPC";
            this.btnSearchUPC.Size = new System.Drawing.Size(92, 49);
            this.btnSearchUPC.TabIndex = 14;
            this.btnSearchUPC.Text = "Search UPC";
            this.btnSearchUPC.UseVisualStyleBackColor = true;
            this.btnSearchUPC.Click += new System.EventHandler(this.BtnSearchUPC_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(490, 670);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 50);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(848, 670);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(669, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtProductUPCSearch
            // 
            this.txtProductUPCSearch.Location = new System.Drawing.Point(1139, 27);
            this.txtProductUPCSearch.Name = "txtProductUPCSearch";
            this.txtProductUPCSearch.Size = new System.Drawing.Size(141, 22);
            this.txtProductUPCSearch.TabIndex = 10;
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearForm.BackgroundImage")));
            this.btnClearForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearForm.Enabled = false;
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearForm.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearForm.Location = new System.Drawing.Point(1288, 219);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(117, 50);
            this.btnClearForm.TabIndex = 18;
            this.btnClearForm.Text = "Clear Fields";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Visible = false;
            this.btnClearForm.Click += new System.EventHandler(this.BtnClearForm_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetForm.BackgroundImage")));
            this.btnResetForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetForm.Enabled = false;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetForm.Location = new System.Drawing.Point(1288, 297);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(117, 50);
            this.btnResetForm.TabIndex = 19;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Visible = false;
            this.btnResetForm.Click += new System.EventHandler(this.BtnResetForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Forte", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1288, 670);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 50);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblProgTitle
            // 
            this.lblProgTitle.AutoSize = true;
            this.lblProgTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProgTitle.Font = new System.Drawing.Font("Forte", 20F);
            this.lblProgTitle.ForeColor = System.Drawing.Color.Coral;
            this.lblProgTitle.Location = new System.Drawing.Point(596, 15);
            this.lblProgTitle.Name = "lblProgTitle";
            this.lblProgTitle.Size = new System.Drawing.Size(324, 37);
            this.lblProgTitle.TabIndex = 11;
            this.lblProgTitle.Text = "Book, CD, DVD Shop!";
            // 
            // lblInstruct1
            // 
            this.lblInstruct1.AutoSize = true;
            this.lblInstruct1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruct1.Font = new System.Drawing.Font("Forte", 13F);
            this.lblInstruct1.ForeColor = System.Drawing.Color.Coral;
            this.lblInstruct1.Location = new System.Drawing.Point(579, 50);
            this.lblInstruct1.Name = "lblInstruct1";
            this.lblInstruct1.Size = new System.Drawing.Size(351, 24);
            this.lblInstruct1.TabIndex = 22;
            this.lblInstruct1.Text = "Click buttons on left to create items.";
            // 
            // lblInstruct2
            // 
            this.lblInstruct2.AutoSize = true;
            this.lblInstruct2.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruct2.Font = new System.Drawing.Font("Forte", 13F);
            this.lblInstruct2.ForeColor = System.Drawing.Color.Coral;
            this.lblInstruct2.Location = new System.Drawing.Point(544, 74);
            this.lblInstruct2.Name = "lblInstruct2";
            this.lblInstruct2.Size = new System.Drawing.Size(433, 24);
            this.lblInstruct2.TabIndex = 23;
            this.lblInstruct2.Text = "First search to the right to update and delete.";
            // 
            // frmBookCDDVDShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.OLO2EG0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 827);
            this.Controls.Add(this.lblInstruct2);
            this.Controls.Add(this.lblInstruct1);
            this.Controls.Add(this.lblProgTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.txtProductUPCSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearchUPC);
            this.Controls.Add(this.grpCDClassical);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpDVD);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.btnCreateCDChamber);
            this.Controls.Add(this.btnCreateCDOrchestra);
            this.Controls.Add(this.btnCreateDVD);
            this.Controls.Add(this.btnCreateBookCIS);
            this.Controls.Add(this.btnCreateBook);
            this.Name = "frmBookCDDVDShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOK CD DVD";
            this.Load += new System.EventHandler(this.FrmBookCDDVDShop_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.grpCDClassical.ResumeLayout(false);
            this.grpCDClassical.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCreateBook;
        internal System.Windows.Forms.Button btnCreateBookCIS;
        internal System.Windows.Forms.Button btnCreateDVD;
        internal System.Windows.Forms.Button btnCreateCDOrchestra;
        internal System.Windows.Forms.Button btnCreateCDChamber;
        internal System.Windows.Forms.GroupBox grpProduct;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.Label lblUPC;
        internal System.Windows.Forms.GroupBox grpBook;
        internal System.Windows.Forms.GroupBox grpDVD;
        internal System.Windows.Forms.GroupBox grpCDClassical;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.TextBox txtProductQuantity;
        internal System.Windows.Forms.TextBox txtProductTitle;
        internal System.Windows.Forms.TextBox txtProductPrice;
        internal System.Windows.Forms.TextBox txtProductUPC;
        internal System.Windows.Forms.ComboBox txtBookCISCISArea;
        internal System.Windows.Forms.Label lblCIS;
        internal System.Windows.Forms.TextBox txtBookPages;
        internal System.Windows.Forms.Label lblPages;
        internal System.Windows.Forms.TextBox txtBookAuthor;
        internal System.Windows.Forms.Label lblAuthor;
        internal System.Windows.Forms.TextBox txtBookISBNRight;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtBookISBNLeft;
        internal System.Windows.Forms.Label lblISBN;
        internal System.Windows.Forms.TextBox txtDVDRunTime;
        internal System.Windows.Forms.TextBox txtDVDLeadActor;
        internal System.Windows.Forms.Label lblRunTime;
        internal System.Windows.Forms.Label lblReleaseDate;
        internal System.Windows.Forms.Label lblLeadActor;
        internal System.Windows.Forms.Label lblCDChamber;
        internal System.Windows.Forms.TextBox txtCDClassicalArtists;
        internal System.Windows.Forms.Label lblArtist;
        internal System.Windows.Forms.TextBox txtCDClassicalLabel;
        internal System.Windows.Forms.Label lblLabe;
        internal System.Windows.Forms.TextBox txtCDOrchestraConductor;
        internal System.Windows.Forms.Label lblConductor;
        internal System.Windows.Forms.Label lblOrchestraMusic;
        internal System.Windows.Forms.Label lblInstrument;
        internal System.Windows.Forms.Button btnSearchUPC;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.TextBox txtProductUPCSearch;
        internal System.Windows.Forms.ToolTip toolTipHints;
        private System.ComponentModel.IContainer components;
        internal System.Windows.Forms.Button btnClearForm;
        internal System.Windows.Forms.Button btnResetForm;
        internal System.Windows.Forms.DateTimePicker txtDVDReleaseDate;
        internal System.Windows.Forms.TextBox txtCDChamberInstrumentList;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label lblProgTitle;
        internal System.Windows.Forms.Label lblInstruct1;
        internal System.Windows.Forms.Label lblInstruct2;
    }
}

