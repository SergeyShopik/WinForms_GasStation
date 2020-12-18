namespace GasStation
{
    partial class MainForm
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
            this.Fuel = new System.Windows.Forms.GroupBox();
            this.Cafe = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelGas = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxFuelTypes = new System.Windows.Forms.ComboBox();
            this.textBoxPriceValue = new System.Windows.Forms.TextBox();
            this.labelPriceDollarSign = new System.Windows.Forms.Label();
            this.radioButtonLiters = new System.Windows.Forms.RadioButton();
            this.radioButtonFuelSum = new System.Windows.Forms.RadioButton();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.textBoxFuelSum = new System.Windows.Forms.TextBox();
            this.labelLitres = new System.Windows.Forms.Label();
            this.labelSumDollarSign = new System.Windows.Forms.Label();
            this.groupBoxFuelCost = new System.Windows.Forms.GroupBox();
            this.textBoxFuelCost = new System.Windows.Forms.TextBox();
            this.groupBoxCafeCost = new System.Windows.Forms.GroupBox();
            this.textBoxCafeCost = new System.Windows.Forms.TextBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.checkBoxCocaCola = new System.Windows.Forms.CheckBox();
            this.checkBoxChocolateBar = new System.Windows.Forms.CheckBox();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.labelCafePrice = new System.Windows.Forms.Label();
            this.labelCafeQuantity = new System.Windows.Forms.Label();
            this.textBoxHotDog = new System.Windows.Forms.TextBox();
            this.textBoxHotDogQuantity = new System.Windows.Forms.TextBox();
            this.textBoxCola = new System.Windows.Forms.TextBox();
            this.textBoxChocolate = new System.Windows.Forms.TextBox();
            this.textBoxWater = new System.Windows.Forms.TextBox();
            this.textBoxColaQuantity = new System.Windows.Forms.TextBox();
            this.textBoxChocolateQuantity = new System.Windows.Forms.TextBox();
            this.textBoxWaterQuantity = new System.Windows.Forms.TextBox();
            this.labelHotDogDollarSign = new System.Windows.Forms.Label();
            this.labelColaDollarSign = new System.Windows.Forms.Label();
            this.labelChocolateDollarSign = new System.Windows.Forms.Label();
            this.labelWaterDollarSign = new System.Windows.Forms.Label();
            this.buttonCalculateTotal = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.Fuel.SuspendLayout();
            this.Cafe.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxFuelCost.SuspendLayout();
            this.groupBoxCafeCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fuel
            // 
            this.Fuel.Controls.Add(this.groupBoxFuelCost);
            this.Fuel.Controls.Add(this.labelSumDollarSign);
            this.Fuel.Controls.Add(this.labelLitres);
            this.Fuel.Controls.Add(this.textBoxFuelSum);
            this.Fuel.Controls.Add(this.textBoxLiters);
            this.Fuel.Controls.Add(this.radioButtonFuelSum);
            this.Fuel.Controls.Add(this.radioButtonLiters);
            this.Fuel.Controls.Add(this.labelPriceDollarSign);
            this.Fuel.Controls.Add(this.textBoxPriceValue);
            this.Fuel.Controls.Add(this.textBoxFuelTypes);
            this.Fuel.Controls.Add(this.labelPrice);
            this.Fuel.Controls.Add(this.labelGas);
            this.Fuel.Location = new System.Drawing.Point(12, 12);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(501, 461);
            this.Fuel.TabIndex = 0;
            this.Fuel.TabStop = false;
            this.Fuel.Text = "Fuel";
            this.Fuel.Enter += new System.EventHandler(this.Fuel_Enter);
            // 
            // Cafe
            // 
            this.Cafe.Controls.Add(this.labelWaterDollarSign);
            this.Cafe.Controls.Add(this.labelChocolateDollarSign);
            this.Cafe.Controls.Add(this.labelColaDollarSign);
            this.Cafe.Controls.Add(this.labelHotDogDollarSign);
            this.Cafe.Controls.Add(this.textBoxWaterQuantity);
            this.Cafe.Controls.Add(this.textBoxChocolateQuantity);
            this.Cafe.Controls.Add(this.textBoxColaQuantity);
            this.Cafe.Controls.Add(this.textBoxWater);
            this.Cafe.Controls.Add(this.textBoxChocolate);
            this.Cafe.Controls.Add(this.textBoxCola);
            this.Cafe.Controls.Add(this.textBoxHotDogQuantity);
            this.Cafe.Controls.Add(this.textBoxHotDog);
            this.Cafe.Controls.Add(this.labelCafeQuantity);
            this.Cafe.Controls.Add(this.labelCafePrice);
            this.Cafe.Controls.Add(this.checkBoxWater);
            this.Cafe.Controls.Add(this.checkBoxChocolateBar);
            this.Cafe.Controls.Add(this.checkBoxCocaCola);
            this.Cafe.Controls.Add(this.checkBoxHotDog);
            this.Cafe.Controls.Add(this.groupBoxCafeCost);
            this.Cafe.Location = new System.Drawing.Point(511, 12);
            this.Cafe.Name = "Cafe";
            this.Cafe.Size = new System.Drawing.Size(501, 461);
            this.Cafe.TabIndex = 1;
            this.Cafe.TabStop = false;
            this.Cafe.Text = "Cafe";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxTotalCost);
            this.groupBoxResult.Controls.Add(this.labelTotal);
            this.groupBoxResult.Controls.Add(this.buttonCalculateTotal);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 479);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(1000, 182);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            // 
            // labelGas
            // 
            this.labelGas.AutoSize = true;
            this.labelGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGas.Location = new System.Drawing.Point(38, 45);
            this.labelGas.Name = "labelGas";
            this.labelGas.Size = new System.Drawing.Size(52, 29);
            this.labelGas.TabIndex = 0;
            this.labelGas.Text = "gas";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(38, 97);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(67, 29);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "price";
            // 
            // textBoxFuelTypes
            // 
            this.textBoxFuelTypes.FormattingEnabled = true;
            this.textBoxFuelTypes.Location = new System.Drawing.Point(172, 45);
            this.textBoxFuelTypes.Name = "textBoxFuelTypes";
            this.textBoxFuelTypes.Size = new System.Drawing.Size(218, 28);
            this.textBoxFuelTypes.TabIndex = 2;
            // 
            // textBoxPriceValue
            // 
            this.textBoxPriceValue.Location = new System.Drawing.Point(172, 99);
            this.textBoxPriceValue.Name = "textBoxPriceValue";
            this.textBoxPriceValue.Size = new System.Drawing.Size(218, 26);
            this.textBoxPriceValue.TabIndex = 3;
            // 
            // labelPriceDollarSign
            // 
            this.labelPriceDollarSign.AutoSize = true;
            this.labelPriceDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceDollarSign.Location = new System.Drawing.Point(396, 97);
            this.labelPriceDollarSign.Name = "labelPriceDollarSign";
            this.labelPriceDollarSign.Size = new System.Drawing.Size(26, 29);
            this.labelPriceDollarSign.TabIndex = 4;
            this.labelPriceDollarSign.Text = "$";
            this.labelPriceDollarSign.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonLiters
            // 
            this.radioButtonLiters.AutoSize = true;
            this.radioButtonLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLiters.Location = new System.Drawing.Point(15, 177);
            this.radioButtonLiters.Name = "radioButtonLiters";
            this.radioButtonLiters.Size = new System.Drawing.Size(90, 33);
            this.radioButtonLiters.TabIndex = 5;
            this.radioButtonLiters.TabStop = true;
            this.radioButtonLiters.Text = "liters";
            this.radioButtonLiters.UseVisualStyleBackColor = true;
            this.radioButtonLiters.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFuelSum
            // 
            this.radioButtonFuelSum.AutoSize = true;
            this.radioButtonFuelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFuelSum.Location = new System.Drawing.Point(15, 221);
            this.radioButtonFuelSum.Name = "radioButtonFuelSum";
            this.radioButtonFuelSum.Size = new System.Drawing.Size(83, 33);
            this.radioButtonFuelSum.TabIndex = 6;
            this.radioButtonFuelSum.TabStop = true;
            this.radioButtonFuelSum.Text = "sum";
            this.radioButtonFuelSum.UseVisualStyleBackColor = true;
            // 
            // textBoxLiters
            // 
            this.textBoxLiters.Location = new System.Drawing.Point(172, 183);
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.Size = new System.Drawing.Size(218, 26);
            this.textBoxLiters.TabIndex = 7;
            // 
            // textBoxFuelSum
            // 
            this.textBoxFuelSum.Location = new System.Drawing.Point(172, 227);
            this.textBoxFuelSum.Name = "textBoxFuelSum";
            this.textBoxFuelSum.Size = new System.Drawing.Size(218, 26);
            this.textBoxFuelSum.TabIndex = 8;
            // 
            // labelLitres
            // 
            this.labelLitres.AutoSize = true;
            this.labelLitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLitres.Location = new System.Drawing.Point(396, 181);
            this.labelLitres.Name = "labelLitres";
            this.labelLitres.Size = new System.Drawing.Size(26, 29);
            this.labelLitres.TabIndex = 9;
            this.labelLitres.Text = "L";
            // 
            // labelSumDollarSign
            // 
            this.labelSumDollarSign.AutoSize = true;
            this.labelSumDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumDollarSign.Location = new System.Drawing.Point(396, 225);
            this.labelSumDollarSign.Name = "labelSumDollarSign";
            this.labelSumDollarSign.Size = new System.Drawing.Size(26, 29);
            this.labelSumDollarSign.TabIndex = 10;
            this.labelSumDollarSign.Text = "$";
            // 
            // groupBoxFuelCost
            // 
            this.groupBoxFuelCost.Controls.Add(this.textBoxFuelCost);
            this.groupBoxFuelCost.Location = new System.Drawing.Point(6, 293);
            this.groupBoxFuelCost.Name = "groupBoxFuelCost";
            this.groupBoxFuelCost.Size = new System.Drawing.Size(487, 162);
            this.groupBoxFuelCost.TabIndex = 11;
            this.groupBoxFuelCost.TabStop = false;
            this.groupBoxFuelCost.Text = "Fuel cost";
            // 
            // textBoxFuelCost
            // 
            this.textBoxFuelCost.Location = new System.Drawing.Point(9, 26);
            this.textBoxFuelCost.Multiline = true;
            this.textBoxFuelCost.Name = "textBoxFuelCost";
            this.textBoxFuelCost.Size = new System.Drawing.Size(472, 130);
            this.textBoxFuelCost.TabIndex = 0;
            // 
            // groupBoxCafeCost
            // 
            this.groupBoxCafeCost.Controls.Add(this.textBoxCafeCost);
            this.groupBoxCafeCost.Location = new System.Drawing.Point(8, 293);
            this.groupBoxCafeCost.Name = "groupBoxCafeCost";
            this.groupBoxCafeCost.Size = new System.Drawing.Size(487, 162);
            this.groupBoxCafeCost.TabIndex = 12;
            this.groupBoxCafeCost.TabStop = false;
            this.groupBoxCafeCost.Text = "Cafe cost";
            // 
            // textBoxCafeCost
            // 
            this.textBoxCafeCost.Location = new System.Drawing.Point(9, 26);
            this.textBoxCafeCost.Multiline = true;
            this.textBoxCafeCost.Name = "textBoxCafeCost";
            this.textBoxCafeCost.Size = new System.Drawing.Size(472, 130);
            this.textBoxCafeCost.TabIndex = 0;
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHotDog.Location = new System.Drawing.Point(17, 59);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(108, 29);
            this.checkBoxHotDog.TabIndex = 13;
            this.checkBoxHotDog.Text = "Hot-dog";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            // 
            // checkBoxCocaCola
            // 
            this.checkBoxCocaCola.AutoSize = true;
            this.checkBoxCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCocaCola.Location = new System.Drawing.Point(17, 113);
            this.checkBoxCocaCola.Name = "checkBoxCocaCola";
            this.checkBoxCocaCola.Size = new System.Drawing.Size(128, 29);
            this.checkBoxCocaCola.TabIndex = 14;
            this.checkBoxCocaCola.Text = "Coca-cola";
            this.checkBoxCocaCola.UseVisualStyleBackColor = true;
            // 
            // checkBoxChocolateBar
            // 
            this.checkBoxChocolateBar.AutoSize = true;
            this.checkBoxChocolateBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChocolateBar.Location = new System.Drawing.Point(17, 167);
            this.checkBoxChocolateBar.Name = "checkBoxChocolateBar";
            this.checkBoxChocolateBar.Size = new System.Drawing.Size(160, 29);
            this.checkBoxChocolateBar.TabIndex = 15;
            this.checkBoxChocolateBar.Text = "Chocolate bar";
            this.checkBoxChocolateBar.UseVisualStyleBackColor = true;
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWater.Location = new System.Drawing.Point(17, 221);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(91, 29);
            this.checkBoxWater.TabIndex = 16;
            this.checkBoxWater.Text = "Water";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            // 
            // labelCafePrice
            // 
            this.labelCafePrice.AutoSize = true;
            this.labelCafePrice.Location = new System.Drawing.Point(206, 25);
            this.labelCafePrice.Name = "labelCafePrice";
            this.labelCafePrice.Size = new System.Drawing.Size(43, 20);
            this.labelCafePrice.TabIndex = 17;
            this.labelCafePrice.Text = "price";
            this.labelCafePrice.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelCafeQuantity
            // 
            this.labelCafeQuantity.AutoSize = true;
            this.labelCafeQuantity.Location = new System.Drawing.Point(366, 25);
            this.labelCafeQuantity.Name = "labelCafeQuantity";
            this.labelCafeQuantity.Size = new System.Drawing.Size(65, 20);
            this.labelCafeQuantity.TabIndex = 18;
            this.labelCafeQuantity.Text = "quantity";
            // 
            // textBoxHotDog
            // 
            this.textBoxHotDog.Location = new System.Drawing.Point(210, 62);
            this.textBoxHotDog.Name = "textBoxHotDog";
            this.textBoxHotDog.Size = new System.Drawing.Size(100, 26);
            this.textBoxHotDog.TabIndex = 19;
            // 
            // textBoxHotDogQuantity
            // 
            this.textBoxHotDogQuantity.Location = new System.Drawing.Point(370, 62);
            this.textBoxHotDogQuantity.Name = "textBoxHotDogQuantity";
            this.textBoxHotDogQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxHotDogQuantity.TabIndex = 20;
            // 
            // textBoxCola
            // 
            this.textBoxCola.Location = new System.Drawing.Point(210, 115);
            this.textBoxCola.Name = "textBoxCola";
            this.textBoxCola.Size = new System.Drawing.Size(100, 26);
            this.textBoxCola.TabIndex = 21;
            // 
            // textBoxChocolate
            // 
            this.textBoxChocolate.Location = new System.Drawing.Point(210, 170);
            this.textBoxChocolate.Name = "textBoxChocolate";
            this.textBoxChocolate.Size = new System.Drawing.Size(100, 26);
            this.textBoxChocolate.TabIndex = 22;
            // 
            // textBoxWater
            // 
            this.textBoxWater.Location = new System.Drawing.Point(210, 224);
            this.textBoxWater.Name = "textBoxWater";
            this.textBoxWater.Size = new System.Drawing.Size(100, 26);
            this.textBoxWater.TabIndex = 23;
            // 
            // textBoxColaQuantity
            // 
            this.textBoxColaQuantity.Location = new System.Drawing.Point(370, 116);
            this.textBoxColaQuantity.Name = "textBoxColaQuantity";
            this.textBoxColaQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxColaQuantity.TabIndex = 24;
            // 
            // textBoxChocolateQuantity
            // 
            this.textBoxChocolateQuantity.Location = new System.Drawing.Point(370, 170);
            this.textBoxChocolateQuantity.Name = "textBoxChocolateQuantity";
            this.textBoxChocolateQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxChocolateQuantity.TabIndex = 25;
            this.textBoxChocolateQuantity.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxWaterQuantity
            // 
            this.textBoxWaterQuantity.Location = new System.Drawing.Point(370, 225);
            this.textBoxWaterQuantity.Name = "textBoxWaterQuantity";
            this.textBoxWaterQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxWaterQuantity.TabIndex = 26;
            // 
            // labelHotDogDollarSign
            // 
            this.labelHotDogDollarSign.AutoSize = true;
            this.labelHotDogDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotDogDollarSign.Location = new System.Drawing.Point(316, 63);
            this.labelHotDogDollarSign.Name = "labelHotDogDollarSign";
            this.labelHotDogDollarSign.Size = new System.Drawing.Size(23, 25);
            this.labelHotDogDollarSign.TabIndex = 12;
            this.labelHotDogDollarSign.Text = "$";
            // 
            // labelColaDollarSign
            // 
            this.labelColaDollarSign.AutoSize = true;
            this.labelColaDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColaDollarSign.Location = new System.Drawing.Point(316, 116);
            this.labelColaDollarSign.Name = "labelColaDollarSign";
            this.labelColaDollarSign.Size = new System.Drawing.Size(23, 25);
            this.labelColaDollarSign.TabIndex = 27;
            this.labelColaDollarSign.Text = "$";
            // 
            // labelChocolateDollarSign
            // 
            this.labelChocolateDollarSign.AutoSize = true;
            this.labelChocolateDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChocolateDollarSign.Location = new System.Drawing.Point(316, 171);
            this.labelChocolateDollarSign.Name = "labelChocolateDollarSign";
            this.labelChocolateDollarSign.Size = new System.Drawing.Size(23, 25);
            this.labelChocolateDollarSign.TabIndex = 28;
            this.labelChocolateDollarSign.Text = "$";
            // 
            // labelWaterDollarSign
            // 
            this.labelWaterDollarSign.AutoSize = true;
            this.labelWaterDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWaterDollarSign.Location = new System.Drawing.Point(316, 225);
            this.labelWaterDollarSign.Name = "labelWaterDollarSign";
            this.labelWaterDollarSign.Size = new System.Drawing.Size(23, 25);
            this.labelWaterDollarSign.TabIndex = 29;
            this.labelWaterDollarSign.Text = "$";
            // 
            // buttonCalculateTotal
            // 
            this.buttonCalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateTotal.Location = new System.Drawing.Point(15, 25);
            this.buttonCalculateTotal.Name = "buttonCalculateTotal";
            this.buttonCalculateTotal.Size = new System.Drawing.Size(300, 138);
            this.buttonCalculateTotal.TabIndex = 0;
            this.buttonCalculateTotal.Text = "Calculate";
            this.buttonCalculateTotal.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(326, 71);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(96, 46);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "total";
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(428, 25);
            this.textBoxTotalCost.Multiline = true;
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(560, 138);
            this.textBoxTotalCost.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 673);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.Cafe);
            this.Controls.Add(this.Fuel);
            this.Name = "MainForm";
            this.Text = "Gas Station";
            this.Fuel.ResumeLayout(false);
            this.Fuel.PerformLayout();
            this.Cafe.ResumeLayout(false);
            this.Cafe.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxFuelCost.ResumeLayout(false);
            this.groupBoxFuelCost.PerformLayout();
            this.groupBoxCafeCost.ResumeLayout(false);
            this.groupBoxCafeCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Fuel;
        private System.Windows.Forms.GroupBox Cafe;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelGas;
        private System.Windows.Forms.Label labelPriceDollarSign;
        private System.Windows.Forms.TextBox textBoxPriceValue;
        private System.Windows.Forms.ComboBox textBoxFuelTypes;
        private System.Windows.Forms.RadioButton radioButtonFuelSum;
        private System.Windows.Forms.RadioButton radioButtonLiters;
        private System.Windows.Forms.TextBox textBoxFuelSum;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.Label labelLitres;
        private System.Windows.Forms.Label labelSumDollarSign;
        private System.Windows.Forms.GroupBox groupBoxFuelCost;
        private System.Windows.Forms.TextBox textBoxFuelCost;
        private System.Windows.Forms.GroupBox groupBoxCafeCost;
        private System.Windows.Forms.TextBox textBoxCafeCost;
        private System.Windows.Forms.TextBox textBoxWaterQuantity;
        private System.Windows.Forms.TextBox textBoxChocolateQuantity;
        private System.Windows.Forms.TextBox textBoxColaQuantity;
        private System.Windows.Forms.TextBox textBoxWater;
        private System.Windows.Forms.TextBox textBoxChocolate;
        private System.Windows.Forms.TextBox textBoxCola;
        private System.Windows.Forms.TextBox textBoxHotDogQuantity;
        private System.Windows.Forms.TextBox textBoxHotDog;
        private System.Windows.Forms.Label labelCafeQuantity;
        private System.Windows.Forms.Label labelCafePrice;
        private System.Windows.Forms.CheckBox checkBoxWater;
        private System.Windows.Forms.CheckBox checkBoxChocolateBar;
        private System.Windows.Forms.CheckBox checkBoxCocaCola;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.Label labelWaterDollarSign;
        private System.Windows.Forms.Label labelChocolateDollarSign;
        private System.Windows.Forms.Label labelColaDollarSign;
        private System.Windows.Forms.Label labelHotDogDollarSign;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCalculateTotal;
    }
}

