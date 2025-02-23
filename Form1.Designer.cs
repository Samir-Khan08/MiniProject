using System.Runtime.Remoting.Messaging;

namespace Number_Conversion_Program
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputConvLabel = new System.Windows.Forms.Label();
            this.inputBoxConv = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convFromBox = new System.Windows.Forms.ComboBox();
            this.numberConversionLabel = new System.Windows.Forms.Label();
            this.binaryAdditionLabel = new System.Windows.Forms.Label();
            this.inputBoxAdd1 = new System.Windows.Forms.TextBox();
            this.inputBoxAdd2 = new System.Windows.Forms.TextBox();
            this.binAddLabel1 = new System.Windows.Forms.Label();
            this.fromBase = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.convToBox = new System.Windows.Forms.ComboBox();
            this.toBase = new System.Windows.Forms.Label();
            this.binAddPlusSign = new System.Windows.Forms.Label();
            this.resetConvButton = new System.Windows.Forms.Button();
            this.calculateAdditionButton = new System.Windows.Forms.Button();
            this.resetAdditionButton = new System.Windows.Forms.Button();
            this.selectConvBottomButton = new System.Windows.Forms.Button();
            this.selectConvTopButton = new System.Windows.Forms.Button();
            this.selectAddButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.selectedConv = new System.Windows.Forms.Button();
            this.selectedAddButton = new System.Windows.Forms.Button();
            this.inputsRestricted = new System.Windows.Forms.Label();
            this.restrictionBin2 = new System.Windows.Forms.Label();
            this.restrictionHex1 = new System.Windows.Forms.Label();
            this.restrictionBin1 = new System.Windows.Forms.Label();
            this.restrictionHex3 = new System.Windows.Forms.Label();
            this.restrictionHex2 = new System.Windows.Forms.Label();
            this.restrictionDen1 = new System.Windows.Forms.Label();
            this.restrictionDen2 = new System.Windows.Forms.Label();
            this.chosenBin = new System.Windows.Forms.Label();
            this.chosenHex = new System.Windows.Forms.Label();
            this.chosenDen = new System.Windows.Forms.Label();
            this.convDesc1 = new System.Windows.Forms.Label();
            this.addDesc = new System.Windows.Forms.Label();
            this.convDesc2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputConvLabel
            // 
            this.inputConvLabel.AutoSize = true;
            this.inputConvLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.inputConvLabel.Location = new System.Drawing.Point(53, 92);
            this.inputConvLabel.Name = "inputConvLabel";
            this.inputConvLabel.Size = new System.Drawing.Size(100, 13);
            this.inputConvLabel.TabIndex = 2;
            this.inputConvLabel.Text = "Enter Your Number:";
            this.inputConvLabel.Visible = false;
            this.inputConvLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputBoxConv
            // 
            this.inputBoxConv.BackColor = System.Drawing.SystemColors.Window;
            this.inputBoxConv.Location = new System.Drawing.Point(56, 108);
            this.inputBoxConv.MaxLength = 8;
            this.inputBoxConv.Name = "inputBoxConv";
            this.inputBoxConv.Size = new System.Drawing.Size(151, 20);
            this.inputBoxConv.TabIndex = 3;
            this.inputBoxConv.Visible = false;
            this.inputBoxConv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputBoxConv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_convert_KeyPress);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(32)))));
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.convertButton.ForeColor = System.Drawing.SystemColors.Window;
            this.convertButton.Location = new System.Drawing.Point(54, 141);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(78, 36);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Visible = false;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // convFromBox
            // 
            this.convFromBox.BackColor = System.Drawing.SystemColors.Window;
            this.convFromBox.FormattingEnabled = true;
            this.convFromBox.Items.AddRange(new object[] {
            "Binary",
            "Denary",
            "Hexadecimal",
            "Please Select"});
            this.convFromBox.Location = new System.Drawing.Point(56, 110);
            this.convFromBox.Name = "convFromBox";
            this.convFromBox.Size = new System.Drawing.Size(151, 21);
            this.convFromBox.TabIndex = 5;
            this.convFromBox.Text = "Please Select";
            this.convFromBox.Visible = false;
            this.convFromBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // numberConversionLabel
            // 
            this.numberConversionLabel.AutoSize = true;
            this.numberConversionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.numberConversionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.numberConversionLabel.Location = new System.Drawing.Point(53, 57);
            this.numberConversionLabel.Name = "numberConversionLabel";
            this.numberConversionLabel.Size = new System.Drawing.Size(133, 15);
            this.numberConversionLabel.TabIndex = 7;
            this.numberConversionLabel.Text = "Number Conversion";
            this.numberConversionLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // binaryAdditionLabel
            // 
            this.binaryAdditionLabel.AutoSize = true;
            this.binaryAdditionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.binaryAdditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.binaryAdditionLabel.Location = new System.Drawing.Point(523, 56);
            this.binaryAdditionLabel.Name = "binaryAdditionLabel";
            this.binaryAdditionLabel.Size = new System.Drawing.Size(103, 15);
            this.binaryAdditionLabel.TabIndex = 8;
            this.binaryAdditionLabel.Text = "Binary Addition";
            this.binaryAdditionLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // inputBoxAdd1
            // 
            this.inputBoxAdd1.BackColor = System.Drawing.SystemColors.Window;
            this.inputBoxAdd1.Location = new System.Drawing.Point(523, 108);
            this.inputBoxAdd1.MaxLength = 8;
            this.inputBoxAdd1.Name = "inputBoxAdd1";
            this.inputBoxAdd1.Size = new System.Drawing.Size(151, 20);
            this.inputBoxAdd1.TabIndex = 9;
            this.inputBoxAdd1.Visible = false;
            this.inputBoxAdd1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.inputBoxAdd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_addition1_KeyPress);
            // 
            // inputBoxAdd2
            // 
            this.inputBoxAdd2.BackColor = System.Drawing.SystemColors.Window;
            this.inputBoxAdd2.Location = new System.Drawing.Point(523, 141);
            this.inputBoxAdd2.MaxLength = 8;
            this.inputBoxAdd2.Name = "inputBoxAdd2";
            this.inputBoxAdd2.Size = new System.Drawing.Size(151, 20);
            this.inputBoxAdd2.TabIndex = 10;
            this.inputBoxAdd2.Visible = false;
            this.inputBoxAdd2.TextChanged += new System.EventHandler(this.input_addition2_TextChanged);
            this.inputBoxAdd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_addition2_KeyPress);
            // 
            // binAddLabel1
            // 
            this.binAddLabel1.AutoSize = true;
            this.binAddLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.binAddLabel1.Location = new System.Drawing.Point(523, 89);
            this.binAddLabel1.Name = "binAddLabel1";
            this.binAddLabel1.Size = new System.Drawing.Size(136, 13);
            this.binAddLabel1.TabIndex = 11;
            this.binAddLabel1.Text = "Enter Two Binary Numbers:";
            this.binAddLabel1.Visible = false;
            this.binAddLabel1.Click += new System.EventHandler(this.label5_Click);
            // 
            // fromBase
            // 
            this.fromBase.AutoSize = true;
            this.fromBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.fromBase.Location = new System.Drawing.Point(53, 91);
            this.fromBase.Name = "fromBase";
            this.fromBase.Size = new System.Drawing.Size(60, 13);
            this.fromBase.TabIndex = 12;
            this.fromBase.Text = "From Base:";
            this.fromBase.Visible = false;
            this.fromBase.Click += new System.EventHandler(this.label6_Click);
            // 
            // convToBox
            // 
            this.convToBox.BackColor = System.Drawing.SystemColors.Window;
            this.convToBox.FormattingEnabled = true;
            this.convToBox.Items.AddRange(new object[] {
            "Binary",
            "Denary",
            "Hexadecimal",
            "Please Select"});
            this.convToBox.Location = new System.Drawing.Point(56, 150);
            this.convToBox.Name = "convToBox";
            this.convToBox.Size = new System.Drawing.Size(151, 21);
            this.convToBox.TabIndex = 13;
            this.convToBox.Text = "Please Select";
            this.convToBox.Visible = false;
            // 
            // toBase
            // 
            this.toBase.AutoSize = true;
            this.toBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.toBase.Location = new System.Drawing.Point(53, 134);
            this.toBase.Name = "toBase";
            this.toBase.Size = new System.Drawing.Size(50, 13);
            this.toBase.TabIndex = 14;
            this.toBase.Text = "To Base:";
            this.toBase.Visible = false;
            this.toBase.Click += new System.EventHandler(this.label7_Click);
            // 
            // binAddPlusSign
            // 
            this.binAddPlusSign.AutoSize = true;
            this.binAddPlusSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.binAddPlusSign.Location = new System.Drawing.Point(586, 128);
            this.binAddPlusSign.Name = "binAddPlusSign";
            this.binAddPlusSign.Size = new System.Drawing.Size(13, 13);
            this.binAddPlusSign.TabIndex = 15;
            this.binAddPlusSign.Text = "+";
            this.binAddPlusSign.Visible = false;
            this.binAddPlusSign.Click += new System.EventHandler(this.label1_Click);
            // 
            // resetConvButton
            // 
            this.resetConvButton.BackColor = System.Drawing.Color.Gray;
            this.resetConvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetConvButton.ForeColor = System.Drawing.SystemColors.Window;
            this.resetConvButton.Location = new System.Drawing.Point(138, 141);
            this.resetConvButton.Name = "resetConvButton";
            this.resetConvButton.Size = new System.Drawing.Size(69, 36);
            this.resetConvButton.TabIndex = 16;
            this.resetConvButton.Text = "Reset";
            this.resetConvButton.UseVisualStyleBackColor = false;
            this.resetConvButton.Visible = false;
            this.resetConvButton.Click += new System.EventHandler(this.RESETCONVERSION_Click);
            // 
            // calculateAdditionButton
            // 
            this.calculateAdditionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(32)))));
            this.calculateAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.calculateAdditionButton.ForeColor = System.Drawing.SystemColors.Window;
            this.calculateAdditionButton.Location = new System.Drawing.Point(521, 167);
            this.calculateAdditionButton.Name = "calculateAdditionButton";
            this.calculateAdditionButton.Size = new System.Drawing.Size(78, 36);
            this.calculateAdditionButton.TabIndex = 17;
            this.calculateAdditionButton.Text = "Calculate";
            this.calculateAdditionButton.UseVisualStyleBackColor = false;
            this.calculateAdditionButton.Visible = false;
            this.calculateAdditionButton.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // resetAdditionButton
            // 
            this.resetAdditionButton.BackColor = System.Drawing.Color.Gray;
            this.resetAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAdditionButton.ForeColor = System.Drawing.SystemColors.Window;
            this.resetAdditionButton.Location = new System.Drawing.Point(605, 167);
            this.resetAdditionButton.Name = "resetAdditionButton";
            this.resetAdditionButton.Size = new System.Drawing.Size(69, 36);
            this.resetAdditionButton.TabIndex = 18;
            this.resetAdditionButton.Text = "Reset";
            this.resetAdditionButton.UseVisualStyleBackColor = false;
            this.resetAdditionButton.Visible = false;
            this.resetAdditionButton.Click += new System.EventHandler(this.RESETCALCULATION_Click);
            // 
            // selectConvBottomButton
            // 
            this.selectConvBottomButton.BackColor = System.Drawing.Color.Blue;
            this.selectConvBottomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.selectConvBottomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectConvBottomButton.Location = new System.Drawing.Point(90, 177);
            this.selectConvBottomButton.Name = "selectConvBottomButton";
            this.selectConvBottomButton.Size = new System.Drawing.Size(78, 36);
            this.selectConvBottomButton.TabIndex = 19;
            this.selectConvBottomButton.Text = "Select";
            this.selectConvBottomButton.UseVisualStyleBackColor = false;
            this.selectConvBottomButton.Visible = false;
            this.selectConvBottomButton.Click += new System.EventHandler(this.select_conv_Click);
            // 
            // selectConvTopButton
            // 
            this.selectConvTopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.selectConvTopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.selectConvTopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectConvTopButton.Location = new System.Drawing.Point(192, 46);
            this.selectConvTopButton.Name = "selectConvTopButton";
            this.selectConvTopButton.Size = new System.Drawing.Size(78, 36);
            this.selectConvTopButton.TabIndex = 20;
            this.selectConvTopButton.Text = "Select";
            this.selectConvTopButton.UseVisualStyleBackColor = false;
            this.selectConvTopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectAddButton
            // 
            this.selectAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.selectAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.selectAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectAddButton.Location = new System.Drawing.Point(445, 46);
            this.selectAddButton.Name = "selectAddButton";
            this.selectAddButton.Size = new System.Drawing.Size(78, 36);
            this.selectAddButton.TabIndex = 21;
            this.selectAddButton.Text = "Select";
            this.selectAddButton.UseVisualStyleBackColor = false;
            this.selectAddButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(323, 222);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 36);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // selectedConv
            // 
            this.selectedConv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectedConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.selectedConv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedConv.Location = new System.Drawing.Point(192, 46);
            this.selectedConv.Name = "selectedConv";
            this.selectedConv.Size = new System.Drawing.Size(78, 36);
            this.selectedConv.TabIndex = 23;
            this.selectedConv.Text = "Selected";
            this.selectedConv.UseVisualStyleBackColor = false;
            this.selectedConv.Visible = false;
            this.selectedConv.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectedAddButton
            // 
            this.selectedAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectedAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.selectedAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedAddButton.Location = new System.Drawing.Point(445, 45);
            this.selectedAddButton.Name = "selectedAddButton";
            this.selectedAddButton.Size = new System.Drawing.Size(78, 36);
            this.selectedAddButton.TabIndex = 24;
            this.selectedAddButton.Text = "Selected";
            this.selectedAddButton.UseVisualStyleBackColor = false;
            this.selectedAddButton.Visible = false;
            this.selectedAddButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // inputsRestricted
            // 
            this.inputsRestricted.AutoSize = true;
            this.inputsRestricted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.inputsRestricted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputsRestricted.Location = new System.Drawing.Point(300, 90);
            this.inputsRestricted.Name = "inputsRestricted";
            this.inputsRestricted.Size = new System.Drawing.Size(127, 13);
            this.inputsRestricted.TabIndex = 25;
            this.inputsRestricted.Text = "Inputs Are Restricted";
            this.inputsRestricted.Visible = false;
            this.inputsRestricted.Click += new System.EventHandler(this.label8_Click);
            // 
            // restrictionBin2
            // 
            this.restrictionBin2.AutoSize = true;
            this.restrictionBin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionBin2.Location = new System.Drawing.Point(348, 122);
            this.restrictionBin2.Name = "restrictionBin2";
            this.restrictionBin2.Size = new System.Drawing.Size(22, 13);
            this.restrictionBin2.TabIndex = 26;
            this.restrictionBin2.Text = "1,0";
            this.restrictionBin2.Visible = false;
            this.restrictionBin2.Click += new System.EventHandler(this.label9_Click);
            // 
            // restrictionHex1
            // 
            this.restrictionHex1.AutoSize = true;
            this.restrictionHex1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionHex1.Location = new System.Drawing.Point(328, 141);
            this.restrictionHex1.Name = "restrictionHex1";
            this.restrictionHex1.Size = new System.Drawing.Size(71, 13);
            this.restrictionHex1.TabIndex = 27;
            this.restrictionHex1.Text = "Hexadecimal:";
            this.restrictionHex1.Visible = false;
            // 
            // restrictionBin1
            // 
            this.restrictionBin1.AutoSize = true;
            this.restrictionBin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionBin1.Location = new System.Drawing.Point(320, 108);
            this.restrictionBin1.Name = "restrictionBin1";
            this.restrictionBin1.Size = new System.Drawing.Size(90, 13);
            this.restrictionBin1.TabIndex = 28;
            this.restrictionBin1.Text = "Binary (Length 8):";
            this.restrictionBin1.Visible = false;
            this.restrictionBin1.Click += new System.EventHandler(this.label11_Click);
            // 
            // restrictionHex3
            // 
            this.restrictionHex3.AutoSize = true;
            this.restrictionHex3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionHex3.Location = new System.Drawing.Point(288, 168);
            this.restrictionHex3.Name = "restrictionHex3";
            this.restrictionHex3.Size = new System.Drawing.Size(154, 13);
            this.restrictionHex3.TabIndex = 29;
            this.restrictionHex3.Text = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F";
            this.restrictionHex3.Visible = false;
            this.restrictionHex3.Click += new System.EventHandler(this.label12_Click);
            // 
            // restrictionHex2
            // 
            this.restrictionHex2.AutoSize = true;
            this.restrictionHex2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionHex2.Location = new System.Drawing.Point(285, 154);
            this.restrictionHex2.Name = "restrictionHex2";
            this.restrictionHex2.Size = new System.Drawing.Size(154, 13);
            this.restrictionHex2.TabIndex = 30;
            this.restrictionHex2.Text = "(Must Be Capitalised, Length 2)";
            this.restrictionHex2.Visible = false;
            this.restrictionHex2.Click += new System.EventHandler(this.label13_Click);
            // 
            // restrictionDen1
            // 
            this.restrictionDen1.AutoSize = true;
            this.restrictionDen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionDen1.Location = new System.Drawing.Point(314, 188);
            this.restrictionDen1.Name = "restrictionDen1";
            this.restrictionDen1.Size = new System.Drawing.Size(93, 13);
            this.restrictionDen1.TabIndex = 31;
            this.restrictionDen1.Text = "Denary (max 255):";
            this.restrictionDen1.Visible = false;
            // 
            // restrictionDen2
            // 
            this.restrictionDen2.AutoSize = true;
            this.restrictionDen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.restrictionDen2.Location = new System.Drawing.Point(313, 202);
            this.restrictionDen2.Name = "restrictionDen2";
            this.restrictionDen2.Size = new System.Drawing.Size(94, 13);
            this.restrictionDen2.TabIndex = 32;
            this.restrictionDen2.Text = "0,1,2,3,4,5,6,7,8,9";
            this.restrictionDen2.Visible = false;
            // 
            // chosenBin
            // 
            this.chosenBin.AutoSize = true;
            this.chosenBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenBin.ForeColor = System.Drawing.Color.Green;
            this.chosenBin.Location = new System.Drawing.Point(261, 108);
            this.chosenBin.Name = "chosenBin";
            this.chosenBin.Size = new System.Drawing.Size(62, 13);
            this.chosenBin.TabIndex = 33;
            this.chosenBin.Text = "CHOSEN:";
            this.chosenBin.Visible = false;
            this.chosenBin.Click += new System.EventHandler(this.label16_Click);
            // 
            // chosenHex
            // 
            this.chosenHex.AutoSize = true;
            this.chosenHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenHex.ForeColor = System.Drawing.Color.Green;
            this.chosenHex.Location = new System.Drawing.Point(269, 141);
            this.chosenHex.Name = "chosenHex";
            this.chosenHex.Size = new System.Drawing.Size(62, 13);
            this.chosenHex.TabIndex = 34;
            this.chosenHex.Text = "CHOSEN:";
            this.chosenHex.Visible = false;
            // 
            // chosenDen
            // 
            this.chosenDen.AutoSize = true;
            this.chosenDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenDen.ForeColor = System.Drawing.Color.Green;
            this.chosenDen.Location = new System.Drawing.Point(254, 188);
            this.chosenDen.Name = "chosenDen";
            this.chosenDen.Size = new System.Drawing.Size(62, 13);
            this.chosenDen.TabIndex = 35;
            this.chosenDen.Text = "CHOSEN:";
            this.chosenDen.Visible = false;
            // 
            // convDesc1
            // 
            this.convDesc1.AutoSize = true;
            this.convDesc1.Location = new System.Drawing.Point(53, 84);
            this.convDesc1.Name = "convDesc1";
            this.convDesc1.Size = new System.Drawing.Size(92, 13);
            this.convDesc1.TabIndex = 36;
            this.convDesc1.Text = "Convert Between:";
            this.convDesc1.Click += new System.EventHandler(this.label19_Click);
            // 
            // addDesc
            // 
            this.addDesc.AutoSize = true;
            this.addDesc.Location = new System.Drawing.Point(524, 84);
            this.addDesc.Name = "addDesc";
            this.addDesc.Size = new System.Drawing.Size(151, 13);
            this.addDesc.TabIndex = 37;
            this.addDesc.Text = "Add Two 8-Bit Binary Numbers";
            // 
            // convDesc2
            // 
            this.convDesc2.AutoSize = true;
            this.convDesc2.Location = new System.Drawing.Point(50, 97);
            this.convDesc2.Name = "convDesc2";
            this.convDesc2.Size = new System.Drawing.Size(188, 13);
            this.convDesc2.TabIndex = 38;
            this.convDesc2.Text = " 8-Bit Binary, Denary and Hexadecimal";
            this.convDesc2.Click += new System.EventHandler(this.convDesc2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 361);
            this.Controls.Add(this.convDesc2);
            this.Controls.Add(this.addDesc);
            this.Controls.Add(this.convDesc1);
            this.Controls.Add(this.chosenDen);
            this.Controls.Add(this.chosenHex);
            this.Controls.Add(this.chosenBin);
            this.Controls.Add(this.restrictionDen2);
            this.Controls.Add(this.restrictionDen1);
            this.Controls.Add(this.restrictionHex2);
            this.Controls.Add(this.restrictionHex3);
            this.Controls.Add(this.restrictionBin1);
            this.Controls.Add(this.restrictionHex1);
            this.Controls.Add(this.restrictionBin2);
            this.Controls.Add(this.inputsRestricted);
            this.Controls.Add(this.selectedAddButton);
            this.Controls.Add(this.selectedConv);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.selectAddButton);
            this.Controls.Add(this.selectConvTopButton);
            this.Controls.Add(this.selectConvBottomButton);
            this.Controls.Add(this.resetAdditionButton);
            this.Controls.Add(this.calculateAdditionButton);
            this.Controls.Add(this.resetConvButton);
            this.Controls.Add(this.binAddPlusSign);
            this.Controls.Add(this.toBase);
            this.Controls.Add(this.convToBox);
            this.Controls.Add(this.fromBase);
            this.Controls.Add(this.binAddLabel1);
            this.Controls.Add(this.inputBoxAdd2);
            this.Controls.Add(this.inputBoxAdd1);
            this.Controls.Add(this.binaryAdditionLabel);
            this.Controls.Add(this.numberConversionLabel);
            this.Controls.Add(this.convFromBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputBoxConv);
            this.Controls.Add(this.inputConvLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 400);
            this.MinimumSize = new System.Drawing.Size(746, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inputConvLabel;
        private System.Windows.Forms.TextBox inputBoxConv;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox convFromBox;
        private System.Windows.Forms.Label numberConversionLabel;
        private System.Windows.Forms.Label binaryAdditionLabel;
        private System.Windows.Forms.TextBox inputBoxAdd1;
        private System.Windows.Forms.TextBox inputBoxAdd2;
        private System.Windows.Forms.Label binAddLabel1;
        private System.Windows.Forms.Label fromBase;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox convToBox;
        private System.Windows.Forms.Label binAddPlusSign;
        private System.Windows.Forms.Button resetConvButton;
        private System.Windows.Forms.Button calculateAdditionButton;
        private System.Windows.Forms.Button resetAdditionButton;
        private System.Windows.Forms.Button selectConvBottomButton;
        private System.Windows.Forms.Button selectConvTopButton;
        private System.Windows.Forms.Button selectAddButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button selectedConv;
        private System.Windows.Forms.Button selectedAddButton;
        private System.Windows.Forms.Label inputsRestricted;
        private System.Windows.Forms.Label restrictionBin2;
        private System.Windows.Forms.Label restrictionHex1;
        private System.Windows.Forms.Label restrictionBin1;
        private System.Windows.Forms.Label restrictionHex3;
        private System.Windows.Forms.Label restrictionHex2;
        private System.Windows.Forms.Label restrictionDen1;
        private System.Windows.Forms.Label restrictionDen2;
        private System.Windows.Forms.Label chosenBin;
        private System.Windows.Forms.Label chosenHex;
        private System.Windows.Forms.Label chosenDen;
        private System.Windows.Forms.Label convDesc1;
        private System.Windows.Forms.Label addDesc;
        private System.Windows.Forms.Label convDesc2;
        private System.Windows.Forms.Label toBase;
    }
}

