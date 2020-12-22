using System.Collections.Generic;

using ProFitNess.DAL;
using ProFitNess.DAL.Repositories;

namespace ProFitNess.BLL.Services
{
    public class ExerciseTypeService
    {
        private readonly ExerciseTypeRepository _exerciseTypeRepository;

        public ExerciseTypeService(string connectionString)
        {
            _exerciseTypeRepository = new ExerciseTypeRepository(connectionString);
        }

        public IEnumerable<ExerciseType> GetAll()
        {
            return _exerciseTypeRepository.GetAll();
        }

        public ExerciseType Get(int id)
        {
            return _exerciseTypeRepository.Get(id);
        }

        public int Save(ExerciseType item)
        {
            return _exerciseTypeRepository.Save(item);
        }
    }
}
