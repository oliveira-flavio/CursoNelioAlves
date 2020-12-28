using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
       
        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total R$: "
            + ValorTotalEmEstoque().ToString("F2");
        }

        // métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
