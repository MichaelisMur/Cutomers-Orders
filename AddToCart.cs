using System;
using System.Windows.Forms;

namespace Customers
{
    /// <summary>
    /// Панель добавления товаров одного типа в корзину.
    /// </summary>
    public partial class AddToCart : Form
    {
        string ItemName;
        int Ammount = 1;

        public AddToCart(string itemName)
        {
            InitializeComponent();
            ItemName = itemName;
            addToCartLabel.Text = $"Add \"{ItemName}\" to the cart:";
            cartTextBox.Text = String.Format("{0:C}", ((double)cartUpDown.Value * 1.25));
        }

        private void cartUpDown_ValueChanged(object sender, EventArgs e)
        {
            Ammount = (int)cartUpDown.Value;
            cartTextBox.Text = String.Format("{0:C}", (int)cartUpDown.Value * 1.25);
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            // Если в корзине уже есть товары этого типа.
            if (CustomersAndOrders.Cart.ContainsKey(ItemName))
                CustomersAndOrders.Cart[ItemName] += Ammount;
            else
                CustomersAndOrders.Cart.Add(ItemName, Ammount);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
