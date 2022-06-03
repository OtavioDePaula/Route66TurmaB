using Route66TurmaB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route66TurmaB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> AsNoticias;

        public HomeController()
        {
            AsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Noticia()
        {
            return View(AsNoticias);
        }

        public ActionResult Index()
        {
            var ultimasNoticias = AsNoticias.Take(3);
            var AsCategorias = AsNoticias.Select(x => x.Categoria).Distinct().ToList();
            ViewBag.Categorias = AsCategorias;
            return View(ultimasNoticias);
        }

        public ActionResult MostraNoticia(int noticiaid)
        {
            return View(AsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaid));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            ViewBag.Categoria = categoria;
            return View(AsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList());
        }
    }
}