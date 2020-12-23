using System.Collections.Generic;

using ProFitNess.DAL.Entities;

using SQLite;

namespace ProFitNess.DAL.Repositories
{
    public class ExerciseDescriptionRepository
    {
        private readonly SQLiteConnection _database;

        public ExerciseDescriptionRepository(string connectionString)
        {
            _database = new SQLiteConnection(connectionString);

            _database.CreateTable<Exercise>();
            _database.CreateTable<ExerciseType>();
        }

        public IEnumerable<ExerciseDescription> GetAll()
        {
            return _database.Query<ExerciseDescription>("SELECT e.Id, e.Name, e.Calories FROM Exercises e " +
                                                         "JOIN ExerciseTypes et ON e.ExerciseTypeId = et.Id " +
                                                         "WHERE e.ExerciseTypeId = 1");
        }

        public ExerciseDescription Get(int id)
        {
            return _database.Get<ExerciseDescription>(id);
        }

        public int Save(ExerciseDescription item)
        {
            return _database.Insert(item);
        }
    }
}
