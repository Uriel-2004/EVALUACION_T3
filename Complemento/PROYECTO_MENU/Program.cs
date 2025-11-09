using System;


namespace PROYECTO_MENU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = ClaseMenu.OpcionMenu();

                Console.WriteLine();

                //Permite ubicar el cursor en pantalla (lado izquierdo,de arriba a abajo)
                Console.SetCursorPosition(5, 20);
                Console.WriteLine("Usted eligio el index: " + opcion);
                Console.ReadKey();
            } while (opcion != 3);
        }
            public static void SubmenuRegistrar()
            {
                string[] opciones = { "DOCENTE", "ESTUDIANTE", "CURSO" };
                int index = 0;
                ConsoleKeyInfo tecla;

                do
                {
                    Console.Clear();
                    Console.WriteLine("=== REGISTRAR ===\n");

                    for (int i = 0; i < opciones.Length; i++)
                    {
                        if (i == index)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                            Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write($"[{opciones[i]}] ");
                    }

                    Console.ResetColor();
                    tecla = Console.ReadKey(true);

                    if (tecla.Key == ConsoleKey.RightArrow)
                        index = (index + 1) % opciones.Length;
                    else if (tecla.Key == ConsoleKey.LeftArrow)
                        index = (index - 1 + opciones.Length) % opciones.Length;
                    else if (tecla.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        switch (index)
                        {
                            case 0:
                                Console.WriteLine("Registrar Docente...");
                                break;
                            case 1:
                                Console.WriteLine("Registrar Estudiante...");
                                break;
                            case 2:
                                Console.WriteLine("Registrar Curso...");
                                break;
                        }
                        Console.WriteLine("\nPresione una tecla para regresar...");
                        Console.ReadKey();
                        break;
                    }

                } while (true);
            }

        
    }
}