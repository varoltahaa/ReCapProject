using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.Collections.Generic;
using System;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());



            foreach (var c in carManager.GetCarDetail())
            {
                Console.WriteLine(c.CarName+" "+c.ColorName+" "+c.DailyPrice);
            }
            

        }

    }
}
