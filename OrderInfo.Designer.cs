
namespace Customers
{
    partial class OrderInfo
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
            this.itemsListView = new System.Windows.Forms.ListView();
            this.nameCartColumn = new System.Windows.Forms.ColumnHeader();
            this.ammountCartColumn = new System.Windows.Forms.ColumnHeader();
            this.costCartColumn = new System.Windows.Forms.ColumnHeader();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsListView
            // 
            this.itemsListView.BackColor = System.Drawing.SystemColors.Menu;
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCartColumn,
            this.ammountCartColumn,
            this.costCartColumn});
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(12, 65);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(776, 211);
            this.itemsListView.TabIndex = 6;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameCartColumn
            // 
            this.nameCartColumn.Text = "Item\'s name";
            this.nameCartColumn.Width = 425;
            // 
            // ammountCartColumn
            // 
            this.ammountCartColumn.Text = "Ammount";
            this.ammountCartColumn.Width = 150;
            // 
            // costCartColumn
            // 
            this.costCartColumn.Text = "Cost";
            this.costCartColumn.Width = 150;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(189, 296);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 34);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCostLabel.Location = new System.Drawing.Point(12, 37);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(99, 25);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total cost:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 25);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status:";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(12, 296);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(171, 34);
            this.payButton.TabIndex = 10;
            this.payButton.Text = "Pay for the order";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.itemsListView);
            this.Name = "OrderInfo";
            this.Text = "OrderInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ColumnHeader nameCartColumn;
        private System.Windows.Forms.ColumnHeader ammountCartColumn;
        private System.Windows.Forms.ColumnHeader costCartColumn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button payButton;
    }
}