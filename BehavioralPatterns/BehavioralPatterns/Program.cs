using System;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();
            var univer = new University();

            Console.WriteLine("SCHOOL");
            school.EducationProcess();

            Console.WriteLine("UNIVERSITY");
            univer.EducationProcess();

            Console.WriteLine();

            var listScool = new SchoolList();
            listScool.AddItem(new School() { Number = 51 });
            listScool.AddItem(new School() { Number = 13 });
            listScool.AddItem(new School() { Number = 8 });

            foreach (var item in listScool)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var listUniversities = new UniversityList();
            listUniversities.AddItem(new University() { Name = "BSU" });
            listUniversities.AddItem(new University() { Name = "BNTU" });

            foreach (var item in listUniversities)
            {
                Console.WriteLine(item);
            }    

            Console.ReadLine();
        }
    }
}
