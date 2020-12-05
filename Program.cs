using System;
using GQS.TelaInicial;
using GQS.Cliente;

namespace Grafica
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new MontarTela();
            Cliente c1 =  new Cliente("Paulo", "123");
            Console.WriteLine(c1.Nome);
            Console.Read();
        }
    }
}
