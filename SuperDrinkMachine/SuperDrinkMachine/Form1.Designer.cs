namespace SuperDrinkMachine
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
            this.products = new System.Windows.Forms.ComboBox();
            this.patmentButton = new System.Windows.Forms.Button();
            this.boxPacking = new System.Windows.Forms.CheckBox();
            this.bagPacking = new System.Windows.Forms.CheckBox();
            this.selecdProduct = new System.Windows.Forms.Label();
            this.showProduct = new System.Windows.Forms.Label();
            this.showResult = new System.Windows.Forms.Label();
            this.numericUpDownToPay = new System.Windows.Forms.NumericUpDown();
            this.Toprocess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(280, 137);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(183, 28);
            this.products.TabIndex = 0;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // patmentButton
            // 
            this.patmentButton.Location = new System.Drawing.Point(324, 259);
            this.patmentButton.Name = "patmentButton";
            this.patmentButton.Size = new System.Drawing.Size(94, 29);
            this.patmentButton.TabIndex = 1;
            this.patmentButton.Text = "Payment";
            this.patmentButton.UseVisualStyleBackColor = true;
            this.patmentButton.Click += new System.EventHandler(this.patmentButton_Click);
            // 
            // boxPacking
            // 
            this.boxPacking.AutoSize = true;
            this.boxPacking.Location = new System.Drawing.Point(442, 209);
            this.boxPacking.Name = "boxPacking";
            this.boxPacking.Size = new System.Drawing.Size(56, 24);
            this.boxPacking.TabIndex = 2;
            this.boxPacking.Text = "Box";
            this.boxPacking.UseVisualStyleBackColor = true;
            // 
            // bagPacking
            // 
            this.bagPacking.AutoSize = true;
            this.bagPacking.Location = new System.Drawing.Point(270, 211);
            this.bagPacking.Name = "bagPacking";
            this.bagPacking.Size = new System.Drawing.Size(57, 24);
            this.bagPacking.TabIndex = 3;
            this.bagPacking.Text = "Bag";
            this.bagPacking.UseVisualStyleBackColor = true;
            // 
            // selecdProduct
            // 
            this.selecdProduct.AutoSize = true;
            this.selecdProduct.Location = new System.Drawing.Point(312, 90);
            this.selecdProduct.Name = "selecdProduct";
            this.selecdProduct.Size = new System.Drawing.Size(117, 20);
            this.selecdProduct.TabIndex = 4;
            this.selecdProduct.Text = "Select a product";
            this.selecdProduct.Click += new System.EventHandler(this.selecdProduct_Click);
            // 
            // showProduct
            // 
            this.showProduct.AutoSize = true;
            this.showProduct.Location = new System.Drawing.Point(618, 113);
            this.showProduct.Name = "showProduct";
            this.showProduct.Size = new System.Drawing.Size(0, 20);
            this.showProduct.TabIndex = 9;
            // 
            // showResult
            // 
            this.showResult.AutoSize = true;
            this.showResult.Location = new System.Drawing.Point(344, 114);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(50, 20);
            this.showResult.TabIndex = 10;
            this.showResult.Text = "label2";
            // 
            // numericUpDownToPay
            // 
            this.numericUpDownToPay.Location = new System.Drawing.Point(300, 171);
            this.numericUpDownToPay.Name = "numericUpDownToPay";
            this.numericUpDownToPay.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownToPay.TabIndex = 11;
            this.numericUpDownToPay.ValueChanged += new System.EventHandler(this.numericUpDownToPay_ValueChanged);
            // 
            // Toprocess
            // 
            this.Toprocess.Location = new System.Drawing.Point(333, 211);
            this.Toprocess.Name = "Toprocess";
            this.Toprocess.Size = new System.Drawing.Size(94, 29);
            this.Toprocess.TabIndex = 12;
            this.Toprocess.Text = "To pay";
            this.Toprocess.UseVisualStyleBackColor = true;
            this.Toprocess.Click += new System.EventHandler(this.Toprocess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Toprocess);
            this.Controls.Add(this.numericUpDownToPay);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.showProduct);
            this.Controls.Add(this.selecdProduct);
            this.Controls.Add(this.bagPacking);
            this.Controls.Add(this.boxPacking);
            this.Controls.Add(this.patmentButton);
            this.Controls.Add(this.products);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox products;
        private Button patmentButton;
        private CheckBox boxPacking;
        private CheckBox bagPacking;
        private Label selecdProduct;
        private Label showProduct;
        private Label showResult;
        private NumericUpDown numericUpDownToPay;
        private Button Toprocess;
    }
}