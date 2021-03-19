using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class UserBLO
    {
        private readonly DataDAO<User> UserRepo;

        public UserBLO(string dbFolder)
        {
            UserRepo = new DataDAO<User>(dbFolder);
        }

        public void SaveUser(User user)
        {
            UserRepo.AddUser(user);
        }

        public IEnumerable<User> GetUser()
        {
            return UserRepo.Find();
        }
    }
}
