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
        private int countPeople;
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
        public int CountPeople
        {
            get => countPeople;
            set => countPeople = value;
        }
        public void Input()
        {
            Console.Write("Введите название журнала: ");
            Name = Console.ReadLine();
            Console.Write("Введите год основания: ");
            Year = Console.ReadLine();
            Console.Write("Введите описание журнала: ");
            Descrphonetion = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            Phone = Console.ReadLine();
            Console.Write("Введите контактный e-mail: ");
            Email = Console.ReadLine();
            Console.Write("Введите количество сотрудников: ");
            countPeople = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Название журнала: {Name}\nГод основания: {Year}\nОписание журнала: {Descrphonetion}\nКонтактный номер: {Phone}\nКонтактный e-mail: {email}\nКоличество сотрудников: {countPeople}";
        }

        public static Magazine operator +(Magazine a, int opl)
        {
            a.countPeople += opl;
            return a;
        }
        public static Magazine operator -(Magazine a, int opl)
        {
            a.countPeople -= opl;
            return a;
        }
        public static bool operator ==(Magazine op1, Magazine op2)
        {
            return op1.countPeople == op2.countPeople;
        }
        public static bool operator !=(Magazine op1, Magazine op2)
        {
            return op1.countPeople != op2.countPeople;
        }
        public static bool operator <(Magazine op1, Magazine op2)
        {
            return op1.countPeople < op2.countPeople;
        }
        public static bool operator >(Magazine op1, Magazine op2)
        {
            return op1.countPeople > op2.countPeople;
        }
    }
}
