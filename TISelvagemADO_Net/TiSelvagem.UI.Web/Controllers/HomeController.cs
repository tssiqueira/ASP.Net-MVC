﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiSelvagem.Aplicacao;

namespace TiSelvagem.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* var appAluno = new AlunoAplicacao();
             var listaDeAlunos = appAluno.ListarTodos();
             return View(listaDeAlunos);
             */
            return View();
        }

    }
}