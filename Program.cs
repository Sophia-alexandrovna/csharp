using System;
using System.Collections;

namespace ConsoleProject1
{
    class Gas
    {
        public int payment;
        public string payer;

        public Gas(string payer, double amount)
        {
            this.payment = (int) Math.Truncate(amount * .6);
            this.payer = payer;
        }
    }

    class Electricity
    {
        public int payment;
        public string payer;

        public Electricity(string payer, double amount)
        {
            this.payment = (int) Math.Truncate(amount * .75);
            this.payer = payer;
        }

        public Electricity(string payer, int price)
        {
            this.payment = price;
            this.payer = payer;
        }
    }

    class Request
    {
        public static void Fill(Gas[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите имя плательщика и показания счётчика:\n");
                arr[i] = new Gas(Console.ReadLine(), double.Parse(Console.ReadLine()));
            }
        }

        public static void Fill(Electricity[] arr)
        {
            Console.WriteLine("После выбора способа оплаты введите имя плательщика и сумму/показания счетчика.");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Выберите способ оплаты: Фиксированная цена (0) или Среднемесячный расчёт (1): ");
                string s = Console.ReadLine();
                arr[i] = (s == "0") ? new Electricity(Console.ReadLine(), int.Parse(Console.ReadLine())) : new Electricity(Console.ReadLine(), double.Parse(Console.ReadLine()));
            }
        }

        public static void Fill(ArrayList ls, Gas[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                ls.Add(arr[i]);
            }
        }

        public static void Fill(ArrayList ls, Electricity[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                ls.Add(arr[i]);
            }
        }

        public static void Log(Gas[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Имя плательщика: " + arr[i].payer + "\n\tОплата: " + arr[i].payment + " руб.\n");
            }
        }

        public static void Log(Electricity[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("Имя плательщика: " + arr[i].payer + "\n\tОплата: " + arr[i].payment + " руб.\n");
			}
		}

        public static void Log(ArrayList ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                Gas gas;
                Electricity el;
                if (ls[i].GetType() == typeof(Gas))
                {
                    gas = (Gas)ls[i];
                    Console.WriteLine("Имя плательщика: " + gas.payer + "\n\t Оплата: " + gas.payment + " руб.\n");
                }
                else
                {
					el = (Electricity)ls[i];
					Console.WriteLine("Имя плательщика: " + el.payer + "\n\t Оплата: " + el.payment + " руб.\n");
                }
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во плательщиков за газ: ");
            Object arr = new Gas[int.Parse(Console.ReadLine())];
            ArrayList ls = new ArrayList();

            Request.Fill((Gas[]) arr);
            Request.Fill(ls, (Gas[]) arr);

            Console.Write("Введите кол-во плательщиков за электроэнергию: ");
            arr = new Electricity[int.Parse(Console.ReadLine())];

            Request.Fill((Electricity[]) arr);
            Request.Fill(ls, (Electricity[]) arr);

            Console.WriteLine();
            Request.Log(ls);
            Console.ReadLine();
        }
    }
}
