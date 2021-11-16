using System;

namespace Challengue1_meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número del mes(enero=1, febrero=2, marzo=3, abril=4, mayo=5, junio=6, julio=7, agosto=8, septiembre=9, octubre=10, noviembre=11, diciembre=12");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());
            bool bisiesto = false;
            int x = año % 4;
            int y = año % 100;

            if (x == 0 && y!= 0)
            {
                bisiesto = true;
            }

            if (mes ==2)
            {
                if (bisiesto == true)
                {
                    Console.WriteLine(" 29 días ");
                }
                else
                {
                    Console.WriteLine(" 28 días ");
                }
            }
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10: 
                case 12:
                    {
                       Console.WriteLine(" 31 días ");
                       break; 
                    }
                case 4:
                case 6:
                case 9:
                case 11: 
                        { 
                         Console.WriteLine(" 30 días ");
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
        }
    }
}