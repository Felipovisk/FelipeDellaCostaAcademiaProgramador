using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaCartaoDeCredito
    {
        public static void Main1()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 19736576;
            cdc1.dataDeValidade = "08/2018";

            Cliente c1 = new Cliente();
            c1.codigo = 198733;
            c1.nome = "Saudosista";


            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 987657319;
            cdc2.dataDeValidade = "10/2021";

            cdc1.cliente = c1;

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);

            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);

            Console.WriteLine(c1.codigo);
            Console.WriteLine(c1.nome);

            Console.ReadKey();


        }


    }
}
