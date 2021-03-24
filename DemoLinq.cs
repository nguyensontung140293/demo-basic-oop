using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Demo
{
    public class Bike 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfManufacture { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Id, Name, YearOfManufacture);
        }

        public static IList<Bike> Bikes 
        { 
            get 
            {
                return new List<Bike>
                {
                    new Bike { Id = 1, Name = "Honda", YearOfManufacture = 1990 },
                    new Bike { Id = 2, Name = "Toyota", YearOfManufacture = 1880 },
                    new Bike { Id = 3, Name = "Mazda", YearOfManufacture = 1925 },
                    new Bike { Id = 4, Name = "VinFast", YearOfManufacture = 2017 },
                    new Bike { Id = 5, Name = "KIA", YearOfManufacture = 1855 },
                    new Bike { Id = 6, Name = "BMW", YearOfManufacture = 1946 },
                    new Bike { Id = 7, Name = "Merc", YearOfManufacture = 1981 },
                    new Bike { Id = 8, Name = "Abc", YearOfManufacture = 1920 },
                    new Bike { Id = 9, Name = "Def", YearOfManufacture = 1940 },
                    new Bike { Id = 10, Name = "Gij", YearOfManufacture = 1944 }
                };
            } 
        }

    }

    class DemoLinq
    {
        public void Main()
        {
            var bikes = Bike.Bikes;

            var list = bikes.Where(f => f.YearOfManufacture >= 1990);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            /*
             *  Output:
             *  
             *  1 - Honda - 1990
             *  4 - VinFast - 2017
             */
            Console.ReadKey();
        }

    }
}
