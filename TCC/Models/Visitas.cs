using SQLite;

namespace TCC.Models
{
    public class Visitas
    {
        [AutoIncrement]
        public int id_comentario {  get; set; }
        public int id_lugar {  get; set; }
        public string estados_visitados {  get; set; }

    }
}
