using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class REGISTRAR
    {
        public static List<string> Dnis = new List<string>();
        public static List<string> Nombres = new List<string>();

        public static void Registrar()
        {
            string[] MenuRegistrar = { "DOCENTE", "ESTUDIANTE", "CURSO", "VOLVER" };
            int indexReg = 0;
            ConsoleKey tecla;

            do
            {
                Console.SetCursorPosition(0, 4);

                for (int i = 0; i < MenuRegistrar.Length; i++)
                {
                    if (i == indexReg)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {MenuRegistrar[i]}  ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   {MenuRegistrar[i]}");
                    }
                }

                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.UpArrow)
                {
                    indexReg--;
                    if (indexReg < 0)
                        indexReg = MenuRegistrar.Length - 1;
                }
                else if (tecla == ConsoleKey.DownArrow)
                {
                    indexReg++;
                    if (indexReg > MenuRegistrar.Length - 1)
                        indexReg = 0;
                }

            } while (tecla != ConsoleKey.Enter);

            switch (indexReg)
            {
                case 0:
                    Docente(); break;
                case 1:
                    Estudiante(); break;
                case 2:
                    Curso(); break;
                default: return;
            }
            Console.ReadKey(true);
        }
        public static void Docente()
        {
 
        }

        public static void Estudiante()
        {
            {
                bool registrado = false;

                do
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("                     SISTEMA DE GESTIÓN DE ASISTENCIA                     ");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("===== REGISTRAR ESTUDIANTE =====");
                    Console.Write("DNI ESTUDIANTE: ");
                    string dni = Console.ReadLine();

                    if (dni.Length != 8)
                    {
                        Console.WriteLine("Error: El DNI debe tener exactamente 8 dígitos.");
                        Console.ReadKey();
                    }
                    else if (Dnis.Contains(dni))
                    {
                        Console.WriteLine("Error: Este DNI ya está registrado.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("NOMBRE ESTUDIANTE: ");
                        string nombre = Console.ReadLine();

                        Dnis.Add(dni);
                        Nombres.Add(nombre);

                        Console.WriteLine("\nSe guardó correctamente al nuevo estudiante...");

                        registrado = true;
                    }
                } while (!registrado);
            }
        }

        public static void Curso()
        {

        }
    }
}
