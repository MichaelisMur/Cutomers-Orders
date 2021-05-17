using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Customers
{
    /// <summary>
    /// Панель со списком заказов, включающих определенный товар.
    /// </summary>
    public partial class ItemOrders : Form
    {
        List<Order> ItemOrdersList = new List<Order>();
        string ItemName;

        public ItemOrders(string item)
        {
            InitializeComponent();
            ItemName = item;
            itemOrdersLabel.Text = String.Format("Orders containing \"{0}\"", item);
            UpdateItemOrdersList();
        }

        /// <summary>
        /// Обновляет отображение списка заказов в listview.
        /// </summary>
        private void UpdateItemOrdersList()
        {
            itemOrdersListView.Items.Clear();
            foreach (var order in CustomersAndOrders.AllOrdersList)
            {
                // Если товара ItemName нет в заказе.
                if (!order.Items.ContainsKey(ItemName))
                    continue;

                ItemOrdersList.Add(order);
                string[] row = { order.ID.ToString(), CustomersAndOrders.StatusString(order.Status),
                    order.CreationTime.ToString(), order.Ammount.ToString(), order.CustomersEmail,
                    String.Format("{0:C}", order.TotalCost) };
                ListViewItem lvi = new ListViewItem(row);
                itemOrdersListView.Items.Insert(0, lvi);
            }
        }

        /// <summary>
        /// Событие дабблклика по заказу в листвью.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemOrdersListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CustomersAndOrders.CurrentUser.IsAdmin)
            {
                var orderInfoPanel = new OrderAdminInfo(ItemOrdersList[
                        itemOrdersListView.Items.Count - 1 - itemOrdersListView.SelectedItems[0].Index]);
                orderInfoPanel.ShowDialog();

                UpdateItemOrdersList();
            }
        }

        private void closeItemOrders_Click(object sender, EventArgs e) => Close();
    }
}
