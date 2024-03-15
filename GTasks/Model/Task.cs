namespace GTasks.Model{
    public class Task{
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Estado { get; set; }
        public string? UsuarioId { get; set; }
    }
}