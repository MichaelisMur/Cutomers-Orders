
namespace Customers
{
    partial class CustomerInfo
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
            this.totalPaidLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ordersListView = new System.Windows.Forms.ListView();
            this.idOrdersColumn = new System.Windows.Forms.ColumnHeader();
            this.statusOrdersColumn = new System.Windows.Forms.ColumnHeader();
            this.ammountOrdersColumn = new System.Windows.Forms.ColumnHeader();
            this.costOrdersColumn = new System.Windows.Forms.ColumnHeader();
            this.dateOrdersColumn = new System.Windows.Forms.ColumnHeader();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalPaidLabel
            // 
            this.totalPaidLabel.AutoSize = true;
            this.totalPaidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPaidLabel.Location = new System.Drawing.Point(12, 285);
            this.totalPaidLabel.Name = "totalPaidLabel";
            this.totalPaidLabel.Size = new System.Drawing.Size(188, 25);
            this.totalPaidLabel.TabIndex = 13;
            this.totalPaidLabel.Text = "Total paid ammount:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 328);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 34);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Pay for the order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total cost:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 211);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item\'s name";
            this.columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ammount";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            this.columnHeader3.Width = 150;
            // 
            // ordersListView
            // 
            this.ordersListView.BackColor = System.Drawing.SystemColors.Menu;
            this.ordersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idOrdersColumn,
            this.statusOrdersColumn,
            this.ammountOrdersColumn,
            this.costOrdersColumn,
            this.dateOrdersColumn});
            this.ordersListView.FullRowSelect = true;
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(12, 40);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(953, 224);
            this.ordersListView.TabIndex = 16;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.View = System.Windows.Forms.View.Details;
            this.ordersListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ordersListView_MouseDoubleClick);
            // 
            // idOrdersColumn
            // 
            this.idOrdersColumn.Text = "Order\'s ID";
            this.idOrdersColumn.Width = 180;
            // 
            // statusOrdersColumn
            // 
            this.statusOrdersColumn.Text = "Status";
            this.statusOrdersColumn.Width = 300;
            // 
            // ammountOrdersColumn
            // 
            this.ammountOrdersColumn.DisplayIndex = 3;
            this.ammountOrdersColumn.Text = "Ammount";
            this.ammountOrdersColumn.Width = 100;
            // 
            // costOrdersColumn
            // 
            this.costOrdersColumn.DisplayIndex = 4;
            this.costOrdersColumn.Text = "Total cost";
            this.costOrdersColumn.Width = 150;
            // 
            // dateOrdersColumn
            // 
            this.dateOrdersColumn.DisplayIndex = 2;
            this.dateOrdersColumn.Text = "Order date";
            this.dateOrdersColumn.Width = 210;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(341, 285);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 25);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(659, 285);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 25);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(341, 333);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 25);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(659, 333);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 25);
            this.addressLabel.TabIndex = 21;
            this.addressLabel.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer\'s orders";
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ordersListView);
            this.Controls.Add(this.totalPaidLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalPaidLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.ColumnHeader idOrdersColumn;
        private System.Windows.Forms.ColumnHeader statusOrdersColumn;
        private System.Windows.Forms.ColumnHeader ammountOrdersColumn;
        private System.Windows.Forms.ColumnHeader costOrdersColumn;
        private System.Windows.Forms.ColumnHeader dateOrdersColumn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label3;
    }
}