using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class MENU
    {
        public static int Menu()
        {
            string[] Menu = { "REGISTRAR", "ASISTENCIA", "REPORTES", "SALIR" };
            int index = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("                     SISTEMA DE GESTIÓN DE ASISTENCIA                     ");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.ResetColor();

                for (int i = 0; i < Menu.Length; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"      {Menu[i]}      ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(Menu[i] + "          ");
                    }
                }

                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index++;
                    if (index == Menu.Length)
                        index = 0;
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0)
                        index = Menu.Length - 1;
                }
            } while (tecla != ConsoleKey.Enter);

            return index;
        }
    }
}
