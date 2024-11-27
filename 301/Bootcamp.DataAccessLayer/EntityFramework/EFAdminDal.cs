using Bootcamp.DataAccessLayer.Abstract;
using Bootcamp.DataAccessLayer.Repositories;
using Bootcamp.EntityLayer.Concrete;

namespace Bootcamp.DataAccessLayer.EntityFramework
{
    public class EFAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }

    // CRUD and admins that have names without letter 'a' will be here
}
