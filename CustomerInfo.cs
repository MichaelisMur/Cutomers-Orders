using System;
using System.Windows.Forms;

namespace Customers
{
    /// <summary>
    /// Панель с информацией о выбранном пользователе, доступная только админу.
    /// </summary>
    public partial class CustomerInfo : Form
    {
        User Customer;
        public CustomerInfo(User user)
        {
            InitializeComponent();
            Customer = user;
            emailLabel.Text = String.Format("Email: {0}", Customer.Email);
            nameLabel.Text = String.Format("Name: {0}", Customer.Name);
            phoneLabel.Text = String.Format("Phone: {0}", Customer.Phone);
            addressLabel.Text = String.Format("Address: {0}", Customer.Address);

            UpdateOrdersList();
        }

        /// <summary>
        /// Метод обновляет и выводит список заказов пользователя.
        /// </summary>
        private void UpdateOrdersList()
        {
            // Оплаченная сумма со всех заказов пользователя.
            double totalPaid = 0;
            ordersListView.Items.Clear();
            foreach (Order order in Customer.Orders)
            {
                string[] row = { order.ID.ToString(), CustomersAndOrders.StatusString(order.Status),
                    order.Ammount.ToString(), String.Format("{0:C}", order.TotalCost), order.CreationTime.ToString() };
                ListViewItem lvi = new ListViewItem(row);
                ordersListView.Items.Insert(0, lvi);

                // Если заказ оплачен.
                if (order.Status > 1)
                    totalPaid += order.TotalCost;
            }
            totalPaidLabel.Text = String.Format("Total paid ammount: {0:C}", totalPaid);
        }

        private void closeButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Двойной клик по ID заказа открывает панель с подробной информацией о нем.
        /// </summary>
        private void ordersListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var orderIndex = ordersListView.SelectedItems[0].Index;
            var orderInfoPanel = new OrderAdminInfo(Customer.Orders[Customer.Orders.Count - 1 - orderIndex]);
            orderInfoPanel.ShowDialog();

            UpdateOrdersList();
        }
    }
}
