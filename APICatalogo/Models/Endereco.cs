using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
