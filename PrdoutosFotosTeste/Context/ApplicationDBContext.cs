using Microsoft.EntityFrameworkCore;
using ProdutosFotosTeste.Models;
using System.Collections.Generic;

namespace ProdutosFotosTeste.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        //public DbSet<ApartmentOptions> ApartmentOptions { get; set; }

        public DbSet<ProdutoFotos> ProdutoFotos { get; set; }
    }
}
