using System;
using System.Collections.Generic;
using System.Text;
using ProFitNess.DAL.Entities;
using ProFitNess.DAL.Repositories;

namespace ProFitNess.BLL.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(string connectionString)
        {
            _userRepository = new UserRepository(connectionString);
        }

        public User GetByMailAndPassword(string password, string mail)
        {
            return _userRepository.GetByMailAndPassword(password, mail);
        }

        public int Save(User item)
        {
            return _userRepository.Save(item);
        }
    }
}
