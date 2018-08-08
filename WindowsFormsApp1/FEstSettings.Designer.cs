namespace WindowsFormsApp1
{
    partial class FEstSettings
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
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxTaxOptions = new System.Windows.Forms.GroupBox();
            this.lblEquipmentRatePercentage = new System.Windows.Forms.Label();
            this.lblLaborRatePercentage = new System.Windows.Forms.Label();
            this.lblMaterialRatePercentage = new System.Windows.Forms.Label();
            this.txtEquipmentRate = new System.Windows.Forms.TextBox();
            this.txtLaborRate = new System.Windows.Forms.TextBox();
            this.txtMaterialRate = new System.Windows.Forms.TextBox();
            this.lblEquipmentRate = new System.Windows.Forms.Label();
            this.lblLaborRate = new System.Windows.Forms.Label();
            this.lblMaterialRate = new System.Windows.Forms.Label();
            this.cbxTaxEstimate = new System.Windows.Forms.CheckBox();
            this.gbxOverheadProfitOptions = new System.Windows.Forms.GroupBox();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.cbxApplyTax = new System.Windows.Forms.CheckBox();
            this.rboCoverageTotal = new System.Windows.Forms.RadioButton();
            this.rboLineItemCost = new System.Windows.Forms.RadioButton();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtOverhead = new System.Windows.Forms.TextBox();
            this.lblOverheadPercentage = new System.Windows.Forms.Label();
            this.lblProfitPercentage = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblOverhead = new System.Windows.Forms.Label();
            this.cbxDepreciateOP = new System.Windows.Forms.CheckBox();
            this.cbxnonCumulativeOP = new System.Windows.Forms.CheckBox();
            this.cbxOPEstimate = new System.Windows.Forms.CheckBox();
            this.gbxRegionalCostAdjustment = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCanadianRegion = new System.Windows.Forms.Button();
            this.btnUSRegion = new System.Windows.Forms.Button();
            this.txtLocationLabor = new System.Windows.Forms.TextBox();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.txtLocationMaterial = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblEquip = new System.Windows.Forms.Label();
            this.lblLocationLabor = new System.Windows.Forms.Label();
            this.lblLocationMaterial = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.gbxMaterials = new System.Windows.Forms.GroupBox();
            this.btnImportOverlay = new System.Windows.Forms.Button();
            this.btnNewOverlay = new System.Windows.Forms.Button();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.cbxOverlay = new System.Windows.Forms.ComboBox();
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.lblOverlay = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.gbxAdvancedPayment = new System.Windows.Forms.GroupBox();
            this.txtAdvancedPayment = new System.Windows.Forms.TextBox();
            this.lblAdvancedPayment = new System.Windows.Forms.Label();
            this.cbxDepreciateTax = new System.Windows.Forms.CheckBox();
            this.cbxDepreciateLabor = new System.Windows.Forms.CheckBox();
            this.lblDefaultItemDescription = new System.Windows.Forms.Label();
            this.txtDefaultItemDescription = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnExistingItems = new System.Windows.Forms.Button();
            this.gbxTaxOptions.SuspendLayout();
            this.gbxOverheadProfitOptions.SuspendLayout();
            this.gbx.SuspendLayout();
            this.gbxRegionalCostAdjustment.SuspendLayout();
            this.gbxMaterials.SuspendLayout();
            this.gbxAdvancedPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 12);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxTaxOptions
            // 
            this.gbxTaxOptions.Controls.Add(this.lblEquipmentRatePercentage);
            this.gbxTaxOptions.Controls.Add(this.lblLaborRatePercentage);
            this.gbxTaxOptions.Controls.Add(this.lblMaterialRatePercentage);
            this.gbxTaxOptions.Controls.Add(this.txtEquipmentRate);
            this.gbxTaxOptions.Controls.Add(this.txtLaborRate);
            this.gbxTaxOptions.Controls.Add(this.txtMaterialRate);
            this.gbxTaxOptions.Controls.Add(this.lblEquipmentRate);
            this.gbxTaxOptions.Controls.Add(this.lblLaborRate);
            this.gbxTaxOptions.Controls.Add(this.lblMaterialRate);
            this.gbxTaxOptions.Controls.Add(this.cbxTaxEstimate);
            this.gbxTaxOptions.Location = new System.Drawing.Point(12, 61);
            this.gbxTaxOptions.Name = "gbxTaxOptions";
            this.gbxTaxOptions.Size = new System.Drawing.Size(200, 125);
            this.gbxTaxOptions.TabIndex = 2;
            this.gbxTaxOptions.TabStop = false;
            this.gbxTaxOptions.Text = "Tax Options:";
            // 
            // lblEquipmentRatePercentage
            // 
            this.lblEquipmentRatePercentage.AutoSize = true;
            this.lblEquipmentRatePercentage.Location = new System.Drawing.Point(172, 99);
            this.lblEquipmentRatePercentage.Name = "lblEquipmentRatePercentage";
            this.lblEquipmentRatePercentage.Size = new System.Drawing.Size(15, 13);
            this.lblEquipmentRatePercentage.TabIndex = 9;
            this.lblEquipmentRatePercentage.Text = "%";
            // 
            // lblLaborRatePercentage
            // 
            this.lblLaborRatePercentage.AutoSize = true;
            this.lblLaborRatePercentage.Location = new System.Drawing.Point(171, 69);
            this.lblLaborRatePercentage.Name = "lblLaborRatePercentage";
            this.lblLaborRatePercentage.Size = new System.Drawing.Size(15, 13);
            this.lblLaborRatePercentage.TabIndex = 8;
            this.lblLaborRatePercentage.Text = "%";
            // 
            // lblMaterialRatePercentage
            // 
            this.lblMaterialRatePercentage.AutoSize = true;
            this.lblMaterialRatePercentage.Location = new System.Drawing.Point(171, 37);
            this.lblMaterialRatePercentage.Name = "lblMaterialRatePercentage";
            this.lblMaterialRatePercentage.Size = new System.Drawing.Size(15, 13);
            this.lblMaterialRatePercentage.TabIndex = 7;
            this.lblMaterialRatePercentage.Text = "%";
            // 
            // txtEquipmentRate
            // 
            this.txtEquipmentRate.Location = new System.Drawing.Point(94, 99);
            this.txtEquipmentRate.Name = "txtEquipmentRate";
            this.txtEquipmentRate.Size = new System.Drawing.Size(71, 20);
            this.txtEquipmentRate.TabIndex = 6;
            // 
            // txtLaborRate
            // 
            this.txtLaborRate.Location = new System.Drawing.Point(94, 66);
            this.txtLaborRate.Name = "txtLaborRate";
            this.txtLaborRate.Size = new System.Drawing.Size(71, 20);
            this.txtLaborRate.TabIndex = 5;
            // 
            // txtMaterialRate
            // 
            this.txtMaterialRate.Location = new System.Drawing.Point(94, 37);
            this.txtMaterialRate.Name = "txtMaterialRate";
            this.txtMaterialRate.Size = new System.Drawing.Size(71, 20);
            this.txtMaterialRate.TabIndex = 4;
            // 
            // lblEquipmentRate
            // 
            this.lblEquipmentRate.AutoSize = true;
            this.lblEquipmentRate.Location = new System.Drawing.Point(2, 109);
            this.lblEquipmentRate.Name = "lblEquipmentRate";
            this.lblEquipmentRate.Size = new System.Drawing.Size(86, 13);
            this.lblEquipmentRate.TabIndex = 3;
            this.lblEquipmentRate.Text = "Equipment Rate:";
            // 
            // lblLaborRate
            // 
            this.lblLaborRate.AutoSize = true;
            this.lblLaborRate.Location = new System.Drawing.Point(6, 73);
            this.lblLaborRate.Name = "lblLaborRate";
            this.lblLaborRate.Size = new System.Drawing.Size(63, 13);
            this.lblLaborRate.TabIndex = 2;
            this.lblLaborRate.Text = "Labor Rate:";
            // 
            // lblMaterialRate
            // 
            this.lblMaterialRate.AutoSize = true;
            this.lblMaterialRate.Location = new System.Drawing.Point(4, 44);
            this.lblMaterialRate.Name = "lblMaterialRate";
            this.lblMaterialRate.Size = new System.Drawing.Size(73, 13);
            this.lblMaterialRate.TabIndex = 1;
            this.lblMaterialRate.Text = "Material Rate:";
            // 
            // cbxTaxEstimate
            // 
            this.cbxTaxEstimate.AutoSize = true;
            this.cbxTaxEstimate.Location = new System.Drawing.Point(7, 19);
            this.cbxTaxEstimate.Name = "cbxTaxEstimate";
            this.cbxTaxEstimate.Size = new System.Drawing.Size(131, 17);
            this.cbxTaxEstimate.TabIndex = 0;
            this.cbxTaxEstimate.Text = "Include tax in estimate";
            this.cbxTaxEstimate.UseVisualStyleBackColor = true;
            // 
            // gbxOverheadProfitOptions
            // 
            this.gbxOverheadProfitOptions.Controls.Add(this.gbx);
            this.gbxOverheadProfitOptions.Controls.Add(this.txtProfit);
            this.gbxOverheadProfitOptions.Controls.Add(this.txtOverhead);
            this.gbxOverheadProfitOptions.Controls.Add(this.lblOverheadPercentage);
            this.gbxOverheadProfitOptions.Controls.Add(this.lblProfitPercentage);
            this.gbxOverheadProfitOptions.Controls.Add(this.lblProfit);
            this.gbxOverheadProfitOptions.Controls.Add(this.lblOverhead);
            this.gbxOverheadProfitOptions.Controls.Add(this.cbxDepreciateOP);
            this.gbxOverheadProfitOptions.Controls.Add(this.cbxnonCumulativeOP);
            this.gbxOverheadProfitOptions.Controls.Add(this.cbxOPEstimate);
            this.gbxOverheadProfitOptions.Location = new System.Drawing.Point(228, 68);
            this.gbxOverheadProfitOptions.Name = "gbxOverheadProfitOptions";
            this.gbxOverheadProfitOptions.Size = new System.Drawing.Size(255, 263);
            this.gbxOverheadProfitOptions.TabIndex = 3;
            this.gbxOverheadProfitOptions.TabStop = false;
            this.gbxOverheadProfitOptions.Text = "Overhead & Profit Options:";
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.cbxApplyTax);
            this.gbx.Controls.Add(this.rboCoverageTotal);
            this.gbx.Controls.Add(this.rboLineItemCost);
            this.gbx.Location = new System.Drawing.Point(6, 151);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(225, 93);
            this.gbx.TabIndex = 11;
            this.gbx.TabStop = false;
            // 
            // cbxApplyTax
            // 
            this.cbxApplyTax.AutoSize = true;
            this.cbxApplyTax.Location = new System.Drawing.Point(0, 63);
            this.cbxApplyTax.Name = "cbxApplyTax";
            this.cbxApplyTax.Size = new System.Drawing.Size(103, 17);
            this.cbxApplyTax.TabIndex = 3;
            this.cbxApplyTax.Text = "Apply Tax to OP";
            this.cbxApplyTax.UseVisualStyleBackColor = true;
            // 
            // rboCoverageTotal
            // 
            this.rboCoverageTotal.AutoSize = true;
            this.rboCoverageTotal.Location = new System.Drawing.Point(0, 40);
            this.rboCoverageTotal.Name = "rboCoverageTotal";
            this.rboCoverageTotal.Size = new System.Drawing.Size(160, 17);
            this.rboCoverageTotal.TabIndex = 1;
            this.rboCoverageTotal.TabStop = true;
            this.rboCoverageTotal.Text = "Show OP in coverage totals:";
            this.rboCoverageTotal.UseVisualStyleBackColor = true;
            // 
            // rboLineItemCost
            // 
            this.rboLineItemCost.AutoSize = true;
            this.rboLineItemCost.Location = new System.Drawing.Point(0, 17);
            this.rboLineItemCost.Name = "rboLineItemCost";
            this.rboLineItemCost.Size = new System.Drawing.Size(165, 17);
            this.rboLineItemCost.TabIndex = 0;
            this.rboLineItemCost.TabStop = true;
            this.rboLineItemCost.Text = "Add OP to each line item cost";
            this.rboLineItemCost.UseVisualStyleBackColor = true;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(61, 89);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(76, 20);
            this.txtProfit.TabIndex = 10;
            // 
            // txtOverhead
            // 
            this.txtOverhead.Location = new System.Drawing.Point(61, 66);
            this.txtOverhead.Name = "txtOverhead";
            this.txtOverhead.Size = new System.Drawing.Size(76, 20);
            this.txtOverhead.TabIndex = 9;
            // 
            // lblOverheadPercentage
            // 
            this.lblOverheadPercentage.AutoSize = true;
            this.lblOverheadPercentage.Location = new System.Drawing.Point(143, 69);
            this.lblOverheadPercentage.Name = "lblOverheadPercentage";
            this.lblOverheadPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblOverheadPercentage.TabIndex = 8;
            this.lblOverheadPercentage.Text = "%";
            // 
            // lblProfitPercentage
            // 
            this.lblProfitPercentage.AutoSize = true;
            this.lblProfitPercentage.Location = new System.Drawing.Point(143, 96);
            this.lblProfitPercentage.Name = "lblProfitPercentage";
            this.lblProfitPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblProfitPercentage.TabIndex = 7;
            this.lblProfitPercentage.Text = "%";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(7, 89);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(34, 13);
            this.lblProfit.TabIndex = 6;
            this.lblProfit.Text = "Profit:";
            // 
            // lblOverhead
            // 
            this.lblOverhead.AutoSize = true;
            this.lblOverhead.Location = new System.Drawing.Point(7, 73);
            this.lblOverhead.Name = "lblOverhead";
            this.lblOverhead.Size = new System.Drawing.Size(57, 13);
            this.lblOverhead.TabIndex = 5;
            this.lblOverhead.Text = "Overhead:";
            // 
            // cbxDepreciateOP
            // 
            this.cbxDepreciateOP.AutoSize = true;
            this.cbxDepreciateOP.Location = new System.Drawing.Point(6, 128);
            this.cbxDepreciateOP.Name = "cbxDepreciateOP";
            this.cbxDepreciateOP.Size = new System.Drawing.Size(96, 17);
            this.cbxDepreciateOP.TabIndex = 2;
            this.cbxDepreciateOP.Text = "Depreciate OP";
            this.cbxDepreciateOP.UseVisualStyleBackColor = true;
            // 
            // cbxnonCumulativeOP
            // 
            this.cbxnonCumulativeOP.AutoSize = true;
            this.cbxnonCumulativeOP.Location = new System.Drawing.Point(10, 49);
            this.cbxnonCumulativeOP.Name = "cbxnonCumulativeOP";
            this.cbxnonCumulativeOP.Size = new System.Drawing.Size(199, 17);
            this.cbxnonCumulativeOP.TabIndex = 1;
            this.cbxnonCumulativeOP.Text = "Non-cumulative OP (10%+10%=20%)";
            this.cbxnonCumulativeOP.UseVisualStyleBackColor = true;
            // 
            // cbxOPEstimate
            // 
            this.cbxOPEstimate.AutoSize = true;
            this.cbxOPEstimate.Location = new System.Drawing.Point(6, 19);
            this.cbxOPEstimate.Name = "cbxOPEstimate";
            this.cbxOPEstimate.Size = new System.Drawing.Size(117, 17);
            this.cbxOPEstimate.TabIndex = 0;
            this.cbxOPEstimate.Text = "Add OP to estimate";
            this.cbxOPEstimate.UseVisualStyleBackColor = true;
            // 
            // gbxRegionalCostAdjustment
            // 
            this.gbxRegionalCostAdjustment.Controls.Add(this.btnClear);
            this.gbxRegionalCostAdjustment.Controls.Add(this.btnCanadianRegion);
            this.gbxRegionalCostAdjustment.Controls.Add(this.btnUSRegion);
            this.gbxRegionalCostAdjustment.Controls.Add(this.txtLocationLabor);
            this.gbxRegionalCostAdjustment.Controls.Add(this.txtEquip);
            this.gbxRegionalCostAdjustment.Controls.Add(this.txtLocationMaterial);
            this.gbxRegionalCostAdjustment.Controls.Add(this.txtLocation);
            this.gbxRegionalCostAdjustment.Controls.Add(this.lblEquip);
            this.gbxRegionalCostAdjustment.Controls.Add(this.lblLocationLabor);
            this.gbxRegionalCostAdjustment.Controls.Add(this.lblLocationMaterial);
            this.gbxRegionalCostAdjustment.Controls.Add(this.lblLocation);
            this.gbxRegionalCostAdjustment.Location = new System.Drawing.Point(12, 217);
            this.gbxRegionalCostAdjustment.Name = "gbxRegionalCostAdjustment";
            this.gbxRegionalCostAdjustment.Size = new System.Drawing.Size(200, 221);
            this.gbxRegionalCostAdjustment.TabIndex = 4;
            this.gbxRegionalCostAdjustment.TabStop = false;
            this.gbxRegionalCostAdjustment.Text = "Regional Cost Adjustment";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCanadianRegion
            // 
            this.btnCanadianRegion.Location = new System.Drawing.Point(46, 163);
            this.btnCanadianRegion.Name = "btnCanadianRegion";
            this.btnCanadianRegion.Size = new System.Drawing.Size(141, 23);
            this.btnCanadianRegion.TabIndex = 17;
            this.btnCanadianRegion.Text = "Select Canadian Region";
            this.btnCanadianRegion.UseVisualStyleBackColor = true;
            // 
            // btnUSRegion
            // 
            this.btnUSRegion.Location = new System.Drawing.Point(46, 134);
            this.btnUSRegion.Name = "btnUSRegion";
            this.btnUSRegion.Size = new System.Drawing.Size(141, 23);
            this.btnUSRegion.TabIndex = 16;
            this.btnUSRegion.Text = "Select U.S. Region";
            this.btnUSRegion.UseVisualStyleBackColor = true;
            // 
            // txtLocationLabor
            // 
            this.txtLocationLabor.Location = new System.Drawing.Point(81, 94);
            this.txtLocationLabor.Name = "txtLocationLabor";
            this.txtLocationLabor.Size = new System.Drawing.Size(47, 20);
            this.txtLocationLabor.TabIndex = 15;
            // 
            // txtEquip
            // 
            this.txtEquip.Location = new System.Drawing.Point(143, 94);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(43, 20);
            this.txtEquip.TabIndex = 14;
            // 
            // txtLocationMaterial
            // 
            this.txtLocationMaterial.Location = new System.Drawing.Point(20, 94);
            this.txtLocationMaterial.Name = "txtLocationMaterial";
            this.txtLocationMaterial.Size = new System.Drawing.Size(45, 20);
            this.txtLocationMaterial.TabIndex = 13;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(20, 42);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(166, 20);
            this.txtLocation.TabIndex = 12;
            // 
            // lblEquip
            // 
            this.lblEquip.AutoSize = true;
            this.lblEquip.Location = new System.Drawing.Point(152, 78);
            this.lblEquip.Name = "lblEquip";
            this.lblEquip.Size = new System.Drawing.Size(34, 13);
            this.lblEquip.TabIndex = 11;
            this.lblEquip.Text = "Equip";
            // 
            // lblLocationLabor
            // 
            this.lblLocationLabor.AutoSize = true;
            this.lblLocationLabor.Location = new System.Drawing.Point(91, 78);
            this.lblLocationLabor.Name = "lblLocationLabor";
            this.lblLocationLabor.Size = new System.Drawing.Size(34, 13);
            this.lblLocationLabor.TabIndex = 10;
            this.lblLocationLabor.Text = "Labor";
            // 
            // lblLocationMaterial
            // 
            this.lblLocationMaterial.AutoSize = true;
            this.lblLocationMaterial.Location = new System.Drawing.Point(21, 78);
            this.lblLocationMaterial.Name = "lblLocationMaterial";
            this.lblLocationMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblLocationMaterial.TabIndex = 9;
            this.lblLocationMaterial.Text = "Material";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 26);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            // 
            // gbxMaterials
            // 
            this.gbxMaterials.Controls.Add(this.btnImportOverlay);
            this.gbxMaterials.Controls.Add(this.btnNewOverlay);
            this.gbxMaterials.Controls.Add(this.btnSetDefault);
            this.gbxMaterials.Controls.Add(this.cbxOverlay);
            this.gbxMaterials.Controls.Add(this.cbxDatabase);
            this.gbxMaterials.Controls.Add(this.lblOverlay);
            this.gbxMaterials.Controls.Add(this.lblDatabase);
            this.gbxMaterials.Location = new System.Drawing.Point(12, 455);
            this.gbxMaterials.Name = "gbxMaterials";
            this.gbxMaterials.Size = new System.Drawing.Size(408, 100);
            this.gbxMaterials.TabIndex = 5;
            this.gbxMaterials.TabStop = false;
            this.gbxMaterials.Text = "Materials";
            // 
            // btnImportOverlay
            // 
            this.btnImportOverlay.Location = new System.Drawing.Point(314, 52);
            this.btnImportOverlay.Name = "btnImportOverlay";
            this.btnImportOverlay.Size = new System.Drawing.Size(90, 23);
            this.btnImportOverlay.TabIndex = 6;
            this.btnImportOverlay.Text = "Import Overlay";
            this.btnImportOverlay.UseVisualStyleBackColor = true;
            // 
            // btnNewOverlay
            // 
            this.btnNewOverlay.Location = new System.Drawing.Point(216, 51);
            this.btnNewOverlay.Name = "btnNewOverlay";
            this.btnNewOverlay.Size = new System.Drawing.Size(92, 23);
            this.btnNewOverlay.TabIndex = 5;
            this.btnNewOverlay.Text = "New Overlay";
            this.btnNewOverlay.UseVisualStyleBackColor = true;
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Location = new System.Drawing.Point(216, 22);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(92, 23);
            this.btnSetDefault.TabIndex = 4;
            this.btnSetDefault.Text = "Set as Default";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            // 
            // cbxOverlay
            // 
            this.cbxOverlay.FormattingEnabled = true;
            this.cbxOverlay.Location = new System.Drawing.Point(66, 49);
            this.cbxOverlay.Name = "cbxOverlay";
            this.cbxOverlay.Size = new System.Drawing.Size(121, 21);
            this.cbxOverlay.TabIndex = 3;
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Location = new System.Drawing.Point(65, 22);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(121, 21);
            this.cbxDatabase.TabIndex = 2;
            // 
            // lblOverlay
            // 
            this.lblOverlay.AutoSize = true;
            this.lblOverlay.Location = new System.Drawing.Point(6, 57);
            this.lblOverlay.Name = "lblOverlay";
            this.lblOverlay.Size = new System.Drawing.Size(47, 13);
            this.lblOverlay.TabIndex = 1;
            this.lblOverlay.Text = "OverLay";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(5, 20);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(56, 13);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "Database:";
            // 
            // gbxAdvancedPayment
            // 
            this.gbxAdvancedPayment.Controls.Add(this.txtAdvancedPayment);
            this.gbxAdvancedPayment.Controls.Add(this.lblAdvancedPayment);
            this.gbxAdvancedPayment.Location = new System.Drawing.Point(12, 561);
            this.gbxAdvancedPayment.Name = "gbxAdvancedPayment";
            this.gbxAdvancedPayment.Size = new System.Drawing.Size(408, 100);
            this.gbxAdvancedPayment.TabIndex = 6;
            this.gbxAdvancedPayment.TabStop = false;
            this.gbxAdvancedPayment.Text = "Advanced Payment";
            // 
            // txtAdvancedPayment
            // 
            this.txtAdvancedPayment.Location = new System.Drawing.Point(12, 50);
            this.txtAdvancedPayment.Name = "txtAdvancedPayment";
            this.txtAdvancedPayment.Size = new System.Drawing.Size(100, 20);
            this.txtAdvancedPayment.TabIndex = 1;
            // 
            // lblAdvancedPayment
            // 
            this.lblAdvancedPayment.AutoSize = true;
            this.lblAdvancedPayment.Location = new System.Drawing.Point(9, 20);
            this.lblAdvancedPayment.Name = "lblAdvancedPayment";
            this.lblAdvancedPayment.Size = new System.Drawing.Size(365, 26);
            this.lblAdvancedPayment.TabIndex = 0;
            this.lblAdvancedPayment.Text = "The Advenced Payment will show in the Statement of Loss,Short Form  and \r\noptiona" +
    "lly in the Complete Estimate";
            // 
            // cbxDepreciateTax
            // 
            this.cbxDepreciateTax.AutoSize = true;
            this.cbxDepreciateTax.Location = new System.Drawing.Point(228, 358);
            this.cbxDepreciateTax.Name = "cbxDepreciateTax";
            this.cbxDepreciateTax.Size = new System.Drawing.Size(99, 17);
            this.cbxDepreciateTax.TabIndex = 3;
            this.cbxDepreciateTax.Text = "Depreciate Tax";
            this.cbxDepreciateTax.UseVisualStyleBackColor = true;
            // 
            // cbxDepreciateLabor
            // 
            this.cbxDepreciateLabor.AutoSize = true;
            this.cbxDepreciateLabor.Location = new System.Drawing.Point(228, 380);
            this.cbxDepreciateLabor.Name = "cbxDepreciateLabor";
            this.cbxDepreciateLabor.Size = new System.Drawing.Size(108, 17);
            this.cbxDepreciateLabor.TabIndex = 4;
            this.cbxDepreciateLabor.Text = "Depreciate Labor";
            this.cbxDepreciateLabor.UseVisualStyleBackColor = true;
            // 
            // lblDefaultItemDescription
            // 
            this.lblDefaultItemDescription.AutoSize = true;
            this.lblDefaultItemDescription.Location = new System.Drawing.Point(225, 401);
            this.lblDefaultItemDescription.Name = "lblDefaultItemDescription";
            this.lblDefaultItemDescription.Size = new System.Drawing.Size(123, 13);
            this.lblDefaultItemDescription.TabIndex = 7;
            this.lblDefaultItemDescription.Text = "Default Item Description:";
            // 
            // txtDefaultItemDescription
            // 
            this.txtDefaultItemDescription.Location = new System.Drawing.Point(354, 398);
            this.txtDefaultItemDescription.Name = "txtDefaultItemDescription";
            this.txtDefaultItemDescription.Size = new System.Drawing.Size(40, 20);
            this.txtDefaultItemDescription.TabIndex = 11;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(405, 401);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage.TabIndex = 12;
            this.lblPercentage.Text = "%";
            // 
            // btnExistingItems
            // 
            this.btnExistingItems.Location = new System.Drawing.Point(427, 390);
            this.btnExistingItems.Name = "btnExistingItems";
            this.btnExistingItems.Size = new System.Drawing.Size(115, 23);
            this.btnExistingItems.TabIndex = 13;
            this.btnExistingItems.Text = "Add to Existing Items";
            this.btnExistingItems.UseVisualStyleBackColor = true;
            // 
            // FEstSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 673);
            this.Controls.Add(this.btnExistingItems);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtDefaultItemDescription);
            this.Controls.Add(this.lblDefaultItemDescription);
            this.Controls.Add(this.gbxAdvancedPayment);
            this.Controls.Add(this.gbxMaterials);
            this.Controls.Add(this.gbxRegionalCostAdjustment);
            this.Controls.Add(this.gbxOverheadProfitOptions);
            this.Controls.Add(this.gbxTaxOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.cbxDepreciateTax);
            this.Controls.Add(this.cbxDepreciateLabor);
            this.Name = "FEstSettings";
            this.Text = "Estimate Settings";
            this.gbxTaxOptions.ResumeLayout(false);
            this.gbxTaxOptions.PerformLayout();
            this.gbxOverheadProfitOptions.ResumeLayout(false);
            this.gbxOverheadProfitOptions.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.gbxRegionalCostAdjustment.ResumeLayout(false);
            this.gbxRegionalCostAdjustment.PerformLayout();
            this.gbxMaterials.ResumeLayout(false);
            this.gbxMaterials.PerformLayout();
            this.gbxAdvancedPayment.ResumeLayout(false);
            this.gbxAdvancedPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxTaxOptions;
        private System.Windows.Forms.GroupBox gbxOverheadProfitOptions;
        private System.Windows.Forms.GroupBox gbxRegionalCostAdjustment;
        private System.Windows.Forms.GroupBox gbxMaterials;
        private System.Windows.Forms.GroupBox gbxAdvancedPayment;
        private System.Windows.Forms.CheckBox cbxTaxEstimate;
        private System.Windows.Forms.Label lblEquipmentRate;
        private System.Windows.Forms.Label lblLaborRate;
        private System.Windows.Forms.Label lblMaterialRate;
        private System.Windows.Forms.TextBox txtEquipmentRate;
        private System.Windows.Forms.TextBox txtLaborRate;
        private System.Windows.Forms.TextBox txtMaterialRate;
        private System.Windows.Forms.Label lblEquipmentRatePercentage;
        private System.Windows.Forms.Label lblLaborRatePercentage;
        private System.Windows.Forms.Label lblMaterialRatePercentage;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEquip;
        private System.Windows.Forms.Label lblLocationLabor;
        private System.Windows.Forms.Label lblLocationMaterial;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtLocationLabor;
        private System.Windows.Forms.TextBox txtEquip;
        private System.Windows.Forms.TextBox txtLocationMaterial;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCanadianRegion;
        private System.Windows.Forms.Button btnUSRegion;
        private System.Windows.Forms.Label lblOverlay;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnImportOverlay;
        private System.Windows.Forms.Button btnNewOverlay;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.ComboBox cbxOverlay;
        private System.Windows.Forms.ComboBox cbxDatabase;
        private System.Windows.Forms.Label lblAdvancedPayment;
        private System.Windows.Forms.TextBox txtAdvancedPayment;
        private System.Windows.Forms.CheckBox cbxDepreciateLabor;
        private System.Windows.Forms.CheckBox cbxDepreciateTax;
        private System.Windows.Forms.CheckBox cbxDepreciateOP;
        private System.Windows.Forms.CheckBox cbxnonCumulativeOP;
        private System.Windows.Forms.CheckBox cbxOPEstimate;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtOverhead;
        private System.Windows.Forms.Label lblOverheadPercentage;
        private System.Windows.Forms.Label lblProfitPercentage;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblOverhead;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.CheckBox cbxApplyTax;
        private System.Windows.Forms.RadioButton rboCoverageTotal;
        private System.Windows.Forms.RadioButton rboLineItemCost;
        private System.Windows.Forms.Label lblDefaultItemDescription;
        private System.Windows.Forms.TextBox txtDefaultItemDescription;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnExistingItems;
    }
}