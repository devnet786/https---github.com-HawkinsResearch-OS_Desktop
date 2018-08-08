namespace WindowsFormsApp1
{
    partial class FEditEstimate
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
            this.lblTitleText = new System.Windows.Forms.Label();
            this.cboCoverage = new System.Windows.Forms.ComboBox();
            this.lblCoverage = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblReserve = new System.Windows.Forms.Label();
            this.cbxReplacementCostCoverage = new System.Windows.Forms.CheckBox();
            this.gbLimit = new System.Windows.Forms.GroupBox();
            this.cbxLimit = new System.Windows.Forms.CheckBox();
            this.txtLimitAmount = new System.Windows.Forms.TextBox();
            this.lblLimitAmount = new System.Windows.Forms.Label();
            this.txtReserve = new System.Windows.Forms.TextBox();
            this.gbxDeductible = new System.Windows.Forms.GroupBox();
            this.cbxSharedWith = new System.Windows.Forms.ComboBox();
            this.lblSharedWith = new System.Windows.Forms.Label();
            this.rboSharedDeductible = new System.Windows.Forms.RadioButton();
            this.rboNoDeductible = new System.Windows.Forms.RadioButton();
            this.rboBlanketDeductible = new System.Windows.Forms.RadioButton();
            this.rboNormalDeductible = new System.Windows.Forms.RadioButton();
            this.lblDeductibleType = new System.Windows.Forms.Label();
            this.gbxDeductibleAmount = new System.Windows.Forms.GroupBox();
            this.lblPercentageOfLimit = new System.Windows.Forms.Label();
            this.txtDollarAmount = new System.Windows.Forms.TextBox();
            this.rboPercentageOfLimit = new System.Windows.Forms.RadioButton();
            this.rboDollarAmount = new System.Windows.Forms.RadioButton();
            this.txtPercentageOfLimit = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbLimit.SuspendLayout();
            this.gbxDeductible.SuspendLayout();
            this.gbxDeductibleAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Location = new System.Drawing.Point(1, 9);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(322, 13);
            this.lblTitleText.TabIndex = 0;
            this.lblTitleText.Text = "Please provide information for the coverage related to the estimate:";
            // 
            // cboCoverage
            // 
            this.cboCoverage.FormattingEnabled = true;
            this.cboCoverage.Location = new System.Drawing.Point(83, 38);
            this.cboCoverage.Name = "cboCoverage";
            this.cboCoverage.Size = new System.Drawing.Size(251, 21);
            this.cboCoverage.TabIndex = 3;
            // 
            // lblCoverage
            // 
            this.lblCoverage.AutoSize = true;
            this.lblCoverage.Location = new System.Drawing.Point(1, 41);
            this.lblCoverage.Name = "lblCoverage";
            this.lblCoverage.Size = new System.Drawing.Size(56, 13);
            this.lblCoverage.TabIndex = 4;
            this.lblCoverage.Text = "Coverage:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(1, 72);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblReserve
            // 
            this.lblReserve.AutoSize = true;
            this.lblReserve.Location = new System.Drawing.Point(1, 98);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(50, 13);
            this.lblReserve.TabIndex = 6;
            this.lblReserve.Text = "Reserve:";
            // 
            // cbxReplacementCostCoverage
            // 
            this.cbxReplacementCostCoverage.AutoSize = true;
            this.cbxReplacementCostCoverage.Location = new System.Drawing.Point(83, 128);
            this.cbxReplacementCostCoverage.Name = "cbxReplacementCostCoverage";
            this.cbxReplacementCostCoverage.Size = new System.Drawing.Size(162, 17);
            this.cbxReplacementCostCoverage.TabIndex = 7;
            this.cbxReplacementCostCoverage.Text = "Replacement Cost Coverage";
            this.cbxReplacementCostCoverage.UseVisualStyleBackColor = true;
            // 
            // gbLimit
            // 
            this.gbLimit.Controls.Add(this.cbxLimit);
            this.gbLimit.Controls.Add(this.txtLimitAmount);
            this.gbLimit.Controls.Add(this.lblLimitAmount);
            this.gbLimit.Location = new System.Drawing.Point(7, 151);
            this.gbLimit.Name = "gbLimit";
            this.gbLimit.Size = new System.Drawing.Size(327, 100);
            this.gbLimit.TabIndex = 8;
            this.gbLimit.TabStop = false;
            this.gbLimit.Text = "Limit";
            // 
            // cbxLimit
            // 
            this.cbxLimit.AutoSize = true;
            this.cbxLimit.Location = new System.Drawing.Point(10, 62);
            this.cbxLimit.Name = "cbxLimit";
            this.cbxLimit.Size = new System.Drawing.Size(217, 17);
            this.cbxLimit.TabIndex = 2;
            this.cbxLimit.Text = "Include limit in amount of total insurance ";
            this.cbxLimit.UseVisualStyleBackColor = true;
            // 
            // txtLimitAmount
            // 
            this.txtLimitAmount.Location = new System.Drawing.Point(76, 22);
            this.txtLimitAmount.Name = "txtLimitAmount";
            this.txtLimitAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLimitAmount.TabIndex = 1;
            // 
            // lblLimitAmount
            // 
            this.lblLimitAmount.AutoSize = true;
            this.lblLimitAmount.Location = new System.Drawing.Point(7, 29);
            this.lblLimitAmount.Name = "lblLimitAmount";
            this.lblLimitAmount.Size = new System.Drawing.Size(70, 13);
            this.lblLimitAmount.TabIndex = 0;
            this.lblLimitAmount.Text = "Limit Amount:";
            // 
            // txtReserve
            // 
            this.txtReserve.Location = new System.Drawing.Point(83, 91);
            this.txtReserve.Name = "txtReserve";
            this.txtReserve.Size = new System.Drawing.Size(100, 20);
            this.txtReserve.TabIndex = 9;
            // 
            // gbxDeductible
            // 
            this.gbxDeductible.Controls.Add(this.gbxDeductibleAmount);
            this.gbxDeductible.Controls.Add(this.cbxSharedWith);
            this.gbxDeductible.Controls.Add(this.lblSharedWith);
            this.gbxDeductible.Controls.Add(this.rboSharedDeductible);
            this.gbxDeductible.Controls.Add(this.rboNoDeductible);
            this.gbxDeductible.Controls.Add(this.rboBlanketDeductible);
            this.gbxDeductible.Controls.Add(this.rboNormalDeductible);
            this.gbxDeductible.Controls.Add(this.lblDeductibleType);
            this.gbxDeductible.Location = new System.Drawing.Point(7, 257);
            this.gbxDeductible.Name = "gbxDeductible";
            this.gbxDeductible.Size = new System.Drawing.Size(327, 273);
            this.gbxDeductible.TabIndex = 10;
            this.gbxDeductible.TabStop = false;
            this.gbxDeductible.Text = "Deductible Amount";
            // 
            // cbxSharedWith
            // 
            this.cbxSharedWith.FormattingEnabled = true;
            this.cbxSharedWith.Location = new System.Drawing.Point(121, 131);
            this.cbxSharedWith.Name = "cbxSharedWith";
            this.cbxSharedWith.Size = new System.Drawing.Size(171, 21);
            this.cbxSharedWith.TabIndex = 6;
            // 
            // lblSharedWith
            // 
            this.lblSharedWith.AutoSize = true;
            this.lblSharedWith.Location = new System.Drawing.Point(49, 137);
            this.lblSharedWith.Name = "lblSharedWith";
            this.lblSharedWith.Size = new System.Drawing.Size(66, 13);
            this.lblSharedWith.TabIndex = 5;
            this.lblSharedWith.Text = "Shared with:";
            // 
            // rboSharedDeductible
            // 
            this.rboSharedDeductible.AutoSize = true;
            this.rboSharedDeductible.Location = new System.Drawing.Point(3, 108);
            this.rboSharedDeductible.Name = "rboSharedDeductible";
            this.rboSharedDeductible.Size = new System.Drawing.Size(300, 17);
            this.rboSharedDeductible.TabIndex = 4;
            this.rboSharedDeductible.TabStop = true;
            this.rboSharedDeductible.Text = "This coverage shares a deductible with another coverage.";
            this.rboSharedDeductible.UseVisualStyleBackColor = true;
            // 
            // rboNoDeductible
            // 
            this.rboNoDeductible.AutoSize = true;
            this.rboNoDeductible.Location = new System.Drawing.Point(3, 84);
            this.rboNoDeductible.Name = "rboNoDeductible";
            this.rboNoDeductible.Size = new System.Drawing.Size(183, 17);
            this.rboNoDeductible.TabIndex = 3;
            this.rboNoDeductible.TabStop = true;
            this.rboNoDeductible.Text = "This coverage has no deductible.";
            this.rboNoDeductible.UseVisualStyleBackColor = true;
            // 
            // rboBlanketDeductible
            // 
            this.rboBlanketDeductible.AutoSize = true;
            this.rboBlanketDeductible.Location = new System.Drawing.Point(3, 61);
            this.rboBlanketDeductible.Name = "rboBlanketDeductible";
            this.rboBlanketDeductible.Size = new System.Drawing.Size(194, 17);
            this.rboBlanketDeductible.TabIndex = 2;
            this.rboBlanketDeductible.TabStop = true;
            this.rboBlanketDeductible.Text = "This claim has a blanket deductible.";
            this.rboBlanketDeductible.UseVisualStyleBackColor = true;
            // 
            // rboNormalDeductible
            // 
            this.rboNormalDeductible.AutoSize = true;
            this.rboNormalDeductible.Location = new System.Drawing.Point(3, 37);
            this.rboNormalDeductible.Name = "rboNormalDeductible";
            this.rboNormalDeductible.Size = new System.Drawing.Size(211, 17);
            this.rboNormalDeductible.TabIndex = 1;
            this.rboNormalDeductible.TabStop = true;
            this.rboNormalDeductible.Text = "This coverage has a normal deductible.";
            this.rboNormalDeductible.UseVisualStyleBackColor = true;
            // 
            // lblDeductibleType
            // 
            this.lblDeductibleType.AutoSize = true;
            this.lblDeductibleType.Location = new System.Drawing.Point(7, 20);
            this.lblDeductibleType.Name = "lblDeductibleType";
            this.lblDeductibleType.Size = new System.Drawing.Size(176, 13);
            this.lblDeductibleType.TabIndex = 0;
            this.lblDeductibleType.Text = "Please choose the deductible type: ";
            // 
            // gbxDeductibleAmount
            // 
            this.gbxDeductibleAmount.Controls.Add(this.txtPercentageOfLimit);
            this.gbxDeductibleAmount.Controls.Add(this.lblPercentageOfLimit);
            this.gbxDeductibleAmount.Controls.Add(this.txtDollarAmount);
            this.gbxDeductibleAmount.Controls.Add(this.rboPercentageOfLimit);
            this.gbxDeductibleAmount.Controls.Add(this.rboDollarAmount);
            this.gbxDeductibleAmount.Location = new System.Drawing.Point(5, 158);
            this.gbxDeductibleAmount.Name = "gbxDeductibleAmount";
            this.gbxDeductibleAmount.Size = new System.Drawing.Size(297, 100);
            this.gbxDeductibleAmount.TabIndex = 11;
            this.gbxDeductibleAmount.TabStop = false;
            this.gbxDeductibleAmount.Text = "Deductible Amount";
            // 
            // lblPercentageOfLimit
            // 
            this.lblPercentageOfLimit.AutoSize = true;
            this.lblPercentageOfLimit.Location = new System.Drawing.Point(185, 65);
            this.lblPercentageOfLimit.Name = "lblPercentageOfLimit";
            this.lblPercentageOfLimit.Size = new System.Drawing.Size(68, 13);
            this.lblPercentageOfLimit.TabIndex = 5;
            this.lblPercentageOfLimit.Text = "% of the limit.";
            // 
            // txtDollarAmount
            // 
            this.txtDollarAmount.Location = new System.Drawing.Point(121, 26);
            this.txtDollarAmount.Name = "txtDollarAmount";
            this.txtDollarAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDollarAmount.TabIndex = 4;
            // 
            // rboPercentageOfLimit
            // 
            this.rboPercentageOfLimit.AutoSize = true;
            this.rboPercentageOfLimit.Location = new System.Drawing.Point(3, 65);
            this.rboPercentageOfLimit.Name = "rboPercentageOfLimit";
            this.rboPercentageOfLimit.Size = new System.Drawing.Size(134, 17);
            this.rboPercentageOfLimit.TabIndex = 3;
            this.rboPercentageOfLimit.TabStop = true;
            this.rboPercentageOfLimit.Text = "By Percentage of Limit:";
            this.rboPercentageOfLimit.UseVisualStyleBackColor = true;
            // 
            // rboDollarAmount
            // 
            this.rboDollarAmount.AutoSize = true;
            this.rboDollarAmount.Location = new System.Drawing.Point(0, 29);
            this.rboDollarAmount.Name = "rboDollarAmount";
            this.rboDollarAmount.Size = new System.Drawing.Size(106, 17);
            this.rboDollarAmount.TabIndex = 2;
            this.rboDollarAmount.TabStop = true;
            this.rboDollarAmount.Text = "By Dollar Amount";
            this.rboDollarAmount.UseVisualStyleBackColor = true;
            // 
            // txtPercentageOfLimit
            // 
            this.txtPercentageOfLimit.Location = new System.Drawing.Point(142, 62);
            this.txtPercentageOfLimit.Name = "txtPercentageOfLimit";
            this.txtPercentageOfLimit.Size = new System.Drawing.Size(37, 20);
            this.txtPercentageOfLimit.TabIndex = 6;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(4, 536);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(44, 23);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 14;
            // 
            // FEditEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 565);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbxDeductible);
            this.Controls.Add(this.txtReserve);
            this.Controls.Add(this.gbLimit);
            this.Controls.Add(this.cbxReplacementCostCoverage);
            this.Controls.Add(this.lblReserve);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCoverage);
            this.Controls.Add(this.cboCoverage);
            this.Controls.Add(this.lblTitleText);
            this.Name = "FEditEstimate";
            this.Text = "Edit Estimate";
            this.gbLimit.ResumeLayout(false);
            this.gbLimit.PerformLayout();
            this.gbxDeductible.ResumeLayout(false);
            this.gbxDeductible.PerformLayout();
            this.gbxDeductibleAmount.ResumeLayout(false);
            this.gbxDeductibleAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.ComboBox cboCoverage;
        private System.Windows.Forms.Label lblCoverage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblReserve;
        private System.Windows.Forms.CheckBox cbxReplacementCostCoverage;
        private System.Windows.Forms.GroupBox gbLimit;
        private System.Windows.Forms.Label lblLimitAmount;
        private System.Windows.Forms.TextBox txtLimitAmount;
        private System.Windows.Forms.CheckBox cbxLimit;
        private System.Windows.Forms.TextBox txtReserve;
        private System.Windows.Forms.GroupBox gbxDeductible;
        private System.Windows.Forms.Label lblDeductibleType;
        private System.Windows.Forms.RadioButton rboNormalDeductible;
        private System.Windows.Forms.RadioButton rboBlanketDeductible;
        private System.Windows.Forms.RadioButton rboNoDeductible;
        private System.Windows.Forms.RadioButton rboSharedDeductible;
        private System.Windows.Forms.Label lblSharedWith;
        private System.Windows.Forms.ComboBox cbxSharedWith;
        private System.Windows.Forms.GroupBox gbxDeductibleAmount;
        private System.Windows.Forms.RadioButton rboPercentageOfLimit;
        private System.Windows.Forms.RadioButton rboDollarAmount;
        private System.Windows.Forms.TextBox txtDollarAmount;
        private System.Windows.Forms.Label lblPercentageOfLimit;
        private System.Windows.Forms.TextBox txtPercentageOfLimit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
    }
}