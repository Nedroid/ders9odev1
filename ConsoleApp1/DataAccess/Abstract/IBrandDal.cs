﻿using Core.DataAccess;
using RecapProjectCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}
