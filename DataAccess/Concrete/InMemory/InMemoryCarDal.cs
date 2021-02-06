//using DataAccess.Concrete.InMemoryDal;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car> {

//                new Car{CarId=1, CarName="Honda", BrandId=2, ColorId=2, Description="Spor", ModelYear=2017, DailyPrice=310000 },
//                new Car{CarId=2, CarName="Toyota", BrandId=3, ColorId=2, Description="Aile Arabası", ModelYear=2011, DailyPrice=280000 },
//                new Car{CarId=3, CarName="Hyundai", BrandId=4, ColorId=2, Description="Spor", ModelYear=2016, DailyPrice=125000 },
//                new Car{CarId=4, CarName="Renault", BrandId=5, ColorId=1, Description="Taşıma", ModelYear=2020, DailyPrice=250000 },
//                new Car{CarId=5, CarName="Mercedes", BrandId=6, ColorId=1, Description="Konfor", ModelYear=2021, DailyPrice=400000 }

//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            //LINQ - Language Integrated Query
//            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            
//            _cars.Remove(carToDelete);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetByCarId(int carId)
//        {
//            return _cars.Where(c => c.CarId == carId).ToList();
//        }
//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.CarName = car.CarName;
//            carToUpdate.CarId = car.CarId;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;
//        }
//    }
//}
