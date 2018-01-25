using RotasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RotasMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasAsNoticias;

        public HomeController()//construtor >> em caso de duvidas assistir aula de poo
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }
        public ActionResult Index()
        {
            var utimasNoticias = todasAsNoticias.Take(3);
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();
            ViewBag.Categorias = todasAsCategorias;
            return View(utimasNoticias);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }
     
        public ActionResult MostraNoticia(int noticaId, string titulo, string categoria)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.categoria = categoria;
            return View(categoriaEspecifica);
        }
    }
}