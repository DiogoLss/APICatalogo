using APICatalogo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;
public class APICatalogoContext : IdentityDbContext<Cliente,ClienteRole, int>
{
    public APICatalogoContext(DbContextOptions<APICatalogoContext> options ) : base( options )
    {
    }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Pedido> Compras { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
}
