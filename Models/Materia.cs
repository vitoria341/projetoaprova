using System.ComponentModel.DataAnnotations;

namespace projetogrupo.Models
{
    public class Materia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da matéria é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição da matéria é obrigatória.")]
        [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; } = string.Empty;
    }
}

