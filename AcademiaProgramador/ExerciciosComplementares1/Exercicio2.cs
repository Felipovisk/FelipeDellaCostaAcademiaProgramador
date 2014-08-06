using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares1
{/*2)	A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar 
      * mais de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo 
      * de 50%. Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por 
      * hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, 
      * caso tenham sido trabalhadas (considere que o mês possua 4 semanas exatas). */
    class Exercicio2
    {

        public static void Main1(string[] args)
        {
            Console.WriteLine("Digite as horas trabalhadas.");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora.");
            double salarioHora = double.Parse(Console.ReadLine());

            
            if (horasTrabalhadas > 160)
            {
                double valorHoraExtra = (salarioHora * 50 / 100);
                double calculaHoraExtra = ((salarioHora + valorHoraExtra) * horasTrabalhadas);
                Console.WriteLine(calculaHoraExtra);
            }
            else if (horasTrabalhadas > 0 && horasTrabalhadas <= 160)
            {
                double calculoSalario = salarioHora * horasTrabalhadas;
                Console.WriteLine(calculoSalario);
            }
            else
            {
                Console.WriteLine("Horas Trabalhadas inválidas.");
            }
            Console.ReadKey();





            




        }
    }
}
