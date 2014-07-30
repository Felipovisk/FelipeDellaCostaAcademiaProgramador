using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosBasicos
{
    class ImprimeImparesEPares
    {
        

        public static void ImprimindoParesEImpares()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
            Console.ReadKey();
            
            
        }
    }
}
