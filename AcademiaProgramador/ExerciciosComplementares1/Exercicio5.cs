using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares1
{/*5)	Um posto está vendendo combustíveis com a seguinte tabela de descontos: 
Álcool 	até 20 litros, desconto de 3% por litro:
		Acima de 20 litros, desconto de 5% por litro. 
Gasolina até 20 litros, desconto de 4% por litro:
		Acima de 20 litros, desconto de 6% por litro.
Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da 
  * seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente 
  * sabendo-se que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90. */

    class Exercicio5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de litros.");
            int litrosCombustivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo do combustivel. A-álcool, G-gasolina.");
            string tipoCombustivel = Console.ReadLine();

            double valorAPagar;
            if (tipoCombustivel == "A")
            {
                double calcDesconto;
                if (litrosCombustivel < 20)
                {
                    calcDesconto = 2.90 * 5 / 100;
                }
                else
                {
                    calcDesconto = 2.90 * 3 / 100;
                }
                valorAPagar = (litrosCombustivel * (2.90 - calcDesconto));
                Console.WriteLine(valorAPagar);
            }
            else if (tipoCombustivel == "G")
            {
                double calcDesconto;
                if (litrosCombustivel < 20)
                {
                    calcDesconto = 3.30 * 6 / 100;
                }
                else
                {
                    calcDesconto = 3.30 * 4 / 100;
                }
                valorAPagar = (litrosCombustivel * (3.30 - calcDesconto));
                Console.WriteLine(valorAPagar);

            }
            else
            {
                Console.WriteLine("parametros inválidos.");
            }
            Console.ReadKey();
        }
    }
}
