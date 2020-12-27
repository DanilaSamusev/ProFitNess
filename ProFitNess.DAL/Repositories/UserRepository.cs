using System.Collections.Generic;
using System.Linq;
using ProFitNess.DAL.Entities;

using SQLite;

namespace ProFitNess.DAL.Repositories
{
    public class UserRepository
    {
        private readonly SQLiteConnection _database;

        public UserRepository(string connectionString)
        {
            _database = new SQLiteConnection(connectionString);
            _database.CreateTable<User>();
        }

        public User GetByMailAndPassword(string password, string mail)
        {
            return _database
                .Query<User>("SELECT * FROM Users u " +
                             $"WHERE u.Password = '{password}' AND " +
                             $"u.Mail = '{mail}'")
                .FirstOrDefault();
        }

        public int Save(User item)
        {
            return _database.Insert(item);
        }
    }
}
