using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapSqlContext>, ICarDal
    {
        public List<CarDetailDto> GetCarById(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from p in filter == null ? context.Cars : context.Cars.Where(filter)
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             join d in context.Brands
                             on p.BrandId equals d.Id
                             select new CarDetailDto
                             {
                                 BrandName = d.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 Id = p.Id
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetail()
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ImagePath = (from i in context.CarImages
                                              where i.CarId == c.Id
                                              select new CarImage
                                              {
                                                  Id = i.Id,
                                                  CarId = i.CarId,
                                                  ImagePath = i.ImagePath,
                                                  Date = i.Date
                                              }).ToList()

                             };
                return result.ToList();
            }

        }

        public List<CarDetailDto> GetCarsDetail(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from p in filter == null ? context.Cars : context.Cars.Where(filter)
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             join d in context.Brands
                             on p.BrandId equals d.Id
                             select new CarDetailDto
                             {
                                 BrandName = d.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 Id = p.Id,
                                 ImagePath = (from i in context.CarImages
                                              where i.CarId == c.Id
                                              select new CarImage
                                              {
                                                  Id = i.Id,
                                                  CarId = i.CarId,
                                                  ImagePath = i.ImagePath,
                                                  Date = i.Date
                                              }).ToList()
                             };
                return result.ToList();
            }
        }
    }
}
