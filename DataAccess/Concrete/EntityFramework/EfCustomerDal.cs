using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 ID = c.Id,
                                 UserName = u.FirstName,
                                 UserLastName = u.LastName,
                                 UserMail = u.Email,
                                 CompanyName = c.CompanyName
                             };

                return result.ToList();
            }
        }
    }
}
