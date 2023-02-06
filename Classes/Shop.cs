using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Shop
    {
        private string name;
        private string address;
        private string descrphonetion;
        private string phone;
        private string email;
        public Shop()
        {
            name = null;
            address = null;
            descrphonetion = null;
            phone = null;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Descrphonetion
        {
            get => descrphonetion;
            set => descrphonetion = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public void Input()
        {
            Console.Write("Введите название магазина: ");
            name = Console.ReadLine();
            Console.Write("Введите адрес: ");
            address = Console.ReadLine();
            Console.Write("Введите описание профиля магазина: ");
            descrphonetion = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            phone = Console.ReadLine();
            Console.Write("Введите контактный e-mail: ");
            email = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Название магазина: {name}\nАдрес: {address}\nОписание профиля магазина: {descrphonetion}\nКонтактный номер: {email}\nКонтактный e-mail: {email}";
        }
    }
}
