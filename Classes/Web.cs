using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Web
    {
        private string name;
        private string path;
        private string description;
        private string ip;

        public Web()
        {
            name = null;
            path = null;
            description = null;
            ip = null;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Path
        {
            get => path;
            set => path = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public string Ip
        {
            get => ip;
            set => ip = value;
        }
        public void Input()
        {
            Console.Write("Введите название сайта: ");
            name = Console.ReadLine();
            Console.Write("Введите путь к сату: ");
            path = Console.ReadLine();
            Console.Write("Введите описание сайта: ");
            description = Console.ReadLine();
            Console.Write("Введите IP адрес сайта: ");
            ip = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Название сайта: {name}\nПуть к сайту: {path}\nОписание сайта: {description}\nIP адрес сайта: {ip}";
        }

    }
}
