using Bootcamp.BusinessLayer.Abstract;
using Bootcamp.DataAccessLayer.Abstract;
using Bootcamp.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Bootcamp.BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void TDelete(Admin entity)
        {
            _adminDal.Delete(entity);
        }

        public List<Admin> TGetAll()
        {
            return _adminDal.GetAll();
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public void TInsert(Admin entity)
        {
            _adminDal.Insert(entity);
        }

        public void TUpdate(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}
