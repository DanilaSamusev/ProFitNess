using SQLite;

namespace ProFitNess.DAL.Entities
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }
    }
}
