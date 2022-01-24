// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;

namespace Stage1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello, World!");
            var school= new School("Academy",2021,SchoolTypes.kinderGarden,country:"Canadá",city:"Barranquilla");
            // school.Name="Academy";
            // school.Country="Colombia";
            // school.City="Barranquilla";
            school.SchoolType=SchoolTypes.Primary;
            Console.WriteLine(school);

        }
    }
}

