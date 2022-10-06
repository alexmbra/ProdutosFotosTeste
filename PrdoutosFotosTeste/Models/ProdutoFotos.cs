using System.ComponentModel.DataAnnotations;

namespace ProdutosFotosTeste.Models
{
    public class ProdutoFotos
    {
        [Key]
        public int ProdutoFotosId { get; set; }

        public string FotoPath { get; set; }



        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }
    }
}
