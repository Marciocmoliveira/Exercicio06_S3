using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06_S3
{
     class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.nome = "Calculadora";
            produto1.verificarEstoque();
            Console.WriteLine("O nome do produto é: " + produto1.nome);

            ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
            classeFilha.nome = "Produto Financeiro";
            classeFilha.verificarEstoque();
            classeFilha.acesso();
        }
    }

    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso;
        private double preco;

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void alteraAtributosPrivados(double peso2, double preco)
        {
            this.peso = peso2;
            this.preco = preco;
            Console.WriteLine("Variável peso de escopo da classe: " + peso);
        }
    }

    class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {
            Produto PF1 = new Produto();
            PF1.nome = "Produto Financeiro";
            PF1.cor = "Verde";
            Console.WriteLine("Nome: " + PF1.nome + " Cor: " + PF1.cor);
            vender();
            verificarEstoque();
            alteraAtributosPrivados(99, 100.0);
        }
    }
}
