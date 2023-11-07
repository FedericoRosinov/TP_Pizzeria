using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    public class Pedido

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public Cliente cliente { get; set; }
        public EstadoDePago estado { get; set; }
        public MetodoDePago metodoDePago { get; set; }
    }
}
