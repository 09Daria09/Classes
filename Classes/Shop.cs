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
        private double square;
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
        public double Square
        {
            get => square;
            set => square = value;
        }
        public void Input()
        {
            Console.Write("Введите название магазина: ");
            Name = Console.ReadLine();
            Console.Write("Введите адрес: ");
            Address = Console.ReadLine();
            Console.Write("Введите описание профиля магазина: ");
            Descrphonetion = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            Phone = Console.ReadLine();
            Console.Write("Введите контактный e-mail: ");
            Email = Console.ReadLine();
            Console.Write("Введите площадь магазина: ");
            Square = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Название магазина: {Name}\nАдрес: {Address}\nОписание профиля магазина: {Descrphonetion}\nКонтактный номер: {Email}\nКонтактный e-mail: {email}\nПлощадь магазина: {Square}";
        }
        public static Shop operator +(Shop a, int opl)
        {
            a.Square += opl;
            return a;
        }
        public static Shop operator -(Shop a, int opl)
        {
            a.Square -= opl;
            return a;
        }
        public static bool operator ==(Shop op1, Shop op2)
        {
            return op1.Square == op2.Square;
        }
        public static bool operator !=(Shop op1, Shop op2)
        {
            return op1.Square != op2.Square;
        }
        public static bool operator <(Shop op1, Shop op2)
        {
            return op1.Square < op2.Square;
        }
        public static bool operator >(Shop op1, Shop op2)
        {
            return op1.Square > op2.Square;
        }
    }
}
