using System;
namespace GQS.Cliente
{
    class Cliente
    {
        private string Nome;
        private string Cpf;
        public void SetNome(string n)
        {
            Nome = n;
        }
        public void SetCpf(string c)
        {  
            Cpf = c;
        }
        public void infoCliente()
        {
          Console.WriteLine(">.\n>.Nome do Cliente.: {0}\n>.\n>.CPF.............: {1}\n>.",Nome,Cpf);
        }
    }
}