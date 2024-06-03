using SQLite;


namespace TCC.Models
{
    public class Criador
    {
        [AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string User_criador {  get; set; }

        [NotNull]
        public string Email_criador {  get; set; }

        [NotNull]
        public string Senha_criador {  get; set; }

        [MaxLength(11), NotNull]
        public int Telefone { get; set; }

        [MaxLength(11), NotNull]
        public int CPF { get; set; }
    }
}
