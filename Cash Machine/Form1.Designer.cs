namespace Cash_Machine
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.printReceipt = new System.Windows.Forms.Button();
            this.newOrderLabel = new System.Windows.Forms.Button();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.numberOfSprayBox = new System.Windows.Forms.NumericUpDown();
            this.numberOfCureKitBox = new System.Windows.Forms.NumericUpDown();
            this.numberOfWipesBox = new System.Windows.Forms.NumericUpDown();
            this.labelchange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSprayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCureKitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfWipesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.Red;
            this.calculateButton.Location = new System.Drawing.Point(146, 217);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(152, 34);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label
            // 
            this.label.ForeColor = System.Drawing.Color.Lime;
            this.label.Location = new System.Drawing.Point(12, 68);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 26);
            this.label.TabIndex = 1;
            this.label.Text = "Number of Spray";
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.Lime;
            this.Label2.Location = new System.Drawing.Point(15, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 32);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Number of Cure Kit";
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.Lime;
            this.Label3.Location = new System.Drawing.Point(19, 164);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(144, 26);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Number of Wipes ";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.ForeColor = System.Drawing.Color.Lime;
            this.subTotalLabel.Location = new System.Drawing.Point(97, 254);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(310, 39);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = " Sub Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.ForeColor = System.Drawing.Color.Lime;
            this.tenderedLabel.Location = new System.Drawing.Point(63, 392);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(100, 23);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.ForeColor = System.Drawing.Color.Lime;
            this.changeLabel.Location = new System.Drawing.Point(165, 462);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(179, 51);
            this.changeLabel.TabIndex = 11;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.ForeColor = System.Drawing.Color.Red;
            this.calculateChangeButton.Location = new System.Drawing.Point(146, 425);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(152, 34);
            this.calculateChangeButton.TabIndex = 12;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.CalculateChangeButton_Click);
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(169, 389);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(100, 26);
            this.tenderedBox.TabIndex = 14;
            // 
            // printReceipt
            // 
            this.printReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceipt.ForeColor = System.Drawing.Color.Red;
            this.printReceipt.Location = new System.Drawing.Point(146, 516);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(152, 39);
            this.printReceipt.TabIndex = 15;
            this.printReceipt.Text = "Print Receipt ";
            this.printReceipt.UseVisualStyleBackColor = true;
            this.printReceipt.Click += new System.EventHandler(this.PrintReceipt_Click);
            // 
            // newOrderLabel
            // 
            this.newOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderLabel.ForeColor = System.Drawing.Color.Red;
            this.newOrderLabel.Location = new System.Drawing.Point(641, 516);
            this.newOrderLabel.Name = "newOrderLabel";
            this.newOrderLabel.Size = new System.Drawing.Size(129, 42);
            this.newOrderLabel.TabIndex = 16;
            this.newOrderLabel.Text = "New Order";
            this.newOrderLabel.UseVisualStyleBackColor = true;
            this.newOrderLabel.Click += new System.EventHandler(this.NewOrderLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.ForeColor = System.Drawing.Color.Lime;
            this.taxLabel.Location = new System.Drawing.Point(97, 293);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(234, 35);
            this.taxLabel.TabIndex = 17;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.ForeColor = System.Drawing.Color.Lime;
            this.totalLabel.Location = new System.Drawing.Point(97, 331);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(268, 61);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Aqua;
            this.Title.Location = new System.Drawing.Point(14, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(473, 55);
            this.Title.TabIndex = 19;
            this.Title.Text = "CREP PROTECTION";
            // 
            // numberOfSprayBox
            // 
            this.numberOfSprayBox.Location = new System.Drawing.Point(169, 71);
            this.numberOfSprayBox.Name = "numberOfSprayBox";
            this.numberOfSprayBox.Size = new System.Drawing.Size(120, 26);
            this.numberOfSprayBox.TabIndex = 20;
            // 
            // numberOfCureKitBox
            // 
            this.numberOfCureKitBox.Location = new System.Drawing.Point(169, 117);
            this.numberOfCureKitBox.Name = "numberOfCureKitBox";
            this.numberOfCureKitBox.Size = new System.Drawing.Size(120, 26);
            this.numberOfCureKitBox.TabIndex = 21;
            // 
            // numberOfWipesBox
            // 
            this.numberOfWipesBox.Location = new System.Drawing.Point(169, 164);
            this.numberOfWipesBox.Name = "numberOfWipesBox";
            this.numberOfWipesBox.Size = new System.Drawing.Size(120, 26);
            this.numberOfWipesBox.TabIndex = 22;
            // 
            // labelchange
            // 
            this.labelchange.ForeColor = System.Drawing.Color.Lime;
            this.labelchange.Location = new System.Drawing.Point(63, 474);
            this.labelchange.Name = "labelchange";
            this.labelchange.Size = new System.Drawing.Size(100, 23);
            this.labelchange.TabIndex = 23;
            this.labelchange.Text = "Change";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1002, 589);
            this.Controls.Add(this.labelchange);
            this.Controls.Add(this.numberOfWipesBox);
            this.Controls.Add(this.numberOfCureKitBox);
            this.Controls.Add(this.numberOfSprayBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.newOrderLabel);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.calculateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSprayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCureKitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfWipesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Button newOrderLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.NumericUpDown numberOfSprayBox;
        private System.Windows.Forms.NumericUpDown numberOfCureKitBox;
        private System.Windows.Forms.NumericUpDown numberOfWipesBox;
        private System.Windows.Forms.Label labelchange;
    }
}

