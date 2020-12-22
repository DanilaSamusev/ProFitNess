using System.Collections.Generic;

using SQLite;

namespace ProFitNess.DAL.Repositories
{
    public class ExerciseTypeRepository
    {
        private readonly SQLiteConnection _database;

        public ExerciseTypeRepository(string connectionString)
        {
            _database = new SQLiteConnection(connectionString);
            _database.CreateTable<ExerciseType>();
        }

        public IEnumerable<ExerciseType> GetAll()
        {
            return _database.Table<ExerciseType>().ToList();
        }

        public ExerciseType Get(int id)
        {
            return _database.Get<ExerciseType>(id);
        }

        public int Save(ExerciseType item)
        {
            return _database.Insert(item);
        }
    }
}
