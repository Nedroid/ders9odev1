using RecapProjectCar.DataAccess.Abstract;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjectCar.DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> cars;
        public InMemoryDal()
        {
            cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear=2021,Description="Bmw 2021 model " },
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2022,Description="Bmw 2022 model " },
                new Car{Id=3,BrandId=1,ColorId=2,DailyPrice=250,ModelYear=2021,Description="Audi 2021 model " },
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=250,ModelYear=2023,Description="Audi 2023 model " },
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=100,ModelYear=2024,Description="Porshe 2024 model " },
                new Car{Id=6,BrandId=3,ColorId=4,DailyPrice=129,ModelYear=2023,Description="Porshe 2023 model " }
            };

        }
        public Car Add(Car car)
        {
            cars.Add(car);
            return car;
        }

        public void Delete(Car car)
        {
            Car deletecar = cars.SingleOrDefault(_car => _car.Id == car.Id);
            cars.Remove(deletecar);
        }

        public List<Car> GetAll(Expression<Func<Car,bool>> predicate)
        {
            return cars.ToList();
        }

        public Car Get(Expression<Func<Car, bool>> predicate)
        {
            var result = cars.Where(predicate.Compile()).FirstOrDefault();
            return result;
        }

        public Car Update(Car car)
        {
            Car updatedCar = cars.FirstOrDefault(c => c.Id == car.Id);
            updatedCar.Description = car.Description;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            return updatedCar;

        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            throw new NotImplementedException();
        }
    }
}
