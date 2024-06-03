using SQLite;

namespace TCC.Models
{
    public class Regiao1
    {
        [AutoIncrement, NotNull]
        public string Nome {  get; set; }
        
        public int id_estado { get; set; }
    }
}
