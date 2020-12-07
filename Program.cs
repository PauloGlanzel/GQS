using System;
using GQS.Cliente;
using GQS.Pedido;

namespace Grafica
{
   class Program
   {
      static void Main(string[] args)
      {
         var c1 = new Cliente();
         var p1 = new Pedido();
         parte1:
         Console.Clear();
         Console.WriteLine(">.---------- Sistema de Impressão - Gráfica Novo Horizonte ----------");
         Console.Write(">.\n>.Digite o Nome do Cliente.: ");
         string n = Console.ReadLine().ToString();
         if(String.IsNullOrEmpty(n))
            goto parte1;
         if(n.Equals("Sair") || n.Equals("sair"))
            goto parte10;
         Console.Write(">.\n>.Digite o CPF do Cliente..: ");
         string c = Console.ReadLine();
         if(c.Length != 11)
            goto parte1;

         long number1 = 0;
         bool canConvert = long.TryParse(c, out number1);

         if (canConvert == true){
            c1.SetNome(n);
            c1.SetCpf(c.Substring(0,3)+"."+c.Substring(3,3)+"."+c.Substring(6,3)+"-"+c.Substring(9,2));
         }else{
            goto parte1;
         }
         parte2:
         Console.Clear();
         Console.WriteLine(">.---------- Sistema de Impressão - Gráfica Novo Horizonte ----------\n");
         c1.infoCliente();
         Console.WriteLine(">.\n>.-------------- Informe os Dados do Serviço de Cópias --------------\n");
         
         Console.Write(">.Você deseja F-Fotocópias ou I-Impressão.: ");
         string ci = Console.ReadLine();
         if(String.IsNullOrEmpty(ci))
            goto parte2;
         if(ci.Equals("f") || ci.Equals("F"))
         {
            p1.setFotoCopia(true);
            p1.setImpressao(false);
         }
         else if(ci.Equals("i") || ci.Equals("I"))
         {
            p1.setFotoCopia(false);
            p1.setImpressao(true);
         }
         Console.Write(">.Você quer em P-Preto e Branco ou C-Colorido.: ");
         string cor = Console.ReadLine();
         if(string.IsNullOrEmpty(cor))
            goto parte2;
         if(cor.Equals("P") || cor.Equals("p"))
         {
            p1.setCor(false);
            p1.setPb(true);
         }
         else if(cor.Equals("C") || cor.Equals("c"))
         {
            p1.setCor(true);
            p1.setPb(false);
         }
         Console.Write(">.Encadernado [S/N].: ");
         String enc = Console.ReadLine();
         if(string.IsNullOrEmpty(enc))
            goto parte2;
         if(enc.Equals("S") || enc.Equals("s"))
            p1.setEncadernacao(true);
         Console.Write(">.Número de cópias.: ");
         int cop = int.Parse(Console.ReadLine());
         if(cop <= 0)
            goto parte2;
         p1.setCopias(cop);
         Console.Write(">.Número de páginas.: ");
         int pag = int.Parse(Console.ReadLine());
         if(pag <= 0)
            goto parte2;
         p1.setNumPaginas(pag);
         if(ci.Equals("i") || ci.Equals("I"))
         {
            Console.Write(">.Qual o intervalo de Impressão.: ");
            string interv = Console.ReadLine();
            Console.Write(">.Nome do arquivo para impressão.: ");
            string arq = Console.ReadLine();
            p1.setIntImpressao(interv);
            p1.setArquivo(arq);
         }

         p1.infoPedido();

         Console.Write("\n>.Deseja continuar s/n..:");
         string escolha=Console.ReadLine();
         if(String.IsNullOrEmpty(escolha))
            goto parte2;
         else if(escolha.Equals("s") || escolha.Equals("S"))
            goto parte1;
         else
            goto parte10;
         
         parte10:
         Console.Clear();
         Console.WriteLine("Fim da execução....press any key");
         Console.Read();
      }
   }
}
