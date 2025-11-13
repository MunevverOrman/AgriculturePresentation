using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminService _adminService;

        public AdminManager(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public void Delete(Admin t)
        {
           _adminService.Delete(t);
        }

        public Admin GetById(int id)
        {
           return _adminService.GetById(id);
        }

        public List<Admin> GetListAll()
        {
            return _adminService.GetListAll();
        }

        public void Insert(Admin t)
        {
            _adminService.Insert(t);
        }

        public void Update(Admin t)
        {
            _adminService.Update(t);
        }
    }
}
