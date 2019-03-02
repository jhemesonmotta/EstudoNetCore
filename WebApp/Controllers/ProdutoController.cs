using Microsoft.AspNetCore.Mvc;
using System;
using WebApp.DAO;

namespace WebApp.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        
        private readonly IProdutoRepository _produtoRepository;

        // injetando a dependencia pra evitar que eu tenha q instanciar a classe aqui dentro
        public ProdutoController(IProdutoRepository produtoRepository) {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get() {
            try
            {
                return Ok(_produtoRepository.ListarProdutos());
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
        }
    }
}
