using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car()
                {
                    Id = 1, BrandId=1, ColorId=1, Price= 120.000, ModelYear= 2013 ,ModelName="BMW" 
                },
                new Car()
                {
                    Id = 2, BrandId=1, ColorId=1, Price= 150.000, ModelYear= 2016 ,ModelName="BMW"
                },
                new Car()
                {
                    Id = 3, BrandId=2, ColorId=1, Price= 110.000, ModelYear= 2015 ,ModelName="AUDİ"
                },
                 new Car()
                {
                    Id = 4, BrandId=2, ColorId=2, Price= 220.000, ModelYear= 2019 ,ModelName="AUDİ"
                },
                  new Car()
                {
                    Id = 5, BrandId=3, ColorId=2, Price= 250.000, ModelYear= 2019 ,ModelName="MERCEDES"
                },
                   new Car()
                {
                    Id = 6, BrandId=3, ColorId=2, Price= 260.000, ModelYear= 2019 ,ModelName="SEAT"
                },
            };
        }
        public List<Car> GetAll() =>_cars;
        public Car GetById(int id) => _cars.SingleOrDefault(p => p.Id == id);
        public List<Car> GetByBrandId(int brandId) => _cars.Where(p => p.BrandId == brandId).ToList();

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Price = car.Price;
            carToUpdate.ModelYear = car.ModelYear;

        }

    }
}
