using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAO;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // por usar automapping, ele já identifica naturalmente que o método ActionResult Index() do HomeController chama a página index, da pasta Home dentro de Views


        private readonly IProdutoRepository _repository;

        public HomeController(IProdutoRepository repository)
        {
            _repository = repository;
        }


        // Action Result é uma interface do asp.net core
        public IActionResult Index() {


            // quando este controller receber uma requisição ele vai retornar uma view e renderizar uma página na tela
                // passando como parâmetro o retorno do método de listar produtos
                // minha variável "Model" na view é oq eu passar como parâmetros aqui
            //return View(_repository.ListarProdutos());
            return View();
        }

        //acessado pela rota /home/Obter
        public string Obter() {
            return "Obtendo";
        }
    }
}
