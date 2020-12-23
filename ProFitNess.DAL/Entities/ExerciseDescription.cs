using SQLite;

namespace ProFitNess.DAL.Entities
{
    
    public class ExerciseDescription
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public int Calories { get; set; }
    }
}
