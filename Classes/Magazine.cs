using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Magazine
    {
        private string name;
        private string year;
        private string descrphonetion;
        private string phone;
        private string email;
        public Magazine()
        {
            name = null;
            year = null;
            descrphonetion = null;
            phone = null;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Year
        {
            get => year;
            set => year = value;
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
            Console.Write("Введите название журнала: ");
            name = Console.ReadLine();
            Console.Write("Введите год основания: ");
            year = Console.ReadLine();
            Console.Write("Введите описание журнала: ");
            descrphonetion = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            phone = Console.ReadLine();
            Console.Write("Введите контактный e-mail: ");
            email = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Название журнала: {name}\nГод основания: {year}\nОписание журнала: {descrphonetion}\nКонтактный номер: {email}\nКонтактный e-mail: {email}";
        }
    }
}
