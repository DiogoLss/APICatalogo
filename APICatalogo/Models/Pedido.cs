using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public int NotaFiscal { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public int IdCompra { get; set; }
        public Produto Produto { get; set; }
        public Compra Compra  { get; set; }
    }
}
