using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;
[Table("Categorias")]
public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }
    [Required(ErrorMessage ="Insira o nome")]
    [StringLength(80)]
    public string? Nome { get; set; }
    [Required(ErrorMessage ="Insira a Url")]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}
