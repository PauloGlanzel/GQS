using System;
using GQS.TelaInicial;
using GQS.Cliente;

namespace Grafica
{
   class Program
   {
      static void Main(string[] args)
      {
         parte1:
         Console.Clear();
         var t1 = new MontarTela();
         Console.Write(">.\n>.Digite o Nome do Cliente.: ");
         string n = Console.ReadLine().ToString();
         Console.Write(">.\n>.Digite o CPF do Cliente..: ");
         string c = Console.ReadLine();
         Cliente c1 = new Cliente();
         c1.SetNome(n);
         c1.SetCpf(c);
         c1.infoCliente();
         parte2:
         Console.Write(">.\n>.Efetuar novo Pedido de Impressão? [s/n]: ");
         string escolha=Console.ReadLine();
         if(String.IsNullOrEmpty(escolha))
         {
            goto parte2;
         }
         else if(escolha.Equals("s") || escolha.Equals("S"))
         {
            goto parte1;
         }
         else
         {
            goto parte3;
         }
         parte3:
         Console.Clear();
         Console.WriteLine("Fim da execução....press any key");
         Console.Read();
      }

   }
}
