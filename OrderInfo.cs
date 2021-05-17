using System;
using System.Windows.Forms;

namespace Customers
{
    /// <summary>
    /// Панель с информацией о заказе.
    /// </summary>
    public partial class OrderInfo : Form
    {
        Order orderObject;

        public OrderInfo(Order order)
        {
            InitializeComponent();
            itemsListView.Items.Clear();
            orderObject = order;

            // Заполняю listview.
            double cost = 0;
            foreach (var item in orderObject.Items)
            {
                string[] row = { item.Key, item.Value.ToString(), String.Format("{0:C}", item.Value * 1.25) };
                ListViewItem lvi = new ListViewItem(row);
                itemsListView.Items.Add(lvi);
                cost += item.Value * 1.25;
            }
            totalCostLabel.Text = String.Format("Total cost: {0:C}", cost);
            statusLabel.Text = String.Format("Status: {0}", (CustomersAndOrders.Status)orderObject.Status);

            // Кнопка для оплаты заказа в зависимости от статуса.
            switch (orderObject.Status)
            {
                case 0:
                    payButton.Text = "Pay for the order";
                    payButton.Enabled = false;
                    break;
                case 1:
                    payButton.Text = "Pay for the order";
                    payButton.Enabled = true;
                    break;
                default:
                    payButton.Text = "Paid";
                    payButton.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Событие клика по кнопке для оплаты заказа.
        /// </summary>
        private void payButton_Click(object sender, EventArgs e)
        {
            orderObject.Status = 2;
            payButton.Text = "Paid";
            payButton.Enabled = false;
            statusLabel.Text = String.Format("Status: {0}", (CustomersAndOrders.Status)orderObject.Status);
            MessageBox.Show("The order has been paid");
        }
        private void closeButton_Click(object sender, EventArgs e) => Close();
    }
}
