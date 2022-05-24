using System;

namespace question_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            //Initializing and creating student objects
            var mzotho = new Students("Mzotho Andile", new[] { "Java Programming" },
                false, true);
            var tambo = new Students("Tambo David", new[] { "Java Programming" , "Advanced Data Structures" },
                false, true);
            var ngcobo = new Students("Ngcobo Mandy", new[] { "Java Programming" , "Python", 
                    "Advanced Data Structures" },
                false, true);
            var khumalo = new Students("Khumalo Itumeleng", new[] { "Java Programming" },
                false, true);
            
            //Initializing and creating lecturer objects
            var raymondShamba = new Lecturer("Raymond Shamba", new []{"Advanced Data Structures",
                    "Java Programming"}, 
                true, false);
            var prominentMugariri = new Lecturer("Prominent Mugariri", new []{"Python"}, 
                true, false);
            
            //printing the title
            Console.WriteLine("     School Name: Richfield Graduate Institute of Technology\n");

            //Initializing printer object, accepts an array of students and an array of lecturers
            Printer printer = new Printer(new[] { raymondShamba, prominentMugariri }, new[]
            {
                mzotho,
                ngcobo,
                khumalo,
                tambo
            });
            
            //calling on printer object to print relevant information
            printer.PrintLectures();
            printer.PrintStudents();
            printer.PrintGroups();
            printer.PrintIndividualLecturers();
            printer.PrintIndividualGroups();
        }
    }
}