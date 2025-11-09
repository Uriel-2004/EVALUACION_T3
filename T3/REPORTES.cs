using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class REPORTES
    {
        public static void Reportes()
        {
            string[] MenuReportes = { "DOCENTE", "ESTUDIANTE", "CURSO", "VOLVER" };
            int indexReportes = 0;
            ConsoleKey tecla;

            do
            { 
                for (int i = 0; i < MenuReportes.Length; i++)
                {
                    Console.SetCursorPosition(39, 4 + i);
                    if (i == indexReportes)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {MenuReportes[i]}  ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   {MenuReportes[i]}");
                    }
                }

                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.UpArrow)
                {
                    indexReportes--;
                    if (indexReportes < 0)
                        indexReportes = MenuReportes.Length - 1;
                }
                else if (tecla == ConsoleKey.DownArrow)
                {
                    indexReportes++;
                    if (indexReportes > MenuReportes.Length - 1)
                        indexReportes = 0;
                }

            } while (tecla != ConsoleKey.Enter);

            switch (indexReportes)
            {
                case 0:
                    REGISTRAR.Docente(); break;
                case 1:
                    if (REGISTRAR.Dnis.Count == 0)
                    {
                        Console.WriteLine("No hay estudiantes registrados aún.");
                    }
                    else
                    {
                        Console.WriteLine("{0,-15} {1,-30}", "DNI", "NOMBRES");
                        for (int i = 0; i < REGISTRAR.Dnis.Count; i++)
                        {
                            Console.WriteLine("{0,-15} {1,-30}", REGISTRAR.Dnis[i], REGISTRAR.Nombres[i]);
                        }
                    } break;
                case 2:
                    REGISTRAR.Curso(); break;
                case 3: return;
            }

            Console.ReadKey(true);
        }
    }
}
