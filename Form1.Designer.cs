namespace PizzaProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbPeppers = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbChees = new System.Windows.Forms.CheckBox();
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblWhere = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhere.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(586, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 113);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAKE YOUR PIZZA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdLarge);
            this.gbSize.Controls.Add(this.rdMedium);
            this.gbSize.Controls.Add(this.rdSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(85, 232);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(333, 379);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(71, 285);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(128, 40);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(71, 189);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(157, 40);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(71, 84);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(125, 40);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rdThick);
            this.gbCrust.Controls.Add(this.rdThin);
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(113, 734);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(273, 252);
            this.gbCrust.TabIndex = 1;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(29, 160);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(203, 40);
            this.rdThick.TabIndex = 4;
            this.rdThick.TabStop = true;
            this.rdThick.Text = "Thick Crust";
            this.rdThick.UseVisualStyleBackColor = true;
            this.rdThick.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(29, 83);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(190, 40);
            this.rdThin.TabIndex = 3;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbPeppers);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbTomatoes);
            this.gbToppings.Controls.Add(this.chbMushrooms);
            this.gbToppings.Controls.Add(this.chbChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(834, 232);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(585, 299);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbPeppers
            // 
            this.chbPeppers.AutoSize = true;
            this.chbPeppers.Location = new System.Drawing.Point(332, 216);
            this.chbPeppers.Name = "chbPeppers";
            this.chbPeppers.Size = new System.Drawing.Size(254, 40);
            this.chbPeppers.TabIndex = 10;
            this.chbPeppers.Text = "Green Peppers";
            this.chbPeppers.UseVisualStyleBackColor = true;
            this.chbPeppers.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(332, 144);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(135, 40);
            this.chbOlives.TabIndex = 8;
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(332, 80);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(133, 40);
            this.chbOnion.TabIndex = 6;
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(40, 216);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(183, 40);
            this.chbTomatoes.TabIndex = 9;
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(40, 144);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(209, 40);
            this.chbMushrooms.TabIndex = 7;
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // chbChees
            // 
            this.chbChees.AutoSize = true;
            this.chbChees.Location = new System.Drawing.Point(40, 76);
            this.chbChees.Name = "chbChees";
            this.chbChees.Size = new System.Drawing.Size(215, 40);
            this.chbChees.TabIndex = 5;
            this.chbChees.Text = "Extra Chees";
            this.chbChees.UseVisualStyleBackColor = true;
            this.chbChees.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // gbWhere
            // 
            this.gbWhere.Controls.Add(this.rdTakeOut);
            this.gbWhere.Controls.Add(this.rdEatIn);
            this.gbWhere.Location = new System.Drawing.Point(834, 734);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Size = new System.Drawing.Size(465, 136);
            this.gbWhere.TabIndex = 3;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(245, 74);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(167, 36);
            this.rdTakeOut.TabIndex = 12;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Location = new System.Drawing.Point(41, 74);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(124, 36);
            this.rdEatIn.TabIndex = 11;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(769, 924);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(249, 87);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1173, 924);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(249, 87);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.label7);
            this.gbSummary.Controls.Add(this.lblPrice);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.lblCrust);
            this.gbSummary.Controls.Add(this.lblWhere);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.lblToppings);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.lblSize);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummary.Location = new System.Drawing.Point(1603, 232);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(532, 805);
            this.gbSummary.TabIndex = 10;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ravie", 21.9F);
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(225, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 96);
            this.label7.TabIndex = 10;
            this.label7.Text = "$";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Ravie", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPrice.Location = new System.Drawing.Point(304, 658);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(153, 96);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Price:";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.Location = new System.Drawing.Point(266, 394);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(168, 36);
            this.lblCrust.TabIndex = 7;
            this.lblCrust.Text = "Think Crust";
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhere.Location = new System.Drawing.Point(284, 545);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(92, 36);
            this.lblWhere.TabIndex = 6;
            this.lblWhere.Text = "Eat In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Where To Eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(133, 279);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(377, 83);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "No Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(164, 114);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(120, 36);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Medium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2202, 1079);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbWhere);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhere.ResumeLayout(false);
            this.gbWhere.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbPeppers;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbChees;
        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label label7;
    }
}

