using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapSqlContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail() 
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id

                             select new RentalDetailDto
                             {
                                Id = r.Id,
                                CarName = b.BrandName,
                                FirstName = u.FirstName,
                                LastName = u.LastName,
                                RentDate = r.RentDate,
                                ReturnDate = r.ReturnDate,
                                CustomerName = cu.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
