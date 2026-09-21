namespace projetogrupo.DAO
{
    public class TopicoDAO
    {
        public int Id_top { get; set; }
        public string Nome_top { get; set; } = string.Empty;
        public string id_mat_fk { get; set; } = string.Empty;
        public string id_mat { get; set; } = string.Empty;
    }
}
