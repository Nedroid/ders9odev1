
using RecapProjectCar.Business.Concrete;
using RecapProjectCar.Business.Abstract;
using RecapProjectCar.DataAccess.Concrete;
using RecapProjectCar.Entities.Concrete;
using ConsoleApp1.DataAccess.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
Car car1 = new Car() { Id = 7, BrandId = 3, ColorId = 2, DailyPrice = 200, Description = "Porshe911", ModelYear = 2022 };
//((ICarService)carManager).Add(car1);
foreach (var car in ((ICarService)carManager).GetCarDetails())
{
    Console.WriteLine("ID=" + car.Id
        + "Color Name=" + car.ColorName +
        "Brand Name=" + car.BrandName +
        "Model Year=" + car.ModelYear +
        "Car Description=" + car.Description +
        "Car Daily Price=" + car.DailyPrice +
        "\n------------------------------\n");
}
Console.WriteLine("Get By ıd ");

Console.WriteLine("ID=" + ((ICarService)carManager).GetById(4).Id
        + "Color ID=" + ((ICarService)carManager).GetById(4).ColorId +
        "Brand Id=" + ((ICarService)carManager).GetById(4).BrandId +
        "Model Year=" + ((ICarService)carManager).GetById(4).ModelYear +
        "Car Description=" + ((ICarService)carManager).GetById(4).Description +
        "\n------------------------------\n");
Console.ReadLine();
