using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares1
{/*3)	Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, 
  * calcular e escrever o saldo atual (saldo atual = saldo - débito + crédito). Também testar se 
  * saldo atual for maior ou igual a zero escrever a mensagem 'Saldo Positivo', senão escrever a 
  * mensagem 'Saldo Negativo'. */
    class Exercicio3
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Digite o numero da conta corrente.");
            int contaCorrente = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo.");
            double saldoConta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o débito.");
            double debitoConta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o crédito.");
            double creditoConta = double.Parse(Console.ReadLine());

            double saldoAtual = saldoConta - debitoConta + creditoConta;

            if (saldoAtual >= 0)
            {
                Console.WriteLine("Saldo Positivo.");
            }
            else
            {
                Console.WriteLine("Saldo Negativo.");
            }
            Console.ReadKey();

        }
    }
}
