using RecapProjectCar.Business.Abstract;
using RecapProjectCar.DataAccess.Abstract;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjectCar.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        public CarManager(ICarDal icardal)
        {
            _icarDal = icardal;
        }
        public void Add(Car car)
        {
            _icarDal.Add(car);
            Console.WriteLine(" Added Car | Id :  " + car.Id);
        }

        public void Delete(Car car)
        { 
            _icarDal.Delete(car);
            Console.WriteLine("deleted car ="+ car.Id);
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _icarDal.Get(c=>c.Id==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _icarDal.GetCarDetailDto();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _icarDal.GetAll(c => c.BrandId == brandId);  
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _icarDal.GetAll(c => c.ColorId == colorId);
        }

  

        public Car Update(Car car)
        {
            car = _icarDal.Update(car);
            Console.WriteLine("updated car " + car.Id);
            return car;
        }
    }
}
