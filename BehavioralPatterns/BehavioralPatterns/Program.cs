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

            Console.ReadLine();
        }
    }
}
