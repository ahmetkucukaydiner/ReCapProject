using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult("Araç eklendi.");
            }
            else if (car.Description.Length > 2 && car.DailyPrice < 0)
            {
                //Console.WriteLine("Günlük fiyat 0'dan büyük olmalıdır.");
                return new ErrorResult("Günlük fiyat 0'dan büyük olmalıdır.");
            }
            else if (car.Description.Length < 2 && car.DailyPrice > 0)
            {
                //Console.WriteLine("Araç açıklaması 2 harften uzun olmalıdır.");
                return new ErrorResult("Araç açıklaması 2 harften uzun olmalıdır.");
            }
            else
            {
                //Console.WriteLine("Günlük fiyat 0'dan büyük olmalı ve araç açıklaması 2 harften uzun olmalıdır.");
                return new ErrorResult("Günlük fiyat 0'dan büyük olmalı ve araç açıklaması 2 harften uzun olmalıdır.");
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araç silindi.");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Araçlar listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Araç güncellendi");
        }
    }
}
