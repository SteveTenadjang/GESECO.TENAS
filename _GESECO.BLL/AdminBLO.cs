using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class AdminBLO
    {
        private readonly DataDAO<Admin> AdminRepo;

        public AdminBLO(string dbFolder)
        {
            AdminRepo = new DataDAO<Admin>(dbFolder);
        }

        public void AddAdmin(Admin admin)
        {
            AdminRepo.Add(admin);
        }

        public void DeleteAdmin(Admin admin)
        {
            AdminRepo.Remove(admin);
        }

        public void EditAdmin(Admin oldAdmin, Admin newAdmin)
        {
            AdminRepo.Set(oldAdmin, newAdmin);
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            return AdminRepo.Find();
        }

        public IEnumerable<Admin> GetBy(Func<Admin, bool> predicate)
        {
            return AdminRepo.Find(predicate);
        }
        //can use the getby methode to find an admin by diffrent ways but a FUNC is needed

        public IEnumerable<Admin> GetByID(string id)
        {
            return AdminRepo.Find(x => x.ID == id);
        }
        public int CountAdmin()
        {
            return AdminRepo.CountRepo();
        }

    }
}
