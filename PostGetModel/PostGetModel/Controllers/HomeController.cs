using PostGetModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Thiago Siqueira",
                Twitter = "@thiagosiqueira"
            };

            //opcao 1:
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Twitter"] = pessoa.Twitter;
            
            // opcao 2: o view bag tem a mesma funcao do view data, mas ele eh dinamico
            //ViewBag.PessoaId = pessoa.PessoaId;
            //ViewBag.NomeDaPessoa = pessoa.Nome;
            //ViewBag.Twitter = pessoa.Twitter;

            // opcao 3: view tipada, ou seja, o return View recebe o objeto, ou seja, o View(pessoa). Para isso, vou precisar adicionar '@model PostGetModel.Models.Pessoa' na pagina HTML
            
            return View(pessoa);
        }

        // Opcao 1: enviar dados via paremetro
        /*
        [HttpPost] // [HttpPost] = encapsular a URI. Para usar o metodo GET, eh preciso apaga-lo e trocar de Post para Get na pagina HTML
        public ActionResult Lista(int PessoaId, string Nome, string Twitter)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Twitter"] = Twitter;

            return View();
        }
        */

        // Opcao 2: enviar os mesmos dados via FormCollection
        /*
        public ActionResult Lista(FormCollection form)
        {
            ViewData["PessoaId"] = form["PessoaId"];
            ViewData["Nome"] = form["Nome"];
            ViewData["Twitter"] = form["Twitter"];
            
            return View();
        }
        */

        //Opcao 3: enviar objeto se a sua view for tipada   
        /*
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Twitter"] = pessoa.Twitter;

            return View();
        }
        */

        // opcao 4: passar o objeto diretamente para o resultado. para isso eu preciso adicionar a tag ' @Model PostGetModel.Models.Pessoa'  no view 
        public ActionResult Lista(Pessoa pessoa)
        {
            

            return View(pessoa);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}