using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Model.Descrição
{
    public class Departamento

    {
        [Key]
        public int id { get; set; }

        public string descricao { get; set; }

        public bool ativo { get; set; }
    }
}