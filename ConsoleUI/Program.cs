using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Araçlar-->");
            Console.WriteLine("-------------");

            var cars = carManager.GetAllCars();
            foreach (var car in cars)
            {
                Console.WriteLine("Model Adı: " +" "+ car.ModelName );
                Console.WriteLine("Model Yıllı: " + car.ModelYear);
                Console.WriteLine("Fiyatı: " + car.Price);
                Console.WriteLine("-------------");
                
            }
            
            
            

            var car1 = new Car
            {
                Id = 6,
                BrandId = 3,
                ColorId = 4,
                Price = 118.750,
                ModelYear = 2013,

            };
            var car2 = new Car
            {
                Id = 3,
                BrandId = 3,
                ColorId = 1,
                Price = 140.000,
                ModelYear = 2016,

            };

            carManager.AddCarToSystem(car1);
            carManager.UpdateCarInSystem(car2);
            carManager.DeleteCarFromSystem(new Car { Id = 1 });

            
        }
    }
}
