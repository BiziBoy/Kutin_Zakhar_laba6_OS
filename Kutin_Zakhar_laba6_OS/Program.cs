using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muxanov_Kutin_laba6_OS
{
    class Program
    {

        static string[] menu = { "Add task\n", "Delete task\n", "Stop task\n", "Show status\n", "Exit\n" };
        static bool isExit = false;

        static int globalID = 0;

        public static void Main(string[] args)
        {
            Console.Write("WELCOME");
            OperationMemory op = new OperationMemory();
            while (!isExit)
            {
                printMenu();
                Console.WriteLine("Choose menu task: ");
                int option = int.Parse(Console.ReadLine());
                int num;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter size: ");
                        num = int.Parse(Console.ReadLine());
                        op.addProcess(new Process(num, globalID++));
                        break;

                    case 2:
                        Console.WriteLine("Enter id: ");
                        num = int.Parse(Console.ReadLine());
                        op.deleteFromOpMemory(num);
                        break;

                    case 3:
                        Console.WriteLine("Enter id: ");
                        num = int.Parse(Console.ReadLine());
                        op.pauseProcess(num);
                        break;

                    case 4: op.showStatusMemory(); break;
                    case 5:
                        isExit = true; break;

                    default: Console.WriteLine("Error!!!\n\n"); break;
                }
            }
        }

        static void printMenu()
        {
            Console.WriteLine("\n\n");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}) {1}", i + 1, menu[i]);
            }
        }
    }
}