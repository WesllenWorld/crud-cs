namespace GTasks.Model
{
    public class Usuario{

        //Propriedades
        //Id do usuário tem que ser único
        //O '?' indica que a propriedade pode ser nula, similar ao @nullable do Java

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        
    }
}