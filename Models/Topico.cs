namespace projetogrupo.Models
{
    public class Topico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Id_mat_fk { get; set; } = string.Empty;
        public string Id_mat { get; set; } = string.Empty;
    }
}
