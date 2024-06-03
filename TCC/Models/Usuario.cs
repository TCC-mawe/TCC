using SQLite;

namespace TCC.Models
{
    [Table ("Usuarios")]
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id_User { get; set; }

        [NotNull]
        public string User { get; set; }

        [NotNull]
        public string Email { get; set; }

        [NotNull]
        public string Senha { get; set; }

        [MaxLength(11), NotNull] 
        public int Telefone { get; set; }
    }
}
