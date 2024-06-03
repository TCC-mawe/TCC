using SQLite;
using System.Diagnostics.CodeAnalysis;

namespace TCC.Models
{
    public class Lugar
    {
        [PrimaryKey]
        public int Id { get; set; }

        [NotNull]
        public string Nome_cidade { get; set; }
        [NotNull]
        public string Nome_Lugar { get; set; }

        public string Descricao { get; set; }
       
        public int Id_comentario { get; set; }
        public int Id_proprietario { get; set; }

    }
}
