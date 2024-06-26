using Core.DataAccess.EntityFramework;
using RecapProjectCar.DataAccess.Abstract;
using RecapProjectCar.DataAccess.Concrete;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDto()
        {
            using (RecapCarContext context = new RecapCarContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear


                             };
                return result.ToList();
            }
        }
    }
}
