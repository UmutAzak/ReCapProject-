using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(int id);
        List<Car> GetAllCars();
        List<Car> GetSameBrands(int bradnId);
        void AddCarToSystem(Car car);
        void UpdateCarInSystem(Car car);
        void DeleteCarFromSystem(Car car);

    }
}
