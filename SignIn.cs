using System;
using System.Windows.Forms;

namespace Customers
{
    // Панель регистрации.
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // Обрабатываю значения полей с обязательными параметрами.
            if(nameTextBox.Text.Length == 0 || phoneTextBox.Text.Length == 0 ||
                emailTextBox.Text.Length == 0 || addressTextBox.Text.Length == 0 ||
                passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Invaild data");
                return;
            }

            if (CustomersAndOrders.EmailsList.Contains(emailTextBox.Text))
            {
                MessageBox.Show("Email is already being used");
                return;
            }

            // Хеширую пароль.
            var hashedPassword = Hashing.ImmenseHitOfHash(passwordTextBox.Text);

            var user = new User(nameTextBox.Text, phoneTextBox.Text, emailTextBox.Text,
                hashedPassword, addressTextBox.Text);
            CustomersAndOrders.Users.Add(user);
            CustomersAndOrders.Email = emailTextBox.Text;
            CustomersAndOrders.Password = hashedPassword;
            Close();
        }
    }
}
