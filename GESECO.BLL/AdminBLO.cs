using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class AdminBLO
    {
        readonly DataDAO<Admin> AdminRepo;
        public AdminBLO(string dbFolder)
        {
            AdminRepo = new DataDAO<Admin>(dbFolder);
        }
        public void CreateAdmin(Admin admin)
        {
            AdminRepo.Add(admin);
        }
        public void DeleteAdmin(Admin admin)
        {
            AdminRepo.Remove(admin);
        }
        public IEnumerable<Admin> GetAllAdmins()
        {
            return AdminRepo.Find();
        }
        public IEnumerable<Admin> GetByPoste(string poste)
        {
            return AdminRepo.Find(x => x.Poste == poste);
        }

        public IEnumerable<Admin> GetBy(Func<Admin, bool> predicate)
        {
            return AdminRepo.Find(predicate);
        }

        public void EditAdmin(Admin oldAdmin, Admin newAdmin)
        {
            AdminRepo.Set(oldAdmin, newAdmin);
        }

        public IEnumerable<Admin> ConfirmPassword(string password)
        {
            return AdminRepo.Find(x => x.PassWord == password);
        }
    }
}
