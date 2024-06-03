using SQLite;

namespace TCC.Models
{
    public class Estado
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string Nome_estado { get; set; }

        [MaxLength(2)]
        public string UR { get; set; }
    }
}
