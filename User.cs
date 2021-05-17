using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Customers
{
    /// <summary>
    /// Класс пользователя. Информация и список заказов.
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        [DataMember(IsRequired = true)]
        public string Phone { get; set; }

        [DataMember(IsRequired = true)]
        public string Address { get; set; }

        [DataMember(IsRequired = true)]
        public string Email { get; set; }

        [DataMember(IsRequired = true)]
        public string Password { get; set; }

        [DataMember(IsRequired = true)]
        public List<Order> Orders { get; set; }

        // Логин и пароль админа: admin.
        public bool IsAdmin{
            get => Email == "admin" && Password == Hashing.ImmenseHitOfHash("admin");
        }

        /// <summary>
        /// Активные заказы.
        /// </summary>
        public List<Order> ActiveOrders
        {
            get
            {
                var activeOrders = new List<Order>();
                Orders.ForEach(order =>
                {
                    // Если статус не Completed.
                    if (order.Status != 4)
                        activeOrders.Add(order);
                });
                return activeOrders;
            }
        }

        public User(string name, string phone, string email, string password, string address)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Password = password;
            Address = address;
            Orders = new List<Order>();
        }
    }
}
