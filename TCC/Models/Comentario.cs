using SQLite;

namespace TCC.Models
{
    public class Comentario
    {
        [AutoIncrement, PrimaryKey]
        public int id_usuario { get; set; }

        public string usuarios { get; set; }

        public string comentario { get; set; }

        public double nota { get; set; }

       
    }
}
