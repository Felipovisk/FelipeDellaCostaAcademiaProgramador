using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosBasicos
{
    
    class SequenciaFibonnacci
    {
        public static int[] SequenciaFib = new int[30] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        

        public static void ImprimindoSequencia()
        {
            for (int i = 3; i < SequenciaFib.Length; i++)
            {
                SequenciaFib[i] = SequenciaFib[(i - 1)] + SequenciaFib[(i - 2)];
            }

            for (int i = 2; i < SequenciaFib.Length; i++)
            {
                Console.WriteLine(SequenciaFib[i]);
            }
            Console.ReadKey();
        }
    }
}
