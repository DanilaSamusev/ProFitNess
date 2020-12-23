using System;
using System.Collections.Generic;
using System.Text;
using ProFitNess.DAL.Entities;
using ProFitNess.DAL.Repositories;

namespace ProFitNess.BLL.Services
{
    public class ExerciseService
    {
        private readonly ExerciseRepository _exerciseRepository;

        public ExerciseService(string connectionString)
        {
            _exerciseRepository = new ExerciseRepository(connectionString);
        }

        public IEnumerable<Exercise> GetAll()
        {
            return _exerciseRepository.GetAll();
        }

        public Exercise Get(int id)
        {
            return _exerciseRepository.Get(id);
        }

        public int Save(Exercise item)
        {
            return _exerciseRepository.Save(item);
        }
    }
}
