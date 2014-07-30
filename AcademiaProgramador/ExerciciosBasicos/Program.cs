using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosBasicos
{
    class Program
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

            while (opcaoMenu != 8)
            {
                if (opcaoMenu == 1)
                {
                    ImprimeNome.ImprimindoNome();
                   
                    MenuPrincipal();

                }
                if (opcaoMenu == 2)
                {
                    ImprimeNumeros.ImprimindoNumeros();
                    MenuPrincipal();
                }
                if (opcaoMenu == 3)
                {
                    ImprimeImparesEPares.ImprimindoParesEImpares();
                    MenuPrincipal();
                }
                if (opcaoMenu == 4)
                {
                    ImprimeMultiplosDe4.ImprimindoMultiplosDe4();
                    MenuPrincipal();
                }
                if (opcaoMenu == 5)
                {
                    ImprimeTriangulo.ImprimindoTriangulo();
                    MenuPrincipal();
                }
                if (opcaoMenu == 6)
                {
                    ImprimeVariosTriangulos.ImprimindoTriangulos();
                    MenuPrincipal();
                }
                if (opcaoMenu == 7)
                {
                    SequenciaFibonnacci.ImprimindoSequencia();
                    MenuPrincipal();
                }
                if (opcaoMenu == 8)
                {
                    Console.WriteLine("PROGRAMA FINALIZADO.");
                    break;
                }
            }
        }
    }
}
