using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = MENU.Menu();

                switch (opcion)
                {
                    case 0:
                        REGISTRAR.Registrar(); break;
                    case 1:
                        Console.WriteLine("\n\nPróximamente T4 ...\n");
                        Console.ReadKey(); break;
                    case 2:
                        REPORTES.Reportes(); break;
                    case 3:
                    Console.WriteLine("\n\n\nSaliendo del sistema...\n"); return;
                }
            }while (true);

        }
    }
}
