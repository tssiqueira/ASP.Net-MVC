using ExemploValidacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {
        
        public ActionResult Index()
        {
            var pessoa = new Pessoa();

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {

            //validacao no lado do servidor; nao 'e indicado para todos os casos, pois custa mais memoria. validar pelo client side onera menos os sistema
            /*
            if (string.IsNullOrEmpty(pessoa.Nome)) //verifica se o nome da pessoa foi preenchido
            {
                ModelState.AddModelError("Nome", "O campo nome 'e obrigatorio");
            }

            if (pessoa.Senha != pessoa.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas nao conferem");
            }
            */

            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);   
            }

            return View(pessoa);    
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);    
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomeDeExemplo = new Collection<string> //simulacao validacao servidor (na vida real substituir array por banco de dados 
                {
                    "Clayton",
                    "Anderson",
                    "Renata"
                };
            return Json(bancoDeNomeDeExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }


    }

}