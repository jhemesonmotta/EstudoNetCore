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

        public MyWebAppContext(DbContextOptions<MyWebAppContext> options):base(options)
        {
            // aqui eu defino que estou enviando para o base (ou seja, DBContext) as informações desta classe
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.Id); // aqui informo q a tabela produto tem uma chave chamada "Id"
            modelBuilder.Entity<ItemPedido>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);

        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

        //Executa "Add-Migration MyWebAppMigration" para habilitar o recurso de migrations no projeto
    }
}
