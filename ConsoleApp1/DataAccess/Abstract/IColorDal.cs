using Core.DataAccess;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
    }
}
