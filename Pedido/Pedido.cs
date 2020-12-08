using System;
namespace GQS.Pedido
{
    public class Pedido
    {
        //atributos
        private bool fotoCopia = false;
        private bool impressao = false;
        private bool colorido = false;
        private bool pb = false;
        private bool encadernacao = false;
        private float vlPb = 0.05f;
        private float vlColorido = 0.10f;
        private float vlEncadernacao = 2.00f;
        private int copias;
        private int numPaginas;
        private string intImpressao;
        private string arquivo;
        private float total;
        private int qtd;
        public void setFotoCopia(bool ftc) => fotoCopia = ftc;
        public void setImpressao(bool imp) => impressao = imp;
        public void setCor(bool cor) => colorido = cor;
        public void setPb(bool p) => pb = p;
        public void setEncadernacao(bool enc) => encadernacao = enc;
        public void setNumPaginas(int n) => numPaginas = n;
        public void setCopias(int cop) => copias = cop;
        public void setIntImpressao(string imp) => intImpressao = imp;
        public void setArquivo(string arq) => arquivo = arq;
        private string tipo;
        private string cor;
        private double preco;
        public void infoPedido()
        {
            string linha = ">.\n>.-----------------------------------------------------------";
            Console.WriteLine(">.\n>.----------------- Informações do pedido -------------------");
            if(fotoCopia && !impressao)
            {
                tipo = "Fotocópia";
                qtd = copias * numPaginas;
            }
            else if(!fotoCopia && impressao)
            {
                tipo = "Impressão";
                qtd = copias * numPaginas;
            }
            if(pb && !colorido)
            {
                cor = "Preto e Branco";
                total = qtd*vlPb;
                preco = vlPb;
            }
            else if(!pb && colorido)
            {
                cor = "Colorido";
                total = qtd*vlColorido;
                preco = vlColorido;
            }
            if(encadernacao)
            {
                float capa = vlEncadernacao*copias;
                Console.WriteLine(">.\n>.Você pediu {0}, {1}, Encadernado.", tipo, cor);
                Console.WriteLine(">.\n>.{0} cópia(s) de {1} página(s), = {2} impressão(ões)\n>.ao valor unitário de R$ {3} cada.", copias, numPaginas, qtd, preco.ToString("N2"));
                if(!fotoCopia && impressao)
                    Console.WriteLine(">.\n>.Intervalo de páginas {0}, do arquivo: {1}",intImpressao, arquivo);
                Console.WriteLine(">.\n>.Valor das cópias.................................: R$ {0}",total.ToString("N2"));                
                float totPedido = total + capa;
                Console.WriteLine(">.\n>.Valor da Encadernação............................: R$ {0}", capa.ToString("N2"));
                Console.WriteLine(">.\n>.Valor Total do Pedido de Cópias..................: R$ {0}", totPedido.ToString("N2"));
                Console.WriteLine(linha);
            }
            else
            {
                float capa = 0;
                Console.WriteLine(">.\n>.Você pediu {0}, {1}, SEM encadernação.", tipo, cor);
                Console.WriteLine(">.\n>.{0} cópia(s) de {1} página(s), = {2} impressão(ões)\n>.ao valor unitário de R$ {3} cada.", copias, numPaginas, qtd, preco.ToString("N2"));
                if(!fotoCopia && impressao)
                    Console.WriteLine(">.\n>.Intervalo de páginas {0}, do arquivo: {1}",intImpressao, arquivo);
                Console.WriteLine(">.\n>.Valor das cópias.................................: R$ {0}",total.ToString("N2"));                
                float totPedido = total + capa;
                Console.WriteLine(">.\n>.Valor da Encadernação............................: R$ {0}", capa.ToString("N2"));
                Console.WriteLine(">.\n>.Valor Total do Pedido de Cópias..................: R$ {0}", totPedido.ToString("N2"));
                Console.WriteLine(linha);
            }
        }
    }
}