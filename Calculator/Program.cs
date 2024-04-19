using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Application
   {
       
   }
    public class Program {
        {
        public static void Menu(Operation[] operations)
        {
            Console.WriteLine("Новая операция:");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. {operation.Name}");
            }
        }
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
                
        public abstract class Operation
    {
        public abstract string Name { get; }

        public abstract double Run(params double[] numbers);
    }
public sealed class Addition : Operation
    public override string Name => "сложение [+]";
                        if (choice == "+")
                        {
                            foreach (int ele in Wht)
                            {
                                result = (result + ele);
                            }
                            Print(Convert.ToString(result));
                        }
                public sealed class Substraction : Operation
    {
        public override string Name => "вычитание [-]";
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
                    public sealed class Multiplacation : Operation
    {
        public override string Name => "умножение [*]";
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
                        public sealed class Division : Operation
    {
        public override string Name => "деление [:]";
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
            class ProcessCalculation
                {
        public static void TextLines()
        {
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
                        double result = 0;}
        }
