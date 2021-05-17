using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Customers
{
    /// <summary>
    /// Админская панель с отчетом о заказах пользователей.
    /// </summary>
    public partial class OrdersReport : Form
    {
        List<Order> OrdersList = new List<Order>();

        public OrdersReport()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e) => Close();

        private void showOrders_Click(object sender, EventArgs e)
        {
            // Получаю список с подходящими заказами. Вывожу в порядке убывания цены.
            var orders = CustomersAndOrders.GetAllOrdersWithAmmount((int)minimumAmmount.Value);

            ordersListView.Items.Clear();
            foreach (var order in orders)
            {
                OrdersList.Add(order);
                string[] row = { order.ID.ToString(), CustomersAndOrders.StatusString(order.Status),
                    order.CreationTime.ToString(), order.Ammount.ToString(), order.CustomersEmail,
                    String.Format("{0:C}", order.TotalCost) };
                ListViewItem lvi = new ListViewItem(row);
                ordersListView.Items.Insert(0, lvi);
            }
        }
    }
}
