using SQLite;

namespace ProFitNess.DAL.Entities
{

    [Table("Exercises")]
    public class Exercise
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Calories { get; set; }

        public string ImagePath { get; set; }

        public int ExerciseTypeId { get; set; }
    }
}
