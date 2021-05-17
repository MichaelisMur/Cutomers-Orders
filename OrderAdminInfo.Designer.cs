
namespace Customers
{
    partial class OrderAdminInfo
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
            this.nameCartColumn = new System.Windows.Forms.ColumnHeader();
            this.ammountCartColumn = new System.Windows.Forms.ColumnHeader();
            this.costCartColumn = new System.Windows.Forms.ColumnHeader();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // itemsListView
            // 
            this.itemsListView.BackColor = System.Drawing.SystemColors.Menu;
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCartColumn,
            this.ammountCartColumn,
            this.costCartColumn});
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(12, 12);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(776, 211);
            this.itemsListView.TabIndex = 12;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(12, 236);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 25);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Unprocessed",
            "Processed",
            "Paid",
            "Shipped",
            "Completed"});
            this.statusComboBox.Location = new System.Drawing.Point(12, 264);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(182, 33);
            this.statusComboBox.TabIndex = 16;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCostLabel.Location = new System.Drawing.Point(624, 236);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(99, 25);
            this.totalCostLabel.TabIndex = 18;
            this.totalCostLabel.Text = "Total cost:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(349, 315);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // OrderAdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.itemsListView);
            this.Name = "OrderAdminInfo";
            this.Text = "OrderAdminInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader nameCartColumn;
        private System.Windows.Forms.ColumnHeader ammountCartColumn;
        private System.Windows.Forms.ColumnHeader costCartColumn;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button okButton;
    }
}