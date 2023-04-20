/*
 * Crea una función que dibuje una escalera según su número de escalones.
 * - Si el número es positivo, será ascendente de izquiera a derecha.
 * - Si el número es negativo, será descendente de izquiera a derecha.
 * - Si el número es cero, se dibujarán dos guiones bajos (__).
 * 
 * Ejemplo: 4
 *         _
 *       _|       
 *     _|
 *   _|
 * _|
 * 
 */
using System;

namespace Stairs
{
    internal class StairsDrawer
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter the number of steps:");
                int iNumberSteps;

                if (int.TryParse(Console.ReadLine(), out iNumberSteps))
                {
                    DrawerStairs drawerStairs = new DrawerStairs();
                    drawerStairs.drawStairs(iNumberSteps);

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Error - Please enter an integer number.");
                }

            } while (true);
           
        }
    }

    public class DrawerStairs
    {
        private const string Step = "__";
        private const string UpStep = "_|";
        private const string DownStep = "|_";
        private const string WhiteStep = "  ";

        public void drawStairs(int iNumberSteps)
        {
            Console.WriteLine();

            switch (iNumberSteps)
            {
                case < 0:
                    drawDownStairs(Math.Abs(iNumberSteps));
                    break;

                case > 0:
                    drawUpStairs(iNumberSteps);
                    break;

                default:
                    Console.WriteLine(Step);
                    break;
            }
        }

        public void drawUpStairs(int iNumberSteps)
        {
            for (int i = 0; i <= iNumberSteps; i++)
            {
                // Print spaces for indentation
                for (int j = 0; j < iNumberSteps - i; j++)
                {
                    Console.Write(WhiteStep);
                }

                if(i == 0)
                {
                    Console.Write(Step);
                }
                else
                {
                    Console.Write(UpStep);
                }
                
                Console.WriteLine();
            }
        }

        public void drawDownStairs(int iNumberSteps)
        {

            for (int i = iNumberSteps; i >= 0; i--)
            {

                for (int j = 0; j < iNumberSteps - i; j++)
                {
                    Console.Write(WhiteStep);
                }

                if (i == iNumberSteps)
                {
                    Console.Write(Step);
                }
                else
                {
                    Console.Write(DownStep);
                }

                Console.WriteLine();
            }

        }
    }
}
