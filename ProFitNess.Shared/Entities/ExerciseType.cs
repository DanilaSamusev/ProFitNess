using SQLite;

namespace ProFitNess.DAL
{
    [Table("Friends")]
    public class ExerciseType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
