using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutosFotosTeste.Models
{
    public class ProdutoFotos
    {
        [Key]
        public int ProdutoFotosId { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; private set; }

        public string FotoPath { get; set; }

    }
}
