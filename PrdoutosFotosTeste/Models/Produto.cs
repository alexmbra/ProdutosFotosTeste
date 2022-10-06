using System.ComponentModel.DataAnnotations;

namespace ProdutosFotosTeste.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        public bool Estado { get; set; }


        public List<ProdutoFotos> ProdutoFotos { get; set; }

    }
}
