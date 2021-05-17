using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Customers
{
    /// <summary>
    /// Класс с одним-единственным статичным методом, шифрующим строки при помощи алгоритма SHA-256.
    /// </summary>
    class Hashing
    {
        /// <summary>
        /// Метод, шифрующий строки при помощи алгоритма SHA-256.
        /// </summary>
        /// <param name="password">Пароль, который необходимо зашифровать.</param>
        public static string ImmenseHitOfHash(string password)
        {
            // Дай мне соль.
            var salt = ASCIIEncoding.UTF8.GetBytes("this is salt");
            var plainData = ASCIIEncoding.UTF8.GetBytes(password);

            // Массив байтов plainData и salt.
            var plaintDataAndSalt = new byte[plainData.Length + salt.Length];
            plainData.CopyTo(plaintDataAndSalt, 0);
            salt.CopyTo(plaintDataAndSalt, plainData.Length);

            SHA256Managed sha = new SHA256Managed();
            var hashValue = sha.ComputeHash(plaintDataAndSalt);

            var result = new byte[hashValue.Length + salt.Length];
            hashValue.CopyTo(result, 0);
            salt.CopyTo(result, hashValue.Length);

            // Возвращаю строковое представление.
            return Convert.ToBase64String(result);
        }
    }
}
