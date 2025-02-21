﻿using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjectCar.Business.Abstract
{
    public interface ICarService
    {
          List<Car> GetAll();
         void Add(Car car);
        Car Update(Car car);
        void Delete(Car car);
        Car GetById(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
