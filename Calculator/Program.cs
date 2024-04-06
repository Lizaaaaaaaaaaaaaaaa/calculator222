using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args) {
            try
            {
                Console.WriteLine("Вместо знака √ используйте # ");
                Console.WriteLine("Выберите необходимое количество чисел ");
                string a = (Console.ReadLine());
                string[] Nums = a.Split(new char[] { ' ' }); //Создоётся массив в который записываются числа считываясь через пробел
                double[] Wht = new double[Nums.Length];
                int gg = 0;
                foreach (string el in Nums) // Цикл перебора объектов в массиве
                {
                    Wht[gg] = Convert.ToDouble(el);
                    gg++;
                }
                Console.WriteLine("Выберите номер вида операции: 1.Алгебраические; 2.Тригонометрические");
                string f = (Console.ReadLine());
                switch (f) {
                    case "1":
                        Console.WriteLine("Выбирите оперцию: x ^ y; # х; сложение [+]; вычитание [-]; деление [:]; умножение [*]");
                        break;

                    case "2":
                        Console.WriteLine("Выбирите оперцию: Sin | Cos | tan");
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда!!!!!");
                        break;

                        string choice = Console.ReadLine();
                        double result = 0;

                        if (choice == "+")
                        {
                            foreach (int ele in Wht)
                            {
                                result = (result + ele);
                            }
                            Print(Convert.ToString(result));
                        }
                        else if (choice == "-")
                        {
                            result = Wht[0];
                            foreach(int ele in Wht)
                            {
                            result = (result - ele);
                            }
                            result = result + Wht[0];
                            Print(Convert.ToString(result));
                        }
                        else if (choice == "*")
                        {
                            result = Wht[0];
                            foreach(int ele in Wht)
                            {
                            result = (result * ele);
                            }
                            result = result / Wht[0];
                            Print(Convert.ToString(result));
                        }
                        else if (choice == ":")
                        {
                            result = Wht[0];
                            foreach(int ele in Wht)
                            {
                            result = (result / ele);
                            }
                            result = result * Wht[0];
                            Print(Convert.ToString(result));
                        }
                }

            }
Consol.ReadLine();
        }
       public static void Ptint(string Text) 
        {
            Console.WriteLine(Text);
        }
    }
}
