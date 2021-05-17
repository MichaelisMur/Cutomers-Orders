using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Customers
{
    /// <summary>
    /// Основаная панель программы.
    /// </summary>
    public partial class CustomersAndOrders : Form
    {
        /// <summary>
        /// Список объектов класса User (информация о пользователе и его заказах).
        /// </summary>
        static public List<User> Users = new List<User>();

        static public string Email;
        static public string Password;

        /// <summary>
        /// Ссылка на авторизованного пользователя (объект класса User).
        /// </summary>
        static public User CurrentUser {
            get
            {
                try
                {
                    // Поиск в списке Users объекта с подходящими логином и паролем.
                    foreach (var user in Users)
                        if (user.Email == Email && user.Password == Password)
                            return user;
                }
                catch { }
                Email = null;
                Password = null;
                return null;
            }
            set => CurrentUser = value;
        }

        /// <summary>
        /// Список зарегистрированных логинов.
        /// </summary>
        static public List<string> EmailsList
        {
            get
            {
                var emailList = new List<string>();
                Users.ForEach(user =>
                {
                    emailList.Add(user.Email);
                });
                return emailList;
            }
        }

        /// <summary>
        /// Общий список заказов всех пользователей.
        /// </summary>
        static public List<Order> AllOrdersList
        {
            get
            {
                var allOrdersList = new List<Order>();
                foreach (var user in Users)
                    foreach (var order in user.Orders)
                        allOrdersList.Add(order);

                // Сортирую по времени.
                allOrdersList.Sort((first, second) =>
                {
                    if (first.CreationTime > second.CreationTime)
                        return 1;
                    else
                        return -1;
                });
                return allOrdersList;
            }
        }

        /// <summary>
        /// Общий список заказов всех пользователей.
        /// </summary>
        static public List<Order> AllActiveOrdersList
        {
            get
            {
                var allOrdersList = new List<Order>();
                foreach (var user in Users)
                    foreach (var order in user.Orders)
                        if(order.Status != 4)
                            allOrdersList.Add(order);

                // Сортирую по времени.
                allOrdersList.Sort((first, second) =>
                {
                    if (first.CreationTime > second.CreationTime)
                        return 1;
                    else
                        return -1;
                });
                return allOrdersList;
            }
        }

        /// <summary>
        /// Словарь с содержимым корзины.
        /// </summary>
        static public Dictionary<string, int> Cart = new Dictionary<string, int>();

        // Перечисление возможных статусов заказа.
        public enum Status
        {
            Unprocessed,
            Processed,
            Paid,
            Shipped,
            Completed
        }

        public CustomersAndOrders()
        {
            InitializeComponent();
            Text = "Fruits & Veggies (Fixed $1.25 price for all products!)";
            goodsList.HeaderStyle = ColumnHeaderStyle.None;
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        private void CustomersAndOrders_Load(object sender, EventArgs e)
        {
            try
            {
                // Десериализация списка объектов User с информацией о пользователях и их заказах.
                var deser = new DataContractJsonSerializer(typeof(List<User>));
                using (var fs = new FileStream("users.json", FileMode.Open, FileAccess.Read))
                {
                    // Null coalescing operator.
                    Users = (List<User>)deser.ReadObject(fs) ?? new List<User>();
                }

                SetCredentials();

                if (CurrentUser == null)
                    LoggedOut();
                else
                    LoggedIn();
            }
            catch { }
        }

        /// <summary>
        /// Считывает логин и пароль последнего использовавшего программу пользователя.
        /// </summary>
        private void SetCredentials()
        {
            try
            {
                using FileStream fs = File.OpenRead("currentUser.txt");
                using var sr = new StreamReader(fs);
                var parameters = sr.ReadLine().ToString().Split();
                Email = parameters[0];
                Password = parameters[1];
            }
            catch
            {
                Email = null;
                Password = null;
            }
        }

        /// <summary>
        /// Событие клика по товару в списке.
        /// </summary>
        private void goodsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            // Если пользователь не является админом.
            if (CurrentUser == null || !CurrentUser.IsAdmin)
            {
                contextMenuPanel.Items.Clear();
                contextMenuPanel.Items.Add("Add to cart");
                contextMenuPanel.Show(Cursor.Position);
            }
            // Если пользователь является админом.
            else
            {
                contextMenuPanel.Items.Clear();
                contextMenuPanel.Items.Add("Show item's orders");
                contextMenuPanel.Show(Cursor.Position);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                Email = null;
                Password = null;
                LoggedOut();
                return;
            }
            var register = new SignIn();
            register.ShowDialog();

            if (CurrentUser != null)
                LoggedIn();
        }

        /// <summary>
        /// Метод вызывается после успешной авторизации. Выводит нужные и скрывает ненужные объекты и прочее.
        /// </summary>
        private void LoggedIn()
        {
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            emailTextBox.Visible = false;
            LogInButton.Visible = false;
            signInButton.Text = "Log out";
            string adminString = CurrentUser.IsAdmin ? "(Admin)" : string.Empty;
            emailLabel.Text = $"Welcome back, {CurrentUser.Name}! Your email: \"{CurrentUser.Email}\" {adminString}";

            // Если пользователь является админом.
            if (CurrentUser.IsAdmin)
            {
                bigAdminPanel.Visible = true;
                bigUserPanel.Visible = false;
                ordersReportButton.Visible = true;
                ordersComboBox.SelectedIndex = 0;
                UpdateCustomersList();
                UpdateAllOrdersList();
            }
            // Если пользователь не является админом.
            else
            {
                bigUserPanel.Visible = true;
                bigAdminPanel.Visible = false;
                ordersReportButton.Visible = false;
                UpdateOrdersList();
            }

            Cart.Clear();
            UpdateCartList();
        }

        /// <summary>
        /// Метод вызывается после логаута. Выводит нужные и скрывает ненужные объекты и прочее.
        /// </summary>
        private void LoggedOut()
        {
            passwordLabel.Visible = true;
            passwordTextBox.Visible = true;
            passwordTextBox.Text = String.Empty;
            emailTextBox.Visible = true;
            emailTextBox.Text = String.Empty;
            LogInButton.Visible = true;
            emailLabel.Text = "Email:";
            signInButton.Text = "Sign in";

            bigAdminPanel.Visible = false;
            bigUserPanel.Visible = false;
            ordersReportButton.Visible = false;
        }

        /// <summary>
        /// Событие закрытия формы.
        /// </summary>
        private void CustomersAndOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Запись логина и пароля авторизованного пользователя в файл.
                if (CurrentUser != null && Password != null && Email != null)
                    File.WriteAllText("currentUser.txt", String.Format("{0} {1}", Email, Password));
                else
                    File.WriteAllText("currentUser.txt", "");

                // Сериализация списка пользователей и их заказов.
                var ser = new DataContractJsonSerializer(typeof(List<User>));
                using (var fs = new FileStream("users.json", FileMode.Create, FileAccess.Write))
                {
                    ser.WriteObject(fs, Users);
                }
            }
            catch { }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Invaild data");
                return;
            }

            if (EmailsList.IndexOf(emailTextBox.Text) == -1)
            {
                MessageBox.Show("Email is not registered");
                return;
            }

            // Если пароли не совпадают.
            if (Users[EmailsList.IndexOf(emailTextBox.Text)]?.Password != Hashing.ImmenseHitOfHash(passwordTextBox.Text))
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            var loggedInUser = Users[EmailsList.IndexOf(emailTextBox.Text)];
            Email = loggedInUser.Email;
            Password = loggedInUser.Password;
            LoggedIn();
        }

        private void contextMenuPanel_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Text)
                {
                    case "Show item's orders":
                        ItemsOrders();
                        break;
                    case "Add to cart":
                        AddItemToCart();
                        break;
                    case "Remove from cart":
                        Cart.Remove(cartListView.SelectedItems[0].Text);
                        UpdateCartList();
                        break;
                    case "Customer info":
                        CustomerInfo();
                        break;
                    case "Customer's order info":
                        OrderInfoFromAllOrdersList();
                        break;
                    case "Order info":
                        OrderInfo();
                        break;
                }
            }
            catch { }
        }

        /// <summary>
        /// Выводит админу панель всех закзов, включающих данный товар.
        /// </summary>
        private void ItemsOrders()
        {
            var itemOrders = new ItemOrders(goodsList.SelectedItems[0].Text);
            itemOrders.ShowDialog();

            UpdateCustomersList();
            UpdateAllOrdersList();
        }

        /// <summary>
        /// Открывает панель добавления товара в корзину.
        /// </summary>
        private void AddItemToCart()
        {
            if (CurrentUser == null)
                MessageBox.Show("Log in to add items to cart");
            else
            {
                var addToCart = new AddToCart(goodsList.SelectedItems[0].Text);
                addToCart.ShowDialog();

                UpdateCartList();
            }
        }

        /// <summary>
        /// Выводит админу панель с подробной информацией о заказе.
        /// </summary>
        private void OrderInfoFromAllOrdersList()
        {
            if (CurrentUser.IsAdmin)
            {
                var orderInfoPanel = new OrderAdminInfo(
                    // Выбираю нужные
                    ordersComboBox.SelectedIndex == 0 ? 
                    AllOrdersList[allOrdersListView.Items.Count - 1 - allOrdersListView.SelectedItems[0].Index] :
                    AllActiveOrdersList[allOrdersListView.Items.Count - 1 - allOrdersListView.SelectedItems[0].Index]
                );
                orderInfoPanel.ShowDialog();

                UpdateCustomersList();
                UpdateAllOrdersList();
            }
        }

        /// <summary>
        /// Выводит админу панель с подробной информацией о пользователе.
        /// </summary>
        private void CustomerInfo()
        {
            if (CurrentUser.IsAdmin)
            {
                var customerInfo = new CustomerInfo(
                    GetUserByEmail(customersListView.SelectedItems[0].Text));
                customerInfo.ShowDialog();

                UpdateCustomersList();
                UpdateAllOrdersList();
            }
        }

        /// <summary>
        /// Обновляет отображение списка товаров корзины в listview.
        /// </summary>
        private void UpdateCartList()
        {
            cartListView.Items.Clear();
            double cost = 0;
            foreach (KeyValuePair<string, int> item in Cart)
            {
                string[] row = { item.Key, item.Value.ToString(), String.Format("{0:C}", item.Value*1.25) };
                ListViewItem lvi = new ListViewItem(row);
                cartListView.Items.Add(lvi);
                cost += item.Value * 1.25;
            }

            totalCost.Text = String.Format("Total cost: {0:C}", cost);
        }

        private void cartListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            contextMenuPanel.Items.Clear();
            contextMenuPanel.Items.Add("Remove from cart");
            contextMenuPanel.Show(Cursor.Position);
        }

        /// <summary>
        /// Событие нажатия на кнопку checkout. Формирование заказа.
        /// </summary>
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (cartListView.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }

            var cartCopy = new Dictionary<string, int>();
            foreach(var item in Cart)
                cartCopy.Add(item.Key, item.Value);
            var order = new Order(cartCopy, CurrentUser.Email);
            CurrentUser.Orders.Add(order);

            UpdateOrdersList();
            Cart.Clear();
            UpdateCartList();
            MessageBox.Show("The order has been successfully completed!\nNow it is waiting to be processed by admin.");
        }

        /// <summary>
        /// Обновляет отображение списка заказов пользователя в listview.
        /// </summary>
        private void UpdateOrdersList()
        {
            ordersListView.Items.Clear();
            foreach (Order order in CurrentUser.Orders)
            {
                string[] row = { order.ID.ToString(), StatusString(order.Status), order.Ammount.ToString(),
                    String.Format("{0:C}", order.TotalCost), order.CreationTime.ToString() };
                ListViewItem lvi = new ListViewItem(row);
                ordersListView.Items.Insert(0, lvi);
            }
        }

        /// <summary>
        /// Возвращающает статус заказа (перечисление флагов).
        /// </summary>
        public static string StatusString(int status)
        {
            var statusFlags = new List<string>();
            if (status == 0)
                return String.Empty;
            for (int i = 1; i <= status; i++)
            {
                statusFlags.Add(((Status)i).ToString());
            }
            return String.Join(';', statusFlags);
        }

        /// <summary>
        /// Обновляет отображение списка пользователей в listview.
        /// </summary>
        public void UpdateCustomersList()
        {
            customersListView.Items.Clear();
            foreach (var user in Users)
            {
                // Сам админ не отображается.
                if (user.IsAdmin)
                    continue;
                string[] row = { user.Email, user.Name,
                    String.Format("{0}/{1}", user.ActiveOrders.Count.ToString(), user.Orders.Count.ToString()) };
                ListViewItem lvi = new ListViewItem(row);
                customersListView.Items.Insert(0, lvi);
            }
        }

        /// <summary>
        /// Обновляет отображение списка всех заказов пользователей в listview.
        /// </summary>
        private void UpdateAllOrdersList()
        {
            allOrdersListView.Items.Clear();

            foreach(var order in AllOrdersList)
            {
                // Если режим отображения активных заказов.
                if (ordersComboBox.SelectedIndex == 1 && order.Status == 4)
                    continue;
                string[] row = { order.ID.ToString(), StatusString(order.Status), order.CreationTime.ToString(),
                    order.Ammount.ToString(), order.CustomersEmail, String.Format("{0:C}", order.TotalCost) };
                ListViewItem lvi = new ListViewItem(row);
                allOrdersListView.Items.Insert(0, lvi);
            }
        }

        /// <summary>
        /// Отображение пользователю подробной информации о его заказе.
        /// </summary>
        private void OrderInfo()
        {
            var selectedOrder = ordersListView.SelectedItems[0].Index;
            var orderInfoPanel = new OrderInfo(CurrentUser.Orders[CurrentUser.Orders.Count - 1 - selectedOrder]);
            orderInfoPanel.ShowDialog();

            UpdateOrdersList();
        }

        /// <summary>
        /// Событие клика по списку пользователей.
        /// </summary>
        private void customersList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            if (CurrentUser.IsAdmin)
            {
                contextMenuPanel.Items.Clear();
                contextMenuPanel.Items.Add("Customer info");
                contextMenuPanel.Show(Cursor.Position);
            }
        }

        /// <summary>
        /// Находит и возвращает объект пользователя с указанным логином.
        /// </summary>
        static private User GetUserByEmail(string email)
        {
            foreach(var user in Users)
                if (user.Email == email)
                    return user;
            return null;
        }

        /// <summary>
        /// Событие клика по списку всех заказов пользователей.
        /// </summary>
        private void allOrdersListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            if (CurrentUser.IsAdmin)
            {
                contextMenuPanel.Items.Clear();
                contextMenuPanel.Items.Add("Customer's order info");
                contextMenuPanel.Show(Cursor.Position);
            }
        }

        /// <summary>
        /// Событие клика по списку заказов пользователя.
        /// </summary>
        private void ordersListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            contextMenuPanel.Items.Clear();
            contextMenuPanel.Items.Add("Order info");
            contextMenuPanel.Show(Cursor.Position);
        }

        /// <summary>
        /// Событие дабблклика по списку товаров.
        /// </summary>
        private void goodsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CurrentUser == null)
                MessageBox.Show("Log in to add items to cart");
            else if (CurrentUser.IsAdmin)
                ItemsOrders();
            else
                AddItemToCart();
        }

        /// <summary>
        /// Событие нажатия на кнопку "Orders report". Открывает админу панель с отчетом.
        /// </summary>
        private void ordersReportButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser.IsAdmin)
            {
                var ordersReport = new OrdersReport();
                ordersReport.ShowDialog();
            }
        }

        /// <summary>
        /// Возвращает список всех заказов с суммой заказа больше указанной.
        /// </summary>
        static public List<Order> GetAllOrdersWithAmmount(double ammount)
        {
            var ordersList = new List<Order>();
            foreach (var user in Users)
                foreach (var order in user.Orders)
                {
                    if(order.Ammount*1.25 >= ammount)
                        ordersList.Add(order);
                }

            // Сортирую в порядке убывания цены.
            ordersList.Sort((first, second) =>
            {
                if (first.Ammount > second.Ammount)
                    return 1;
                else if(first.Ammount == second.Ammount)
                    return -1;
                else
                    return -1;
            });
            return ordersList;
        }

        private void ordersComboBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateAllOrdersList();

        private void allOrdersListView_MouseDoubleClick(object sender, MouseEventArgs e) => OrderInfoFromAllOrdersList();

        private void customersListView_MouseDoubleClick(object sender, MouseEventArgs e) => CustomerInfo();

        private void ordersListView_MouseDoubleClick(object sender, MouseEventArgs e) => OrderInfo();
    }
}
