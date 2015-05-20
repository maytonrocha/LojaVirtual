using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class TesteCarrinhoCompras
    {
        [TestMethod]
        public void AdicionarItensAoCarrinho()
        {
            Produto produto1 = new Produto
            {
                  ProdutoId = 1,
                  Nome = "Teste1"
            };

            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste2"
            };

            Carrinho carrinho = new Carrinho();
            
            carrinho.AdicionarItem(produto1, 2);
            carrinho.AdicionarItem(produto2, 3);

            ItemCarrinho[] itens = carrinho.ItensCarrinho.ToArray();

            Assert.AreEqual(itens.Length, 2);
            Assert.AreEqual(itens[0].Quantidade, 2);
            Assert.AreEqual(itens[1].Produto, produto2);
        }

        [TestMethod]
        public void 
    }
}
