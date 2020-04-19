﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();

            return View(produto);
            // return new ContentResult() { Content = "Produto -> Visualizar" };
        }

        private Produto GetProduto()
        {
            return new Produto()
            {

                Id = 1,
                Nome = "Xbox One X",
                Descricao = "Jogue em 4k",
                Valor = 2000.00M
            };
        }
    }
}