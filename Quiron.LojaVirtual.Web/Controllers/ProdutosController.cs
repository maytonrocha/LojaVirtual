using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        private ProdutosRepositorio _repositorio;
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var Produtos = _repositorio.Produtos;

            return View(Produtos);
        }
    }
}