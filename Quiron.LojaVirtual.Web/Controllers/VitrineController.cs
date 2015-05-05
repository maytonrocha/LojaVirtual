using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        // GET: Produtos
        private ProdutosRepositorio _repositorio;
        private int ProdutosPorPagina = 8;
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var Produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina-1)*ProdutosPorPagina)
                .Take(ProdutosPorPagina);

            return View(Produtos);
        }
    }
}