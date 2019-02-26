using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entidades;

namespace WebApp.DAO
{
    // segue o repository pattern que diz que uma classe deve ser utilizada para encapsular toda a lógica de acesso ao BD
    public class ProdutoRepository : IProdutoRepository
    {
        // _ para todas private
        private readonly MyWebAppContext _myWebAppContext;

        public ProdutoRepository(MyWebAppContext myWebAppContext)
        {
            _myWebAppContext = myWebAppContext;
        }

        public List<Produto> ListarProdutos() {
            // retorna todos os produtos da base de dados
            return _myWebAppContext.Produtos.ToList();
        }
    }
}
