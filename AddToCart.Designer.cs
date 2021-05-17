
namespace Customers
{
    partial class AddToCart
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
            this.cartUpDown = new System.Windows.Forms.NumericUpDown();
            this.cartTextBox = new System.Windows.Forms.TextBox();
            this.addToCartLabel = new System.Windows.Forms.Label();
            this.cartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cartUpDown
            // 
            this.cartUpDown.Location = new System.Drawing.Point(85, 91);
            this.cartUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cartUpDown.Name = "cartUpDown";
            this.cartUpDown.ReadOnly = true;
            this.cartUpDown.Size = new System.Drawing.Size(180, 31);
            this.cartUpDown.TabIndex = 0;
            this.cartUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cartUpDown.ValueChanged += new System.EventHandler(this.cartUpDown_ValueChanged);
            // 
            // cartTextBox
            // 
            this.cartTextBox.Location = new System.Drawing.Point(360, 91);
            this.cartTextBox.Name = "cartTextBox";
            this.cartTextBox.ReadOnly = true;
            this.cartTextBox.Size = new System.Drawing.Size(150, 31);
            this.cartTextBox.TabIndex = 1;
            // 
            // addToCartLabel
            // 
            this.addToCartLabel.AutoSize = true;
            this.addToCartLabel.Location = new System.Drawing.Point(85, 63);
            this.addToCartLabel.Name = "addToCartLabel";
            this.addToCartLabel.Size = new System.Drawing.Size(142, 25);
            this.addToCartLabel.TabIndex = 2;
            this.addToCartLabel.Text = "Add item to cart";
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(85, 150);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(142, 34);
            this.cartButton.TabIndex = 3;
            this.cartButton.Text = "Add to the cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cost";
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.addToCartLabel);
            this.Controls.Add(this.cartTextBox);
            this.Controls.Add(this.cartUpDown);
            this.Name = "AddToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddToCart";
            ((System.ComponentModel.ISupportInitialize)(this.cartUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cartUpDown;
        private System.Windows.Forms.TextBox cartTextBox;
        private System.Windows.Forms.Label addToCartLabel;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}