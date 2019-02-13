using System;
using System.Collections.Generic;

namespace WebApp.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
