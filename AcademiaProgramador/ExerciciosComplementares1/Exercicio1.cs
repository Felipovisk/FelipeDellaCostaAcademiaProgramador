using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares1
{/*1)	Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, 
  * sem os minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do 
  * jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.*/
    class Exercicio1
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Digite a hora de inicio do jogo");
            int horasInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora de término do jogo");
            int horasTermino = int.Parse(Console.ReadLine());

            int duracaoDoJogo = horasTermino - horasInicio;

            Console.WriteLine("A duração do jogo foi de: " + duracaoDoJogo + " Horas.");
            Console.ReadKey();
        }
    }
}
