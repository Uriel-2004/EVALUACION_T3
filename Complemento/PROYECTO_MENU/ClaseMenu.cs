using System;


namespace PROYECTO_MENU
{
    public class ClaseMenu
    {
        //Creamos un método para elegir una opción del menú y devoler la opción elegida pero su índice
        public static int OpcionMenu()
        {
            string[] arregloMenu = { "REGISTRAR", "ASISTENCIA", "REPORTES", "SALIR" };

            int index = 0;

            ConsoleKey tecla;//La variable tecla acepta el valor que produce al presionar una tecla

            do
            {
                //Limpiar la pantalla
                Console.Clear();

                //Con este for vamos a presentar todos los datos del arreglo
                for (int i = 0; i < arregloMenu.Length; i++)
                {
                    //Con esta condición evaluamos si la variable index es igual al contador i
                    //Para que si son iguales marque la opción
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("   " + arregloMenu[i] + "   ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(arregloMenu[i] + "     ");
                    }
                }

                //Sirve para que al presionar una tecla me capture el dato que genera dicha tecla
                ConsoleKeyInfo info = Console.ReadKey(true);//Se pone true porque no necesitamos observar el valor de la tecla que se presiono
                tecla = info.Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index++;

                    if (index > arregloMenu.Length - 1)
                    {
                        index = 0;
                    }
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0)
                    {
                        index = arregloMenu.Length - 1;
                    }

                }

            } while (tecla != ConsoleKey.Enter);

            //Retornamos el index de la opcion que se elige
            return index;
        }


    }
}

