using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares1
{/*4)	Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e 
  * quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade 
  * média = quantidade máxima + quantidade mínima) /2). Se a quantidade em estoque for maior ou igual 
  * a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar 
  * compra'. */
    class Exercicio4
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Digite a quantidade atual em estoque.");
            int quantidadeAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima em estoque.");
            int quantidadeMaxima = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade mínima em estoque.");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            double quantidadeMedia = quantidadeMaxima + quantidadeMinima / 2;

            if (quantidadeAtual >= quantidadeMedia)
            {
                Console.WriteLine(quantidadeMedia);
                Console.WriteLine("Não efetuar compra.");
            }
            else
            {
                Console.WriteLine(quantidadeMedia);
                Console.WriteLine("Efetuar compra.");
            }
            Console.ReadKey();



        }
    }
}
