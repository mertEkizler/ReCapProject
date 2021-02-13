using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstMethod();
            //CarManagerTest();
            //Test();

            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success==true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName + " / " + item.LastName + " / " + item.UserId + " / " + item.Email + " / " + item.Password);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
                
           
        }

        private static void Test()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = userManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Car Name: " + car.CarId + " / " + "Color Name: " + car.ColorName + " / " + "Brand Name: " + car.BrandName + " / " + "Daily Price: " + car.DailyPrice + " TL");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void FirstMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());




            Console.WriteLine("Brand Id'si 1 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByBrandId(1).Data)
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).Data}\t\t{brandManager.GetById(car.BrandId).Data}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByColorId(2).Data)
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).Data}\t\t{brandManager.GetById(car.BrandId).Data}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nId'si 2 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            Car carById = carManager.GetById(2).Data;
            Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).Data}\t\t{brandManager.GetById(carById.BrandId).Data}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Descriptions}");


            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 165 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(100, 165).Data)
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).Data}\t\t{brandManager.GetById(car.BrandId).Data}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n");

            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = -300, ModelYear = "2021", Descriptions = "Otomatik Dizel" });
            brandManager.Add(new Brand { BrandName = "a" });
        }
    }
}
