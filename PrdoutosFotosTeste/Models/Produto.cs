using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutosFotosTeste.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public bool Estado { get; set; }

        [Required]
        
        public int ProdutoFotosId { get; set; }
        //public virtual ProdutoFotos ProdutoFotos { get; set; }
        public virtual List<ProdutoFotos> ProdutoFotos { get; set; } = new List<ProdutoFotos>();


    }
}
