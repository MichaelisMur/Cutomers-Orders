using System;
using System.Windows.Forms;

namespace Customers
{
    /// <summary>
    /// Админская панель с информацией о выбранном заказе.
    /// </summary>
    public partial class OrderAdminInfo : Form
    {
        Order orderObject;

        public OrderAdminInfo(Order order)
        {
            InitializeComponent();
            itemsListView.Items.Clear();
            orderObject = order;

            double cost = 0;
            // Отображение товаров заказа в listview.
            foreach (var item in orderObject.Items)
            {
                string[] row = { item.Key, item.Value.ToString(), String.Format("{0:C}", item.Value * 1.25) };
                ListViewItem lvi = new ListViewItem(row);
                itemsListView.Items.Add(lvi);
                cost += item.Value * 1.25;
            }
            totalCostLabel.Text = String.Format("Total cost: {0:C}", cost);
            statusComboBox.SelectedIndex = order.Status;
        }

        private void okButton_Click(object sender, EventArgs e) => Close();

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e) =>
            orderObject.Status = statusComboBox.SelectedIndex;
    }
}
