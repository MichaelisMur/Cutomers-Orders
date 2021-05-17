
namespace Customers
{
    partial class OrdersReport
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
            this.ordersListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.minimumAmmount = new System.Windows.Forms.NumericUpDown();
            this.itemOrdersLabel = new System.Windows.Forms.Label();
            this.showOrders = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimumAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersListView
            // 
            this.ordersListView.BackColor = System.Drawing.SystemColors.Menu;
            this.ordersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10});
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(12, 87);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(1015, 230);
            this.ordersListView.TabIndex = 15;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order\'s ID";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Ammount";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 2;
            this.columnHeader6.Text = "Customer\'s email";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total cost";
            this.columnHeader10.Width = 100;
            // 
            // minimumAmmount
            // 
            this.minimumAmmount.Location = new System.Drawing.Point(12, 47);
            this.minimumAmmount.Name = "minimumAmmount";
            this.minimumAmmount.Size = new System.Drawing.Size(180, 31);
            this.minimumAmmount.TabIndex = 16;
            // 
            // itemOrdersLabel
            // 
            this.itemOrdersLabel.AutoSize = true;
            this.itemOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemOrdersLabel.Location = new System.Drawing.Point(12, 19);
            this.itemOrdersLabel.Name = "itemOrdersLabel";
            this.itemOrdersLabel.Size = new System.Drawing.Size(186, 25);
            this.itemOrdersLabel.TabIndex = 17;
            this.itemOrdersLabel.Text = "Minimum order value:";
            // 
            // showOrders
            // 
            this.showOrders.Location = new System.Drawing.Point(220, 44);
            this.showOrders.Name = "showOrders";
            this.showOrders.Size = new System.Drawing.Size(112, 34);
            this.showOrders.TabIndex = 18;
            this.showOrders.Text = "Show";
            this.showOrders.UseVisualStyleBackColor = true;
            this.showOrders.Click += new System.EventHandler(this.showOrders_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 335);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 34);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // OrdersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 389);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.showOrders);
            this.Controls.Add(this.itemOrdersLabel);
            this.Controls.Add(this.minimumAmmount);
            this.Controls.Add(this.ordersListView);
            this.Name = "OrdersReport";
            this.Text = "OrdersReport";
            ((System.ComponentModel.ISupportInitialize)(this.minimumAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.NumericUpDown minimumAmmount;
        private System.Windows.Forms.Label itemOrdersLabel;
        private System.Windows.Forms.Button showOrders;
        private System.Windows.Forms.Button closeButton;
    }
}