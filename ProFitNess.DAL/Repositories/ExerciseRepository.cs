using System.Collections.Generic;
using System.Linq;
using ProFitNess.DAL.Entities;

using SQLite;

namespace ProFitNess.DAL.Repositories
{
    public class ExerciseRepository
    {
        private readonly SQLiteConnection _database;

        public ExerciseRepository(string connectionString)
        {
            _database = new SQLiteConnection(connectionString);
            _database.CreateTable<Exercise>();
        }

        public IEnumerable<Exercise> GetAll()
        {
            return _database.Table<Exercise>().ToList();
        }

        public Exercise Get(int id)
        {
            return _database.Get<Exercise>(id);
        }

        public Exercise GetByName(string name)
        {
            return _database
                .Query<Exercise>("SELECT * FROM Exercises e " +
                                 $"WHERE e.Name = '{name}'")
                .FirstOrDefault();
        }

        public IEnumerable<Exercise> GetNameByTypeId(int typeId)
        {
            return _database
                .Query<Exercise>("SELECT * FROM Exercises e " +
                                 $"WHERE e.ExerciseTypeId = {typeId}");
        }

        public int Save(Exercise item)
        {
            return _database.Insert(item);
        }
    }
}
