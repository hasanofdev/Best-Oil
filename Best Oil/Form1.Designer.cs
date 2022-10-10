namespace Best_Oil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GasStation = new System.Windows.Forms.GroupBox();
            this.QuantitySumGB = new System.Windows.Forms.GroupBox();
            this.ChoiceGB = new System.Windows.Forms.GroupBox();
            this.SumRB = new System.Windows.Forms.RadioButton();
            this.QuantityRB = new System.Windows.Forms.RadioButton();
            this.LiterLabel = new System.Windows.Forms.Label();
            this.QuantityInput = new System.Windows.Forms.TextBox();
            this.AznLabel = new System.Windows.Forms.Label();
            this.SumInput = new System.Windows.Forms.TextBox();
            this.ToPayGasGB = new System.Windows.Forms.GroupBox();
            this.aznLabelTopay = new System.Windows.Forms.Label();
            this.GasPayLabel = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.GasolineCB = new System.Windows.Forms.ComboBox();
            this.GasolineLabel = new System.Windows.Forms.Label();
            this.CafeGB = new System.Windows.Forms.GroupBox();
            this.UserQuantityPanel = new System.Windows.Forms.Panel();
            this.HotDogQuantity = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.HamburgerQuantity = new System.Windows.Forms.TextBox();
            this.HamburgerPrice = new System.Windows.Forms.TextBox();
            this.ColaQuantity = new System.Windows.Forms.TextBox();
            this.ColaPrice = new System.Windows.Forms.TextBox();
            this.FrieQuantity = new System.Windows.Forms.TextBox();
            this.FriePrice = new System.Windows.Forms.TextBox();
            this.ToPayCafeGB = new System.Windows.Forms.GroupBox();
            this.CafePayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CafePriceLabel = new System.Windows.Forms.Label();
            this.ColaCheck = new System.Windows.Forms.CheckBox();
            this.FrieCheck = new System.Windows.Forms.CheckBox();
            this.HamburgerCheck = new System.Windows.Forms.CheckBox();
            this.HotDogCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GasStation.SuspendLayout();
            this.QuantitySumGB.SuspendLayout();
            this.ChoiceGB.SuspendLayout();
            this.ToPayGasGB.SuspendLayout();
            this.CafeGB.SuspendLayout();
            this.UserQuantityPanel.SuspendLayout();
            this.ToPayCafeGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GasStation
            // 
            this.GasStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.GasStation.Controls.Add(this.QuantitySumGB);
            this.GasStation.Controls.Add(this.ToPayGasGB);
            this.GasStation.Controls.Add(this.PriceTB);
            this.GasStation.Controls.Add(this.PriceLabel);
            this.GasStation.Controls.Add(this.GasolineCB);
            this.GasStation.Controls.Add(this.GasolineLabel);
            this.GasStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.GasStation.Location = new System.Drawing.Point(13, 12);
            this.GasStation.Margin = new System.Windows.Forms.Padding(4);
            this.GasStation.Name = "GasStation";
            this.GasStation.Padding = new System.Windows.Forms.Padding(4);
            this.GasStation.Size = new System.Drawing.Size(291, 334);
            this.GasStation.TabIndex = 0;
            this.GasStation.TabStop = false;
            this.GasStation.Text = "Gas Station";
            // 
            // QuantitySumGB
            // 
            this.QuantitySumGB.Controls.Add(this.ChoiceGB);
            this.QuantitySumGB.Controls.Add(this.LiterLabel);
            this.QuantitySumGB.Controls.Add(this.QuantityInput);
            this.QuantitySumGB.Controls.Add(this.AznLabel);
            this.QuantitySumGB.Controls.Add(this.SumInput);
            this.QuantitySumGB.Enabled = false;
            this.QuantitySumGB.Location = new System.Drawing.Point(0, 110);
            this.QuantitySumGB.Name = "QuantitySumGB";
            this.QuantitySumGB.Size = new System.Drawing.Size(291, 111);
            this.QuantitySumGB.TabIndex = 1;
            this.QuantitySumGB.TabStop = false;
            this.QuantitySumGB.EnabledChanged += new System.EventHandler(this.QuantitySumGB_EnabledChanged);
            // 
            // ChoiceGB
            // 
            this.ChoiceGB.Controls.Add(this.SumRB);
            this.ChoiceGB.Controls.Add(this.QuantityRB);
            this.ChoiceGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceGB.Location = new System.Drawing.Point(6, 18);
            this.ChoiceGB.Name = "ChoiceGB";
            this.ChoiceGB.Size = new System.Drawing.Size(132, 82);
            this.ChoiceGB.TabIndex = 4;
            this.ChoiceGB.TabStop = false;
            // 
            // SumRB
            // 
            this.SumRB.AutoSize = true;
            this.SumRB.Location = new System.Drawing.Point(6, 47);
            this.SumRB.Name = "SumRB";
            this.SumRB.Size = new System.Drawing.Size(57, 24);
            this.SumRB.TabIndex = 2;
            this.SumRB.Text = "Sum";
            this.SumRB.UseVisualStyleBackColor = true;
            this.SumRB.CheckedChanged += new System.EventHandler(this.GasolineRB_Click);
            // 
            // QuantityRB
            // 
            this.QuantityRB.AutoSize = true;
            this.QuantityRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuantityRB.Checked = true;
            this.QuantityRB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityRB.Location = new System.Drawing.Point(6, 14);
            this.QuantityRB.Name = "QuantityRB";
            this.QuantityRB.Size = new System.Drawing.Size(79, 21);
            this.QuantityRB.TabIndex = 1;
            this.QuantityRB.TabStop = true;
            this.QuantityRB.Tag = "";
            this.QuantityRB.Text = "Quantity";
            this.QuantityRB.UseVisualStyleBackColor = true;
            this.QuantityRB.CheckedChanged += new System.EventHandler(this.GasolineRB_Click);
            // 
            // LiterLabel
            // 
            this.LiterLabel.AutoSize = true;
            this.LiterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LiterLabel.Location = new System.Drawing.Point(248, 42);
            this.LiterLabel.Name = "LiterLabel";
            this.LiterLabel.Size = new System.Drawing.Size(36, 17);
            this.LiterLabel.TabIndex = 8;
            this.LiterLabel.Text = "liter.";
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(144, 32);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(98, 27);
            this.QuantityInput.TabIndex = 5;
            this.QuantityInput.Tag = "";
            this.QuantityInput.TextChanged += new System.EventHandler(this.QuantityInput_TextChanged);
            // 
            // AznLabel
            // 
            this.AznLabel.AutoSize = true;
            this.AznLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AznLabel.Location = new System.Drawing.Point(248, 75);
            this.AznLabel.Name = "AznLabel";
            this.AznLabel.Size = new System.Drawing.Size(32, 17);
            this.AznLabel.TabIndex = 7;
            this.AznLabel.Text = "azn.";
            // 
            // SumInput
            // 
            this.SumInput.Enabled = false;
            this.SumInput.Location = new System.Drawing.Point(144, 65);
            this.SumInput.Name = "SumInput";
            this.SumInput.Size = new System.Drawing.Size(98, 27);
            this.SumInput.TabIndex = 6;
            this.SumInput.TextChanged += new System.EventHandler(this.SumInput_TextChanged);
            // 
            // ToPayGasGB
            // 
            this.ToPayGasGB.Controls.Add(this.aznLabelTopay);
            this.ToPayGasGB.Controls.Add(this.GasPayLabel);
            this.ToPayGasGB.Location = new System.Drawing.Point(7, 216);
            this.ToPayGasGB.Name = "ToPayGasGB";
            this.ToPayGasGB.Size = new System.Drawing.Size(278, 100);
            this.ToPayGasGB.TabIndex = 1;
            this.ToPayGasGB.TabStop = false;
            this.ToPayGasGB.Text = "To Pay";
            // 
            // aznLabelTopay
            // 
            this.aznLabelTopay.AutoSize = true;
            this.aznLabelTopay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.aznLabelTopay.Location = new System.Drawing.Point(242, 70);
            this.aznLabelTopay.Name = "aznLabelTopay";
            this.aznLabelTopay.Size = new System.Drawing.Size(32, 17);
            this.aznLabelTopay.TabIndex = 8;
            this.aznLabelTopay.Text = "azn.";
            // 
            // GasPayLabel
            // 
            this.GasPayLabel.AutoSize = true;
            this.GasPayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GasPayLabel.Location = new System.Drawing.Point(35, 23);
            this.GasPayLabel.Name = "GasPayLabel";
            this.GasPayLabel.Size = new System.Drawing.Size(85, 47);
            this.GasPayLabel.TabIndex = 0;
            this.GasPayLabel.Text = "0.00";
            this.GasPayLabel.TextChanged += new System.EventHandler(this.PayLabel_TextChanged);
            // 
            // PriceTB
            // 
            this.PriceTB.Enabled = false;
            this.PriceTB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceTB.Location = new System.Drawing.Point(92, 81);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(151, 29);
            this.PriceTB.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.PriceLabel.Location = new System.Drawing.Point(7, 81);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 20);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // GasolineCB
            // 
            this.GasolineCB.FormattingEnabled = true;
            this.GasolineCB.ItemHeight = 20;
            this.GasolineCB.Items.AddRange(new object[] {
            "Aİ-92",
            "Aİ-95",
            "Aİ-98"});
            this.GasolineCB.Location = new System.Drawing.Point(92, 39);
            this.GasolineCB.Name = "GasolineCB";
            this.GasolineCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GasolineCB.Size = new System.Drawing.Size(151, 28);
            this.GasolineCB.TabIndex = 1;
            this.GasolineCB.SelectedIndexChanged += new System.EventHandler(this.GasolineCB_SelectedIndexChanged);
            this.GasolineCB.TextUpdate += new System.EventHandler(this.GasolineCB_TextUpdate);
            // 
            // GasolineLabel
            // 
            this.GasolineLabel.AutoSize = true;
            this.GasolineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.GasolineLabel.Location = new System.Drawing.Point(7, 42);
            this.GasolineLabel.Name = "GasolineLabel";
            this.GasolineLabel.Size = new System.Drawing.Size(67, 20);
            this.GasolineLabel.TabIndex = 0;
            this.GasolineLabel.Text = "Gasoline";
            // 
            // CafeGB
            // 
            this.CafeGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.CafeGB.Controls.Add(this.UserQuantityPanel);
            this.CafeGB.Controls.Add(this.ToPayCafeGB);
            this.CafeGB.Controls.Add(this.ColaPrice);
            this.CafeGB.Controls.Add(this.FriePrice);
            this.CafeGB.Controls.Add(this.HamburgerPrice);
            this.CafeGB.Controls.Add(this.HotDogPrice);
            this.CafeGB.Controls.Add(this.QuantityLabel);
            this.CafeGB.Controls.Add(this.CafePriceLabel);
            this.CafeGB.Controls.Add(this.ColaCheck);
            this.CafeGB.Controls.Add(this.FrieCheck);
            this.CafeGB.Controls.Add(this.HamburgerCheck);
            this.CafeGB.Controls.Add(this.HotDogCheck);
            this.CafeGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.CafeGB.Location = new System.Drawing.Point(311, 12);
            this.CafeGB.Name = "CafeGB";
            this.CafeGB.Size = new System.Drawing.Size(278, 334);
            this.CafeGB.TabIndex = 1;
            this.CafeGB.TabStop = false;
            this.CafeGB.Text = "Mini Cafe";
            // 
            // UserQuantityPanel
            // 
            this.UserQuantityPanel.Controls.Add(this.HotDogQuantity);
            this.UserQuantityPanel.Controls.Add(this.HamburgerQuantity);
            this.UserQuantityPanel.Controls.Add(this.ColaQuantity);
            this.UserQuantityPanel.Controls.Add(this.FrieQuantity);
            this.UserQuantityPanel.Location = new System.Drawing.Point(193, 37);
            this.UserQuantityPanel.Name = "UserQuantityPanel";
            this.UserQuantityPanel.Size = new System.Drawing.Size(85, 120);
            this.UserQuantityPanel.TabIndex = 14;
            // 
            // HotDogQuantity
            // 
            this.HotDogQuantity.Enabled = false;
            this.HotDogQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HotDogQuantity.Location = new System.Drawing.Point(8, 3);
            this.HotDogQuantity.Name = "HotDogQuantity";
            this.HotDogQuantity.Size = new System.Drawing.Size(72, 23);
            this.HotDogQuantity.TabIndex = 10;
            this.HotDogQuantity.Tag = this.HotDogPrice;
            this.HotDogQuantity.TextChanged += new System.EventHandler(this.CafeQuantity_TextChanged);
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.Enabled = false;
            this.HotDogPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HotDogPrice.Location = new System.Drawing.Point(136, 39);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.Size = new System.Drawing.Size(51, 23);
            this.HotDogPrice.TabIndex = 6;
            this.HotDogPrice.Text = "4.00";
            // 
            // HamburgerQuantity
            // 
            this.HamburgerQuantity.Enabled = false;
            this.HamburgerQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HamburgerQuantity.Location = new System.Drawing.Point(8, 32);
            this.HamburgerQuantity.Name = "HamburgerQuantity";
            this.HamburgerQuantity.Size = new System.Drawing.Size(72, 23);
            this.HamburgerQuantity.TabIndex = 11;
            this.HamburgerQuantity.Tag = this.HamburgerPrice;
            this.HamburgerQuantity.TextChanged += new System.EventHandler(this.CafeQuantity_TextChanged);
            // 
            // HamburgerPrice
            // 
            this.HamburgerPrice.Enabled = false;
            this.HamburgerPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HamburgerPrice.Location = new System.Drawing.Point(136, 68);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.Size = new System.Drawing.Size(51, 23);
            this.HamburgerPrice.TabIndex = 7;
            this.HamburgerPrice.Text = "5.40";
            // 
            // ColaQuantity
            // 
            this.ColaQuantity.Enabled = false;
            this.ColaQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColaQuantity.Location = new System.Drawing.Point(7, 91);
            this.ColaQuantity.Name = "ColaQuantity";
            this.ColaQuantity.Size = new System.Drawing.Size(72, 23);
            this.ColaQuantity.TabIndex = 13;
            this.ColaQuantity.Tag = this.ColaPrice;
            this.ColaQuantity.TextChanged += new System.EventHandler(this.CafeQuantity_TextChanged);
            // 
            // ColaPrice
            // 
            this.ColaPrice.Enabled = false;
            this.ColaPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColaPrice.Location = new System.Drawing.Point(136, 128);
            this.ColaPrice.Name = "ColaPrice";
            this.ColaPrice.Size = new System.Drawing.Size(51, 23);
            this.ColaPrice.TabIndex = 9;
            this.ColaPrice.Text = "4.40";
            // 
            // FrieQuantity
            // 
            this.FrieQuantity.Enabled = false;
            this.FrieQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FrieQuantity.Location = new System.Drawing.Point(8, 61);
            this.FrieQuantity.Name = "FrieQuantity";
            this.FrieQuantity.Size = new System.Drawing.Size(72, 23);
            this.FrieQuantity.TabIndex = 12;
            this.FrieQuantity.Tag = this.FriePrice;
            this.FrieQuantity.TextChanged += new System.EventHandler(this.CafeQuantity_TextChanged);
            // 
            // FriePrice
            // 
            this.FriePrice.Enabled = false;
            this.FriePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FriePrice.Location = new System.Drawing.Point(136, 97);
            this.FriePrice.Name = "FriePrice";
            this.FriePrice.Size = new System.Drawing.Size(51, 23);
            this.FriePrice.TabIndex = 8;
            this.FriePrice.Text = "7.20";
            // 
            // ToPayCafeGB
            // 
            this.ToPayCafeGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.ToPayCafeGB.Controls.Add(this.CafePayLabel);
            this.ToPayCafeGB.Controls.Add(this.label1);
            this.ToPayCafeGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.ToPayCafeGB.Location = new System.Drawing.Point(6, 216);
            this.ToPayCafeGB.Name = "ToPayCafeGB";
            this.ToPayCafeGB.Size = new System.Drawing.Size(266, 100);
            this.ToPayCafeGB.TabIndex = 14;
            this.ToPayCafeGB.TabStop = false;
            this.ToPayCafeGB.Text = "To Pay";
            // 
            // CafePayLabel
            // 
            this.CafePayLabel.AutoSize = true;
            this.CafePayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CafePayLabel.Location = new System.Drawing.Point(12, 23);
            this.CafePayLabel.Name = "CafePayLabel";
            this.CafePayLabel.Size = new System.Drawing.Size(85, 47);
            this.CafePayLabel.TabIndex = 10;
            this.CafePayLabel.Text = "0.00";
            this.CafePayLabel.TextChanged += new System.EventHandler(this.PayLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "azn.";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(204, 14);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(68, 20);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // CafePriceLabel
            // 
            this.CafePriceLabel.AutoSize = true;
            this.CafePriceLabel.Location = new System.Drawing.Point(144, 14);
            this.CafePriceLabel.Name = "CafePriceLabel";
            this.CafePriceLabel.Size = new System.Drawing.Size(43, 20);
            this.CafePriceLabel.TabIndex = 4;
            this.CafePriceLabel.Text = "Price";
            // 
            // ColaCheck
            // 
            this.ColaCheck.AutoSize = true;
            this.ColaCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColaCheck.Location = new System.Drawing.Point(18, 133);
            this.ColaCheck.Name = "ColaCheck";
            this.ColaCheck.Size = new System.Drawing.Size(98, 24);
            this.ColaCheck.TabIndex = 3;
            this.ColaCheck.Tag = this.ColaQuantity;
            this.ColaCheck.Text = "Coco-Cola";
            this.ColaCheck.UseVisualStyleBackColor = true;
            this.ColaCheck.CheckedChanged += new System.EventHandler(this.CafeCheck_CheckedChanged);
            // 
            // FrieCheck
            // 
            this.FrieCheck.AutoSize = true;
            this.FrieCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrieCheck.Location = new System.Drawing.Point(18, 103);
            this.FrieCheck.Name = "FrieCheck";
            this.FrieCheck.Size = new System.Drawing.Size(102, 24);
            this.FrieCheck.TabIndex = 2;
            this.FrieCheck.Tag = this.FrieQuantity;
            this.FrieCheck.Text = "Patato Frie";
            this.FrieCheck.UseVisualStyleBackColor = true;
            this.FrieCheck.CheckedChanged += new System.EventHandler(this.CafeCheck_CheckedChanged);
            // 
            // HamburgerCheck
            // 
            this.HamburgerCheck.AutoSize = true;
            this.HamburgerCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HamburgerCheck.Location = new System.Drawing.Point(18, 73);
            this.HamburgerCheck.Name = "HamburgerCheck";
            this.HamburgerCheck.Size = new System.Drawing.Size(107, 24);
            this.HamburgerCheck.TabIndex = 1;
            this.HamburgerCheck.Tag = this.HamburgerQuantity;
            this.HamburgerCheck.Text = "Hamburger";
            this.HamburgerCheck.UseVisualStyleBackColor = true;
            this.HamburgerCheck.CheckedChanged += new System.EventHandler(this.CafeCheck_CheckedChanged);
            // 
            // HotDogCheck
            // 
            this.HotDogCheck.AutoSize = true;
            this.HotDogCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotDogCheck.Location = new System.Drawing.Point(18, 43);
            this.HotDogCheck.Name = "HotDogCheck";
            this.HotDogCheck.Size = new System.Drawing.Size(87, 24);
            this.HotDogCheck.TabIndex = 0;
            this.HotDogCheck.Tag = this.HotDogQuantity;
            this.HotDogCheck.Text = "Hot-Dog";
            this.HotDogCheck.UseVisualStyleBackColor = true;
            this.HotDogCheck.CheckedChanged += new System.EventHandler(this.CafeCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TotalAmountLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(518, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "azn.";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountLabel.Location = new System.Drawing.Point(339, 73);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(85, 47);
            this.TotalAmountLabel.TabIndex = 11;
            this.TotalAmountLabel.Text = "0.00";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(112, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Best_Oil.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(111)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(603, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CafeGB);
            this.Controls.Add(this.GasStation);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Best Oil";
            this.GasStation.ResumeLayout(false);
            this.GasStation.PerformLayout();
            this.QuantitySumGB.ResumeLayout(false);
            this.QuantitySumGB.PerformLayout();
            this.ChoiceGB.ResumeLayout(false);
            this.ChoiceGB.PerformLayout();
            this.ToPayGasGB.ResumeLayout(false);
            this.ToPayGasGB.PerformLayout();
            this.CafeGB.ResumeLayout(false);
            this.CafeGB.PerformLayout();
            this.UserQuantityPanel.ResumeLayout(false);
            this.UserQuantityPanel.PerformLayout();
            this.ToPayCafeGB.ResumeLayout(false);
            this.ToPayCafeGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GasStation;
        private ComboBox GasolineCB;
        private Label GasolineLabel;
        private Label PriceLabel;
        private GroupBox ChoiceGB;
        private RadioButton SumRB;
        private RadioButton QuantityRB;
        private TextBox PriceTB;
        private GroupBox ToPayGasGB;
        private Label aznLabelTopay;
        private Label GasPayLabel;
        private Label LiterLabel;
        private Label AznLabel;
        private TextBox SumInput;
        private TextBox QuantityInput;
        private GroupBox QuantitySumGB;
        private GroupBox CafeGB;
        private TextBox ColaQuantity;
        private TextBox FrieQuantity;
        private TextBox HamburgerQuantity;
        private TextBox HotDogQuantity;
        private TextBox ColaPrice;
        private TextBox FriePrice;
        private TextBox HamburgerPrice;
        private TextBox HotDogPrice;
        private Label QuantityLabel;
        private Label CafePriceLabel;
        private CheckBox ColaCheck;
        private CheckBox FrieCheck;
        private CheckBox HamburgerCheck;
        private CheckBox HotDogCheck;
        private GroupBox ToPayCafeGB;
        private Label CafePayLabel;
        private Label label1;
        private Panel UserQuantityPanel;
        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label TotalAmountLabel;
    }
}