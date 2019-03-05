using System.Collections.Generic;
using WebApp.Entidades;

namespace WebApp.DAO
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
        Produto ObterProdutoPorId(int id);
        void Salvar(Produto produto);
    }
}