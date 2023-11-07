using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;


namespace Pizzeria.Context;




public class PizzeriaDBContext : DbContext
{
    //public DbSet<Pizzeria> Pizzeria { get; set; }
    //public DbSet<Producto> Producto { get; set; }
    //public DbSet<Pedido> Pedido { get; set; }
    //public DbSet<MetodoDePago> MetodoDePago { get; set; }
    //public DbSet<EstadoDePago> EstadoDePago { get; set; }
    //public DbSet<Pago> Pago { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public PizzeriaDBContext(DbContextOptions<PizzeriaDBContext>
options) : base(options)
    { }
    public DbSet<Pizzeria.Models.Pedido>? Pedido { get; set; }



}