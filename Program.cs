using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char sign = '@';
            int choice = 0;

            BetterTriangle();

            void BetterTriangle()
            {
                Console.Write("\n\nKérem írja be, hogy mekkora háromszöget szeretne rajzolni: ");
                while (!int.TryParse(Console.ReadLine(), out count))
                {
                    Console.Write("Hibás bevitel! Kérem írja be újra a számot: ");
                }

                Console.Write("Kérem adja meg a kívánt karaktert: ");
                while (!char.TryParse(Console.ReadLine(), out sign))
                {
                    Console.Write("Hibás bevitel! Kérem írja be újra a karaktert: ");
                }

                for (int i = 1; i <= count; i++)
                {
                    Console.SetCursorPosition((Console.WindowWidth / 2) - i, Console.WindowHeight / 2 - (count / 2) + i);
                    for (int j = 0; j < (2 * i) - 1; j++)
                    {
                        Console.Write(sign);
                    }
                }

                Console.ReadLine();

                Console.WriteLine("\n\nSzeretne még egy háromszöget rajzolni?");
                Console.Write("[1] ha igen és [0], ha nem: ");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice > 1 || choice < 0)
                {
                    Console.Write("Helytelen bevitel. Kérem adja újra meg a számot: ");
                }

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.Clear();
                        Triangle();
                        break;

                    default:
                        Environment.Exit(1);
                        break;
                }
            }

            void Triangle()
            {
                
                Console.Write("\n\nKérem írja be, hogy mekkora háromszöget szeretne rajzolni: ");
                while (!int.TryParse(Console.ReadLine(), out count))
                {
                    Console.Write("Hibás bevitel! Kérem írja be újra a számot: ");
                }

                Console.Write("Kérem adja meg a kívánt karaktert: ");
                while (!char.TryParse(Console.ReadLine(), out sign))
                {
                    Console.Write("Hibás bevitel! Kérem írja be újra a karaktert: ");
                }

                for (int i = 0; i < count; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 - (count / 2) + i);
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(sign);
                    }
                }
                for (int i = 0; i < count; i++)
                {
                    Console.SetCursorPosition((Console.WindowWidth / 2) - count, Console.WindowHeight / 2 - (count / 2) + i);
                    for (int j = 0; j < count - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(sign);
                    }
                }

                Console.ReadLine();

                Console.WriteLine("\n\nSzeretne még egy háromszöget rajzolni?");
                Console.Write("[1] ha igen és [0], ha nem: ");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice > 1 || choice < 0)
                {
                    Console.Write("Helytelen bevitel. Kérem adja újra meg a számot: ");
                }

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.Clear();
                        Triangle();
                        break;

                    default:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
