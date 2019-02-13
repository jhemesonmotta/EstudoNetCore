using Microsoft.EntityFrameworkCore;
using WebApp.Entidades;

namespace WebApp.DAO
{
    public class MyWebAppContext : DbContext
    {
        // precisa do driver de conexão pro mySql
            // nuguet console
                // Install-Package Pomelo.EntityFramework.MySql
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> Itens { get; set; }
    }
}
