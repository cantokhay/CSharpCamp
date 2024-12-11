using Bootcamp.BusinessLayer.Abstract;
using Bootcamp.DataAccessLayer.Abstract;
using Bootcamp.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Bootcamp.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerFirstName!= string.Empty && entity.CustomerFirstName.Length >= 3  && entity.CustomerCity != null && entity.CustomerLastName != string.Empty && entity.CustomerFirstName.Length <= 30)
            {
                _customerDal.Insert(entity);
            }
            else
            {
                //Error Message
            }
        }

        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId != 0 && entity.CustomerCity.Length >= 3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                //Error Message
            }
        }
    }
}
