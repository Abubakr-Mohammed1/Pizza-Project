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
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.gpCrust = new System.Windows.Forms.GroupBox();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rdThink = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chbChees = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbPeppers = new System.Windows.Forms.CheckBox();
            this.gpWhere = new System.Windows.Forms.GroupBox();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpSize.SuspendLayout();
            this.gpCrust.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpWhere.SuspendLayout();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.rdLarge);
            this.gpSize.Controls.Add(this.rdMedium);
            this.gpSize.Controls.Add(this.rdSmall);
            this.gpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSize.Location = new System.Drawing.Point(85, 232);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(333, 379);
            this.gpSize.TabIndex = 4;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(71, 84);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(125, 40);
            this.rdSmall.TabIndex = 5;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(71, 189);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(157, 40);
            this.rdMedium.TabIndex = 6;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(71, 285);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(128, 40);
            this.rdLarge.TabIndex = 7;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            // 
            // gpCrust
            // 
            this.gpCrust.Controls.Add(this.rdThink);
            this.gpCrust.Controls.Add(this.rdThin);
            this.gpCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCrust.Location = new System.Drawing.Point(113, 734);
            this.gpCrust.Name = "gpCrust";
            this.gpCrust.Size = new System.Drawing.Size(273, 252);
            this.gpCrust.TabIndex = 5;
            this.gpCrust.TabStop = false;
            this.gpCrust.Text = "Crust Type";
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(29, 83);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(190, 40);
            this.rdThin.TabIndex = 6;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            // 
            // rdThink
            // 
            this.rdThink.AutoSize = true;
            this.rdThink.Location = new System.Drawing.Point(29, 160);
            this.rdThink.Name = "rdThink";
            this.rdThink.Size = new System.Drawing.Size(205, 40);
            this.rdThink.TabIndex = 7;
            this.rdThink.TabStop = true;
            this.rdThink.Text = "Think Crust";
            this.rdThink.UseVisualStyleBackColor = true;
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.chbPeppers);
            this.gpToppings.Controls.Add(this.chbOlives);
            this.gpToppings.Controls.Add(this.chbOnion);
            this.gpToppings.Controls.Add(this.chbTomatoes);
            this.gpToppings.Controls.Add(this.chbMushrooms);
            this.gpToppings.Controls.Add(this.chbChees);
            this.gpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpToppings.Location = new System.Drawing.Point(834, 232);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(585, 299);
            this.gpToppings.TabIndex = 6;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chbChees
            // 
            this.chbChees.AutoSize = true;
            this.chbChees.Location = new System.Drawing.Point(40, 76);
            this.chbChees.Name = "chbChees";
            this.chbChees.Size = new System.Drawing.Size(215, 40);
            this.chbChees.TabIndex = 0;
            this.chbChees.Text = "Extra Chees";
            this.chbChees.UseVisualStyleBackColor = true;
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(40, 144);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(209, 40);
            this.chbMushrooms.TabIndex = 1;
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(40, 216);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(183, 40);
            this.chbTomatoes.TabIndex = 2;
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(332, 80);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(133, 40);
            this.chbOnion.TabIndex = 3;
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(332, 144);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(135, 40);
            this.chbOlives.TabIndex = 4;
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            // 
            // chbPeppers
            // 
            this.chbPeppers.AutoSize = true;
            this.chbPeppers.Location = new System.Drawing.Point(332, 216);
            this.chbPeppers.Name = "chbPeppers";
            this.chbPeppers.Size = new System.Drawing.Size(254, 40);
            this.chbPeppers.TabIndex = 5;
            this.chbPeppers.Text = "Green Peppers";
            this.chbPeppers.UseVisualStyleBackColor = true;
            // 
            // gpWhere
            // 
            this.gpWhere.Controls.Add(this.rdTakeOut);
            this.gpWhere.Controls.Add(this.rdEatIn);
            this.gpWhere.Location = new System.Drawing.Point(834, 734);
            this.gpWhere.Name = "gpWhere";
            this.gpWhere.Size = new System.Drawing.Size(465, 136);
            this.gpWhere.TabIndex = 7;
            this.gpWhere.TabStop = false;
            this.gpWhere.Text = "Where To Eat";
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Location = new System.Drawing.Point(41, 74);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(124, 36);
            this.rdEatIn.TabIndex = 0;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(245, 74);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(167, 36);
            this.rdTakeOut.TabIndex = 1;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(769, 924);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(249, 87);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1173, 924);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(249, 87);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2202, 1079);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gpWhere);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpCrust);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpCrust.ResumeLayout(false);
            this.gpCrust.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpWhere.ResumeLayout(false);
            this.gpWhere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox gpCrust;
        private System.Windows.Forms.RadioButton rdThink;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chbPeppers;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbChees;
        private System.Windows.Forms.GroupBox gpWhere;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
    }
}

