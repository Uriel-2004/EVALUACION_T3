using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class REGISTRAR
    {
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
                    REGISTRAR.Docente(); break;
                case 1:
                    REGISTRAR.Estudiante(); break;
                case 2:
                    REGISTRAR.Curso(); break;
                default: return;
            }
            Console.ReadKey(true);
        }
        public static void Docente()
        {
 
        }

        public static void Estudiante()
        {

        }

        public static void Curso()
        {

        }
    }
}
