using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x");
            string str = Console.ReadLine();
            double x = double.Parse(str);

      

            double g = 0;
            if (x%2 ==0) 
            {
                g = x / 2;

            }

            if (!(x % 2 == 0))
            {

                g = ++g / 2;
            }

           

            Console.WriteLine("Вы ввели x= " + x + "\n Результат работы программы = " + g);
            Console.ReadLine();

        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x");
            string str = Console.ReadLine();
            double x = double.Parse(str);

      

            double g = 0;
            if (x%4 ==0) 
            {
                g = x / 4;

            }

            if (!(x%4 == 0))
            {

                g = x + 4;
            }

           

            Console.WriteLine("Вы ввели x= " + x + "\n Результат работы программы = " + g);
            Console.ReadLine();

        }
    }
}





