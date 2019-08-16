namespace COMP123_S2019_A5_301041985.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SperateLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FinishButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ConditiontextBox = new System.Windows.Forms.TextBox();
            this.PlatformtextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabeltextBox = new System.Windows.Forms.TextBox();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.OStextBox = new System.Windows.Forms.TextBox();
            this.CPUspeedtextBox = new System.Windows.Forms.TextBox();
            this.GPUTypetextBox = new System.Windows.Forms.TextBox();
            this.HDDtextBox = new System.Windows.Forms.TextBox();
            this.WebCamTextbox = new System.Windows.Forms.TextBox();
            this.CPUnumbertextBox = new System.Windows.Forms.TextBox();
            this.CPUtypetextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandtextBox = new System.Windows.Forms.TextBox();
            this.LCDsizetextBox = new System.Windows.Forms.TextBox();
            this.MemorytextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.TaxtextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.OrderMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(878, 31);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(575, 532);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 50);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OStextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.MemorytextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUspeedtextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDsizetextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypetextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandtextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDtextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUtypetextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamTextbox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUnumbertextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ModeltextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabeltextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformtextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditiontextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.shapeContainer2);
            this.SystemComponentsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(3, 44);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(487, 462);
            this.SystemComponentsGroupBox.TabIndex = 6;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(13, 126);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(100, 24);
            this.LCDSizeLabel.TabIndex = 31;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(13, 364);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(95, 24);
            this.WebCamLabel.TabIndex = 26;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(13, 334);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(107, 24);
            this.GPUTypeLabel.TabIndex = 25;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(13, 304);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(58, 24);
            this.HDDLabel.TabIndex = 24;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(13, 274);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(115, 24);
            this.CPUSpeedLabel.TabIndex = 23;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(13, 244);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(134, 24);
            this.CPUNumberLabel.TabIndex = 22;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(13, 214);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(106, 24);
            this.CPUTypeLabel.TabIndex = 19;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(13, 184);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(115, 24);
            this.CPUBrandLabel.TabIndex = 18;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(13, 154);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(88, 24);
            this.MemoryLabel.TabIndex = 17;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(13, 394);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(39, 24);
            this.OSLabel.TabIndex = 20;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(217, 30);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(90, 24);
            this.PlatformLabel.TabIndex = 10;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(217, 77);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(68, 24);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 77);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(133, 24);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(8, 30);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(98, 24);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 32);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SperateLine});
            this.shapeContainer2.Size = new System.Drawing.Size(481, 427);
            this.shapeContainer2.TabIndex = 12;
            this.shapeContainer2.TabStop = false;
            // 
            // SperateLine
            // 
            this.SperateLine.BorderColor = System.Drawing.Color.White;
            this.SperateLine.BorderWidth = 3;
            this.SperateLine.Name = "SperateLine";
            this.SperateLine.X1 = 4;
            this.SperateLine.X2 = 398;
            this.SperateLine.Y1 = 92;
            this.SperateLine.Y2 = 92;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotaltextBox);
            this.PriceGroupBox.Controls.Add(this.TaxtextBox);
            this.PriceGroupBox.Controls.Add(this.PricetextBox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.TaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.shapeContainer3);
            this.PriceGroupBox.Location = new System.Drawing.Point(512, 249);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(343, 213);
            this.PriceGroupBox.TabIndex = 32;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(13, 155);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(73, 29);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(13, 90);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(205, 29);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Sales Tax (13%)";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(13, 38);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(74, 29);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 32);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(337, 178);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "TotalLine";
            this.lineShape1.X1 = 4;
            this.lineShape1.X2 = 335;
            this.lineShape1.Y1 = 112;
            this.lineShape1.Y2 = 112;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(746, 532);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(120, 50);
            this.FinishButton.TabIndex = 33;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(426, 532);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 50);
            this.BackButton.TabIndex = 34;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // ConditiontextBox
            // 
            this.ConditiontextBox.Location = new System.Drawing.Point(112, 30);
            this.ConditiontextBox.Name = "ConditiontextBox";
            this.ConditiontextBox.ReadOnly = true;
            this.ConditiontextBox.Size = new System.Drawing.Size(100, 36);
            this.ConditiontextBox.TabIndex = 20;
            // 
            // PlatformtextBox
            // 
            this.PlatformtextBox.Location = new System.Drawing.Point(308, 27);
            this.PlatformtextBox.Name = "PlatformtextBox";
            this.PlatformtextBox.ReadOnly = true;
            this.PlatformtextBox.Size = new System.Drawing.Size(100, 36);
            this.PlatformtextBox.TabIndex = 35;
            // 
            // ManufacturerLabeltextBox
            // 
            this.ManufacturerLabeltextBox.Location = new System.Drawing.Point(112, 74);
            this.ManufacturerLabeltextBox.Name = "ManufacturerLabeltextBox";
            this.ManufacturerLabeltextBox.ReadOnly = true;
            this.ManufacturerLabeltextBox.Size = new System.Drawing.Size(100, 36);
            this.ManufacturerLabeltextBox.TabIndex = 35;
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Location = new System.Drawing.Point(308, 74);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.ReadOnly = true;
            this.ModeltextBox.Size = new System.Drawing.Size(100, 36);
            this.ModeltextBox.TabIndex = 36;
            // 
            // OStextBox
            // 
            this.OStextBox.Location = new System.Drawing.Point(140, 391);
            this.OStextBox.Name = "OStextBox";
            this.OStextBox.ReadOnly = true;
            this.OStextBox.Size = new System.Drawing.Size(268, 36);
            this.OStextBox.TabIndex = 44;
            // 
            // CPUspeedtextBox
            // 
            this.CPUspeedtextBox.Location = new System.Drawing.Point(140, 271);
            this.CPUspeedtextBox.Name = "CPUspeedtextBox";
            this.CPUspeedtextBox.ReadOnly = true;
            this.CPUspeedtextBox.Size = new System.Drawing.Size(268, 36);
            this.CPUspeedtextBox.TabIndex = 40;
            // 
            // GPUTypetextBox
            // 
            this.GPUTypetextBox.Location = new System.Drawing.Point(140, 331);
            this.GPUTypetextBox.Name = "GPUTypetextBox";
            this.GPUTypetextBox.ReadOnly = true;
            this.GPUTypetextBox.Size = new System.Drawing.Size(268, 36);
            this.GPUTypetextBox.TabIndex = 42;
            // 
            // HDDtextBox
            // 
            this.HDDtextBox.Location = new System.Drawing.Point(140, 301);
            this.HDDtextBox.Name = "HDDtextBox";
            this.HDDtextBox.ReadOnly = true;
            this.HDDtextBox.Size = new System.Drawing.Size(268, 36);
            this.HDDtextBox.TabIndex = 41;
            // 
            // WebCamTextbox
            // 
            this.WebCamTextbox.Location = new System.Drawing.Point(140, 355);
            this.WebCamTextbox.Name = "WebCamTextbox";
            this.WebCamTextbox.ReadOnly = true;
            this.WebCamTextbox.Size = new System.Drawing.Size(268, 36);
            this.WebCamTextbox.TabIndex = 43;
            // 
            // CPUnumbertextBox
            // 
            this.CPUnumbertextBox.Location = new System.Drawing.Point(140, 241);
            this.CPUnumbertextBox.Name = "CPUnumbertextBox";
            this.CPUnumbertextBox.ReadOnly = true;
            this.CPUnumbertextBox.Size = new System.Drawing.Size(268, 36);
            this.CPUnumbertextBox.TabIndex = 39;
            // 
            // CPUtypetextBox
            // 
            this.CPUtypetextBox.Location = new System.Drawing.Point(140, 211);
            this.CPUtypetextBox.Name = "CPUtypetextBox";
            this.CPUtypetextBox.ReadOnly = true;
            this.CPUtypetextBox.Size = new System.Drawing.Size(268, 36);
            this.CPUtypetextBox.TabIndex = 36;
            // 
            // CPUBrandtextBox
            // 
            this.CPUBrandtextBox.Location = new System.Drawing.Point(140, 181);
            this.CPUBrandtextBox.Name = "CPUBrandtextBox";
            this.CPUBrandtextBox.ReadOnly = true;
            this.CPUBrandtextBox.Size = new System.Drawing.Size(268, 36);
            this.CPUBrandtextBox.TabIndex = 37;
            // 
            // LCDsizetextBox
            // 
            this.LCDsizetextBox.Location = new System.Drawing.Point(140, 124);
            this.LCDsizetextBox.Name = "LCDsizetextBox";
            this.LCDsizetextBox.ReadOnly = true;
            this.LCDsizetextBox.Size = new System.Drawing.Size(268, 36);
            this.LCDsizetextBox.TabIndex = 38;
            // 
            // MemorytextBox
            // 
            this.MemorytextBox.Location = new System.Drawing.Point(140, 151);
            this.MemorytextBox.Name = "MemorytextBox";
            this.MemorytextBox.ReadOnly = true;
            this.MemorytextBox.Size = new System.Drawing.Size(268, 36);
            this.MemorytextBox.TabIndex = 35;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(206, 32);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.ReadOnly = true;
            this.PricetextBox.Size = new System.Drawing.Size(131, 36);
            this.PricetextBox.TabIndex = 35;
            // 
            // TaxtextBox
            // 
            this.TaxtextBox.Location = new System.Drawing.Point(242, 91);
            this.TaxtextBox.Name = "TaxtextBox";
            this.TaxtextBox.ReadOnly = true;
            this.TaxtextBox.Size = new System.Drawing.Size(95, 36);
            this.TaxtextBox.TabIndex = 35;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(209, 156);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(131, 36);
            this.TotaltextBox.TabIndex = 35;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 594);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape SperateLine;
        private System.Windows.Forms.TextBox OStextBox;
        private System.Windows.Forms.TextBox MemorytextBox;
        private System.Windows.Forms.TextBox CPUspeedtextBox;
        private System.Windows.Forms.TextBox LCDsizetextBox;
        private System.Windows.Forms.TextBox GPUTypetextBox;
        private System.Windows.Forms.TextBox CPUBrandtextBox;
        private System.Windows.Forms.TextBox HDDtextBox;
        private System.Windows.Forms.TextBox CPUtypetextBox;
        private System.Windows.Forms.TextBox WebCamTextbox;
        private System.Windows.Forms.TextBox CPUnumbertextBox;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.TextBox ManufacturerLabeltextBox;
        private System.Windows.Forms.TextBox PlatformtextBox;
        private System.Windows.Forms.TextBox ConditiontextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox TaxtextBox;
        private System.Windows.Forms.TextBox PricetextBox;
    }
}