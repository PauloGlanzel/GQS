using System;
namespace GQS.Cliente
{
    class Cliente
    {
        public string Nome;
        public string Cpf;

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
            Console.WriteLine(">.\n>.Nome do Cliente.: {0} - CPF.: {1}",Nome,Cpf);
        }
    }
}