using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    public class Cliente : IdentityUser<int>
    {
        [Required]
        [Column(TypeName ="int(4)")]
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public ICollection<Compra> Compras { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
