using System.ComponentModel.DataAnnotations;

namespace projetogrupo.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email do usuário é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha do usuário é obrigatório.")]
        [StringLength(8, ErrorMessage = "A senha deve ter no máximo 8 caracteres.")]
        public string Senha { get; set; } = string.Empty;
    }
}
