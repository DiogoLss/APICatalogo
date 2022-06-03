﻿using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;
public class APICatalogoContext : DbContext
{
    protected APICatalogoContext(DbContextOptions<APICatalogoContext> options ) : base( options )
    {
    }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
}
