using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine();
            magazine.Input();
            string str = magazine.ToString();
            Console.WriteLine(str);

            Shop shop = new Shop();
            shop.Input();
            string str1 = shop.ToString();
            Console.WriteLine(str1);

            Web web = new Web();
            web.Input();
            string str2 = web.ToString();
            Console.WriteLine(str2);
        }
    }
}
