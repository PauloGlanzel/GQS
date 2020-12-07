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
        
        public void infoPedido()
        {
            Console.WriteLine(">.\n>.-----------Informações do pedido-------------");
            if(fotoCopia && !impressao)
            {
                Console.WriteLine("Fotocópia");
                qtd = copias * numPaginas;
            }
            else if(!fotoCopia && impressao)
            {
                Console.WriteLine("Impressão");
                qtd = copias * numPaginas;
            }
            if(pb && !colorido)
            {
                Console.WriteLine("Preto e Branco");
                total = qtd*vlPb;
            }
            else if(!pb && colorido)
            {
                Console.WriteLine("Colorido");
                total = qtd*vlColorido;
            }
            Console.WriteLine(total);
        }
    }
}