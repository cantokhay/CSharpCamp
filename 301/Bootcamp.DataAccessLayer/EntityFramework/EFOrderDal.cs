using Bootcamp.DataAccessLayer.Abstract;
using Bootcamp.DataAccessLayer.Repositories;
using Bootcamp.EntityLayer.Concrete;

namespace Bootcamp.DataAccessLayer.EntityFramework
{
    public class EFOrderDal : GenericRepository<Order>, IOrderDal
    {
    }
}
