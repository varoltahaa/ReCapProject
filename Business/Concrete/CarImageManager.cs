using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage, IFormFile formFile)
        {
            carImage.Date = DateTime.Now;
            carImage.ImagePath = FileHelper.AddFile(formFile);

            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var image = _carImageDal.Get(i => i.Id == carImage.Id);

            if (image == null)
            {
                return new ErrorResult();
            }

            FileHelper.DeleteFile(image.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetById(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i => i.Id == id));
        }

        public IResult Update(CarImage carImage, IFormFile formFile)
        {
            var image = _carImageDal.Get(i => i.Id == carImage.Id);
            if (image == null)
            {
                return new ErrorResult();
            }

            carImage.Date = DateTime.Now;
            carImage.ImagePath = FileHelper.UpdateFile(formFile, image.ImagePath);

            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
    }
}
