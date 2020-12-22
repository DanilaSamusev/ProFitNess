using SQLite;

namespace ProFitNess.DAL
{
    [Table("ExerciseTypes")]
    public class ExerciseType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
