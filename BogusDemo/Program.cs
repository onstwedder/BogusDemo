using Bogus;
using System;

namespace BogusDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var residents = new Faker<Resident>("nl")
                            .UseSeed(300)
                            .StrictMode(false)
                            .Rules((f, o) =>
                            {
                                o.Id = f.Random.Replace("###-###-###-###");
                                o.Name = f.Name.FullName();
                                o.Street = f.Address.StreetName();
                                o.Housenumber = f.Address.BuildingNumber();
                                o.City = f.Address.City();
                            });

            var residentList = residents.Generate(10);

            foreach (var res in residentList)
            {
                res.Print();
            }

            Console.ReadLine();
        }


    }

}
