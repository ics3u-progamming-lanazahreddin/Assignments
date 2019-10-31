namespace PizzaOrderLanaZE
{
    partial class frmPizzaOrder
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
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radXLarge = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.lblPizzaSizeCost = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nudFries = new System.Windows.Forms.NumericUpDown();
            this.grpProvince = new System.Windows.Forms.GroupBox();
            this.radAlberta = new System.Windows.Forms.RadioButton();
            this.radOntario = new System.Windows.Forms.RadioButton();
            this.grpDelivery = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.txtFinalOrder = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblFriesCost = new System.Windows.Forms.Label();
            this.lblFries = new System.Windows.Forms.Label();
            this.lblToppingsPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFries)).BeginInit();
            this.grpProvince.SuspendLayout();
            this.grpDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpSize.Controls.Add(this.radXLarge);
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(14, 20);
            this.grpSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSize.Size = new System.Drawing.Size(258, 42);
            this.grpSize.TabIndex = 0;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Pizza Size";
            // 
            // radXLarge
            // 
            this.radXLarge.AutoSize = true;
            this.radXLarge.Location = new System.Drawing.Point(163, 17);
            this.radXLarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radXLarge.Name = "radXLarge";
            this.radXLarge.Size = new System.Drawing.Size(99, 21);
            this.radXLarge.TabIndex = 3;
            this.radXLarge.TabStop = true;
            this.radXLarge.Text = "Extra Large";
            this.radXLarge.UseVisualStyleBackColor = true;
            this.radXLarge.CheckedChanged += new System.EventHandler(this.RadXLarge_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(86, 17);
            this.radLarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(63, 21);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.RadLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(4, 17);
            this.radMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(75, 21);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.RadMedium_CheckedChanged);
            // 
            // lblPizzaSizeCost
            // 
            this.lblPizzaSizeCost.AutoSize = true;
            this.lblPizzaSizeCost.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSizeCost.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPizzaSizeCost.Location = new System.Drawing.Point(14, 81);
            this.lblPizzaSizeCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPizzaSizeCost.Name = "lblPizzaSizeCost";
            this.lblPizzaSizeCost.Size = new System.Drawing.Size(0, 30);
            this.lblPizzaSizeCost.TabIndex = 1;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToppings.Location = new System.Drawing.Point(11, 142);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(326, 21);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Add to your pizza some delicious toppings!";
            // 
            // nudFries
            // 
            this.nudFries.ForeColor = System.Drawing.Color.Olive;
            this.nudFries.Location = new System.Drawing.Point(10, 297);
            this.nudFries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudFries.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudFries.Name = "nudFries";
            this.nudFries.Size = new System.Drawing.Size(90, 20);
            this.nudFries.TabIndex = 6;
            this.nudFries.ValueChanged += new System.EventHandler(this.NudFries_ValueChanged);
            // 
            // grpProvince
            // 
            this.grpProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpProvince.Controls.Add(this.radAlberta);
            this.grpProvince.Controls.Add(this.radOntario);
            this.grpProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProvince.Location = new System.Drawing.Point(10, 350);
            this.grpProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProvince.Name = "grpProvince";
            this.grpProvince.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProvince.Size = new System.Drawing.Size(258, 42);
            this.grpProvince.TabIndex = 4;
            this.grpProvince.TabStop = false;
            this.grpProvince.Text = "Please select your province";
            // 
            // radAlberta
            // 
            this.radAlberta.AutoSize = true;
            this.radAlberta.Location = new System.Drawing.Point(150, 17);
            this.radAlberta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radAlberta.Name = "radAlberta";
            this.radAlberta.Size = new System.Drawing.Size(71, 21);
            this.radAlberta.TabIndex = 2;
            this.radAlberta.TabStop = true;
            this.radAlberta.Text = "Alberta";
            this.radAlberta.UseVisualStyleBackColor = true;
            this.radAlberta.CheckedChanged += new System.EventHandler(this.RadAlberta_CheckedChanged);
            // 
            // radOntario
            // 
            this.radOntario.AutoSize = true;
            this.radOntario.Location = new System.Drawing.Point(44, 17);
            this.radOntario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOntario.Name = "radOntario";
            this.radOntario.Size = new System.Drawing.Size(73, 21);
            this.radOntario.TabIndex = 1;
            this.radOntario.TabStop = true;
            this.radOntario.Text = "Ontario";
            this.radOntario.UseVisualStyleBackColor = true;
            this.radOntario.CheckedChanged += new System.EventHandler(this.RadOntario_CheckedChanged);
            // 
            // grpDelivery
            // 
            this.grpDelivery.BackColor = System.Drawing.Color.Yellow;
            this.grpDelivery.Controls.Add(this.radNo);
            this.grpDelivery.Controls.Add(this.radYes);
            this.grpDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelivery.Location = new System.Drawing.Point(10, 458);
            this.grpDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDelivery.Name = "grpDelivery";
            this.grpDelivery.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDelivery.Size = new System.Drawing.Size(306, 42);
            this.grpDelivery.TabIndex = 5;
            this.grpDelivery.TabStop = false;
            this.grpDelivery.Text = "Would you like your pizza t be delivered?";
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(150, 17);
            this.radNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(44, 21);
            this.radNo.TabIndex = 2;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.RadNo_CheckedChanged);
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(44, 17);
            this.radYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(53, 21);
            this.radYes.TabIndex = 1;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes!";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.RadYes_CheckedChanged);
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.ForeColor = System.Drawing.Color.Gold;
            this.lblDelivery.Location = new System.Drawing.Point(10, 503);
            this.lblDelivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(0, 30);
            this.lblDelivery.TabIndex = 9;
            // 
            // txtFinalOrder
            // 
            this.txtFinalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalOrder.Location = new System.Drawing.Point(484, 53);
            this.txtFinalOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinalOrder.Multiline = true;
            this.txtFinalOrder.Name = "txtFinalOrder";
            this.txtFinalOrder.Size = new System.Drawing.Size(242, 190);
            this.txtFinalOrder.TabIndex = 11;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblProvince.Location = new System.Drawing.Point(13, 405);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(0, 30);
            this.lblProvince.TabIndex = 12;
            // 
            // lblFriesCost
            // 
            this.lblFriesCost.AutoSize = true;
            this.lblFriesCost.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriesCost.ForeColor = System.Drawing.Color.Olive;
            this.lblFriesCost.Location = new System.Drawing.Point(124, 292);
            this.lblFriesCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFriesCost.Name = "lblFriesCost";
            this.lblFriesCost.Size = new System.Drawing.Size(227, 21);
            this.lblFriesCost.TabIndex = 13;
            this.lblFriesCost.Text = "Here is the price of your fries:";
            // 
            // lblFries
            // 
            this.lblFries.AutoSize = true;
            this.lblFries.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFries.ForeColor = System.Drawing.Color.Olive;
            this.lblFries.Location = new System.Drawing.Point(11, 249);
            this.lblFries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFries.Name = "lblFries";
            this.lblFries.Size = new System.Drawing.Size(307, 21);
            this.lblFries.TabIndex = 14;
            this.lblFries.Text = "Get some fries for a delicious side order!";
            // 
            // lblToppingsPrice
            // 
            this.lblToppingsPrice.AutoSize = true;
            this.lblToppingsPrice.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToppingsPrice.Location = new System.Drawing.Point(124, 193);
            this.lblToppingsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppingsPrice.Name = "lblToppingsPrice";
            this.lblToppingsPrice.Size = new System.Drawing.Size(0, 21);
            this.lblToppingsPrice.TabIndex = 16;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(518, 292);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(169, 71);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // nudToppings
            // 
            this.nudToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudToppings.Location = new System.Drawing.Point(10, 193);
            this.nudToppings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(90, 20);
            this.nudToppings.TabIndex = 18;
            this.nudToppings.ValueChanged += new System.EventHandler(this.NudToppings_ValueChanged);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 541);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblToppingsPrice);
            this.Controls.Add(this.lblFries);
            this.Controls.Add(this.lblFriesCost);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtFinalOrder);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.grpDelivery);
            this.Controls.Add(this.grpProvince);
            this.Controls.Add(this.nudFries);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblPizzaSizeCost);
            this.Controls.Add(this.grpSize);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Lana ZE";
            this.Load += new System.EventHandler(this.FrmPizzaOrder_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFries)).EndInit();
            this.grpProvince.ResumeLayout(false);
            this.grpProvince.PerformLayout();
            this.grpDelivery.ResumeLayout(false);
            this.grpDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radXLarge;
        private System.Windows.Forms.Label lblPizzaSizeCost;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudFries;
        private System.Windows.Forms.GroupBox grpProvince;
        private System.Windows.Forms.RadioButton radAlberta;
        private System.Windows.Forms.RadioButton radOntario;
        private System.Windows.Forms.GroupBox grpDelivery;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.TextBox txtFinalOrder;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblFriesCost;
        private System.Windows.Forms.Label lblFries;
        private System.Windows.Forms.Label lblToppingsPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudToppings;
    }
}

