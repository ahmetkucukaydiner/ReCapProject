using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var c in carManager.GetAll())
            //{
            //    Console.WriteLine(c.Description);
            //}



            BrandManager brandManager = new BrandManager(new EfBrandDal());

            ColorManager colorManager = new ColorManager(new EfColorDal());

            CarManager carManager = new CarManager(new EfCarDal());

            VeriDondurme();
            GetCarsByBrandId();
            GetCarsByColorId();
            //CarAdd();
            CarGetAll();
            CarGetById();



        }
        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetById(55);
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + " " + car.DailyPrice + " " + car.Description /* + eklenebilir. */);
            }
        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine(result.Data);
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 55, Description = "Mercedes", DailyPrice = 1200, ModelYear = 2008 });
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description + "Eklendi!");
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine(result.Data);
            }
        }

        private static void VeriDondurme()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine("---------------------");
            }
        }
    }
}
