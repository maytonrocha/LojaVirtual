using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        // GET: Produtos
        private ProdutosRepositorio _repositorio;
        private int ProdutosPorPagina = 3;
        public ActionResult ListaProdutos(string categoria, int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repositorio.Produtos
                .Where(p => categoria == null || p.Categoria == categoria)
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

                Paginacao = new Paginacao
                {
                    ItensPorPagina = ProdutosPorPagina,
                    PaginaAtual = pagina,
                    ItensTotal = categoria == null ? _repositorio.Produtos.Count() : _repositorio.Produtos.Where(p => p.Categoria == categoria).Count()
                },

                CategoriaAtual = categoria
            };

            return View(model);
        }
    }
}