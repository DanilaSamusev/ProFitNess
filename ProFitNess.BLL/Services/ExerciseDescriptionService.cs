using System.Collections.Generic;

using ProFitNess.DAL.Entities;
using ProFitNess.DAL.Repositories;

namespace ProFitNess.BLL.Services
{
    public class ExerciseDescriptionService
    {
        private readonly ExerciseDescriptionRepository _exerciseDescriptionRepository;

        public ExerciseDescriptionService(string connectionString)
        {
            _exerciseDescriptionRepository = new ExerciseDescriptionRepository(connectionString);
        }

        public IEnumerable<ExerciseDescription> GetAll()
        {
            return _exerciseDescriptionRepository.GetAll();
        }

        public ExerciseDescription Get(int id)
        {
            return _exerciseDescriptionRepository.Get(id);
        }

        public int Save(ExerciseDescription item)
        {
            return _exerciseDescriptionRepository.Save(item);
        }
    }
}
