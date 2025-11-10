using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class REGISTRAR
    {
        public static List<string> dnis = new List<string>();
        public static List<string> nombds = new List<string>();

        public static List<string> Dnis = new List<string>();
        public static List<string> Nombres = new List<string>();
        public static List<string> Cursos = new List<string>();

        public static List<string> Codigo = new List<string>();
        public static List<string> Nombre = new List<string>();
        public static List<string> Precio = new List<string>();

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
            Console.Clear();

            while (true)
            {
                Console.WriteLine("===== REGISTRO DE DOCENTE =====");
                Console.SetCursorPosition(5, 2);
                Console.Write("DNI DOCENTE: ");
                Console.SetCursorPosition(2, 4);
                Console.Write("NOMBRE DOCENTE: ");

                Console.SetCursorPosition(18, 2);
                string dni = Console.ReadLine();

                if (dni.Length != 8)

                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 20);
                    Console.WriteLine("Error: El DNI debe tener 8 dígitos numéricos.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                bool numeros = true;
                for (int i = 0; i < dni.Length; i++)
                {
                    if (!char.IsDigit(dni[i]))
                    {
                        numeros = false;
                        break;
                    }
                }
                if (!numeros)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 20);
                    Console.WriteLine("Error: El DNI solo puede contener números.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (dnis.Contains(dni))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 20);
                    Console.WriteLine("Error: Este DNI ya está registrado.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.SetCursorPosition(18, 4);
                string nmbd = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nmbd))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 20);
                    Console.WriteLine("Error, Debe escribir un nombre para registrarlo.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                bool letras = true;
                foreach (char c in nmbd)

                    if (!char.IsLetter(c) && c != ' ')
                    {
                        letras = false;
                        break;
                    }
                if (!letras)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 20);
                    Console.WriteLine("Error: El nombre solo puede contener letras.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                dnis.Add(dni);
                nombds.Add(nmbd);

                Console.SetCursorPosition(5, 20);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Docente registrado correctamente. Presiona cualquier tecla...");
                Console.ResetColor();

                break;
            }
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

                        bool letras = true;
                        foreach (char c in nombre)
                        {
                            if (!char.IsLetter(c) && c != ' ')
                            {
                                letras = false;
                                break;
                            }
                        }

                        if (!letras)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(5, 20);
                            Console.WriteLine("Error: El nombre solo puede contener letras.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }

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
            bool registrado = false;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=============================================");
                Console.WriteLine("       SISTEMA DE GESTIÓN DE ASISTENCIA      ");
                Console.WriteLine("=============================================");
                Console.ResetColor();
                Console.WriteLine("\n[REGISTRAR NUEVO CURSO]\n");

                Console.Write("CÓDIGO (6 caracteres, único): ");
                string codigo = Console.ReadLine().Trim().ToUpper();

                if (codigo.Length != 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: El código debe tener exactamente 6 caracteres.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (Codigo.Contains(codigo))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Este código ya está registrado.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                Console.Write("CURSO (Nombre único): ");
                string nombre = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: El nombre no puede estar vacío.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                bool letras = true;
                foreach (char c in nombre)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        letras = false;
                        break;
                    }
                }

                if (!letras)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: El nombre solo puede contener letras.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (Nombre.Any(n => n.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Este curso ya existe.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                Console.Write("PRECIO (>= 0): ");
                string precioInput = Console.ReadLine();

                if (!decimal.TryParse(precioInput, out decimal precioDecimal) || precioDecimal < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: El precio debe ser un número válido y mayor o igual a 0.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                Codigo.Add(codigo);
                Nombre.Add(nombre);
                Precio.Add(precioDecimal.ToString("F2"));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine($"CÓDIGO: {codigo}");
                Console.WriteLine($"CURSO:  {nombre}");
                Console.WriteLine($"PRECIO: {precioDecimal:F2}");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\nSe guardó correctamente el nuevo curso...");
                Console.ResetColor();

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");

                registrado = true; 
            }
            while (!registrado);
        }
    }
}
