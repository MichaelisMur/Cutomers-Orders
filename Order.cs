using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Customers
{
    /// <summary>
    /// Класс заказа.
    /// </summary>
    [DataContract]
    public class Order
    {
        Dictionary<string, int> items;

        /// <summary>
        /// Словарь с товарами. Key - название товара, value - количество товаров этого типа в заказе.
        /// </summary>
        [DataMember(IsRequired = true)]
        public Dictionary<string, int> Items
        {
            get => items;
            set
            {
                items = value;

                double totalCost = 0;
                int ammount = 0;
                foreach (KeyValuePair<string, int> item in items)
                {
                    ammount += item.Value;
                    totalCost += item.Value * 1.25;
                }
                
                // Общее количество товаров в заказе.
                Ammount = ammount;
                // Стоимость товаров в заказе.
                TotalCost = totalCost;
            }
        }

        [DataMember(IsRequired = true)]
        public int ID { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime CreationTime { get; set; }

        [DataMember(IsRequired = true)]
        public double Ammount { get; set; }

        [DataMember(IsRequired = true)]
        public double TotalCost { get; set; }

        [DataMember(IsRequired = true)]
        public int Status { get; set; }

        [DataMember(IsRequired = true)]
        public string CustomersEmail { get; set; }

        public Order(Dictionary<string, int> items, string email)
        {
            var random = new Random();

            CustomersEmail = email;
            Items = items;
            CreationTime = DateTime.Now;
            // Идентификационный номер заказа.
            ID = random.Next(100000000, 999999999);
        }
    }
}
