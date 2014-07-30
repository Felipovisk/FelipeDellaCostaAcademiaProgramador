using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosBasicos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada.");
            Console.WriteLine("1-- Padrão 1");
            Console.WriteLine("2-- Padrão 2");
            Console.WriteLine("3-- Padrão 3");
            Console.WriteLine("4-- Padrão 4");
            Console.WriteLine("5-- Padrão 5");
            Console.WriteLine("6-- Padrão 6");
            Console.WriteLine("7-- Padrão 7");
            Console.WriteLine("8-- Sair do Programa.");

            int opcaoMenu = int.Parse(Console.ReadLine());

            if (opcaoMenu == 1)
            {
                //imprime nome numerado.
                ImprimeNome.ImprimindoNome();

                MenuPrincipal();
            }
            if (opcaoMenu == 2)
            {
                //imprime numeros em sequencia.
                ImprimeNumeros.ImprimindoNumeros();
                MenuPrincipal();
            }
            if (opcaoMenu == 3)
            {
                //imprime numeros diferenciando impares(*) e pares(**).
                ImprimeImparesEPares.ImprimindoParesEImpares();
                MenuPrincipal();
            }
            if (opcaoMenu == 4)
            {
                //imprime numeros em sequencia e os multiplos de 4(PI).
                ImprimeMultiplosDe4.ImprimindoMultiplosDe4();
                MenuPrincipal();
            }
            if (opcaoMenu == 5)
            {
                // imprime um triangulo de *
                ImprimeTriangulo.ImprimindoTriangulo();
                MenuPrincipal();
            }
            if (opcaoMenu == 6)
            {
                //imprime varios triangulos de *
                ImprimeVariosTriangulos.ImprimindoTriangulos();
                MenuPrincipal();
            }
            if (opcaoMenu == 7)
            {
                //imprime sequencia de fibonnacci
                SequenciaFibonnacci.ImprimindoSequencia();
                MenuPrincipal();
            }
            if (opcaoMenu == 8)
            {
                //finaliza o programa
                Console.WriteLine("PROGRAMA FINALIZADO.");
                
            }
        }
    }
}