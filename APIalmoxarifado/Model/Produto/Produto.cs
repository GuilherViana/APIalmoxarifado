using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Model
{
    public class Produto
    {

        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public int estoque { get; set; }

        public string? photourl { get; set;}
            
    
    }
}
