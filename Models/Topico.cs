using System.ComponentModel.DataAnnotations;

namespace projetogrupo.Models
{
    public class Topico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do tópico é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres.")]
        public string Nome { get; set; } = string.Empty;
        
        
    }
}
