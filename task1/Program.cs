using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número del mes(enero=1, febrero=2, marzo=3, abril=4, mayo=5, junio=6, julio=7, agosto=8, septiembre=9, octubre=10, noviembre=11, diciembre=12");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());
            int dias = Days(mes, año);
            Console.Write("La respuesta es: ");
            Console.WriteLine(dias);

        }

        public static int Days(int month, int year)
        {
            int respuesta = 0;
            bool bisiesto = false;
            int x = year % 4;
            int y = year % 100;

            if (x == 0 && y != 0)
            {
                bisiesto = true;
            }

            if (month == 2)
            {
                if (bisiesto == true)
                {
                    respuesta = 29;
                }
                else
                {
                    respuesta = 28;
                }
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        respuesta = 31;
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        respuesta = 30;
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" número de mes inválido ");
                        break;
                    }
            }
            return respuesta;
        }
    }
}



