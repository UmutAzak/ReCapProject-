using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class CarManager :ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car GetById(int id) => _carDal.GetById(id);


        public List<Car> GetAllCars() => _carDal.GetAll();
      

        public List<Car> GetSameBrands(int brandId) => _carDal.GetByBrandId(brandId);
       

        public void AddCarToSystem(Car car)
        {
            _carDal.Add(car);
        }

        public void UpdateCarInSystem(Car car)
        {
            _carDal.Update(car);
        }

        public void DeleteCarFromSystem(Car car)
        {
            _carDal.Delete(car);
        }

        
    }
}
