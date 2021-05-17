
namespace Customers
{
    partial class ItemOrders
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
            this.itemOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.itemOrdersLabel = new System.Windows.Forms.Label();
            this.closeItemOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemOrdersListView
            // 
            this.itemOrdersListView.BackColor = System.Drawing.SystemColors.Menu;
            this.itemOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10});
            this.itemOrdersListView.FullRowSelect = true;
            this.itemOrdersListView.HideSelection = false;
            this.itemOrdersListView.Location = new System.Drawing.Point(12, 40);
            this.itemOrdersListView.Name = "itemOrdersListView";
            this.itemOrdersListView.Size = new System.Drawing.Size(1007, 230);
            this.itemOrdersListView.TabIndex = 14;
            this.itemOrdersListView.UseCompatibleStateImageBehavior = false;
            this.itemOrdersListView.View = System.Windows.Forms.View.Details;
            this.itemOrdersListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemOrdersListView_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order\'s ID";
            this.columnHeader2.Width = 125;
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
            // itemOrdersLabel
            // 
            this.itemOrdersLabel.AutoSize = true;
            this.itemOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemOrdersLabel.Location = new System.Drawing.Point(12, 9);
            this.itemOrdersLabel.Name = "itemOrdersLabel";
            this.itemOrdersLabel.Size = new System.Drawing.Size(270, 28);
            this.itemOrdersLabel.TabIndex = 15;
            this.itemOrdersLabel.Text = "Orders with the selected item:";
            // 
            // closeItemOrders
            // 
            this.closeItemOrders.Location = new System.Drawing.Point(12, 287);
            this.closeItemOrders.Name = "closeItemOrders";
            this.closeItemOrders.Size = new System.Drawing.Size(112, 34);
            this.closeItemOrders.TabIndex = 16;
            this.closeItemOrders.Text = "Close";
            this.closeItemOrders.UseVisualStyleBackColor = true;
            this.closeItemOrders.Click += new System.EventHandler(this.closeItemOrders_Click);
            // 
            // ItemOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 333);
            this.Controls.Add(this.closeItemOrders);
            this.Controls.Add(this.itemOrdersLabel);
            this.Controls.Add(this.itemOrdersListView);
            this.Name = "ItemOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemOrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label itemOrdersLabel;
        private System.Windows.Forms.Button closeItemOrders;
    }
}