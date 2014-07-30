using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosBasicos
{
    class ImprimeMultiplosDe4
    {

        

        public static void ImprimindoMultiplosDe4()
        {
            for (int i = 1; i < 101; i++)
            {
                int multiplo = i % 4;
                if (multiplo == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
