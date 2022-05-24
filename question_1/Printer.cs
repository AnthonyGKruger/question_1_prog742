using System;
using System.Collections.Generic;
using System.Linq;

namespace question_1
{
    public class Printer
    {
        private Students[] _students;           //array of students   
        private Lecturer[] _lecturers;          //array of lecturers
        private readonly string _seperator;     //constant which will be used as the separator 
        private string[] _groups;               //array of groups available

        //constructor, initializes class variables by accepting an array of students and lecturers
        public Printer(Lecturer[] lecturer, Students[] students)
        {
            _groups = new[] { "Java Programming", "Python", "Advanced Data Structures" };
            _seperator = "----------------------------------------------------------------------------";
            _lecturers = lecturer;
            _students = students;
        }

        //creates a list of lecturer names and uses the string.join method to output a string with comma seperated names
        public void PrintLectures()
        {
            List <string> names = new List<string>();
            foreach (Lecturer lecturer in _lecturers)
            {
                names.Add(lecturer.Name);
            }
            Console.WriteLine("Lecturers: " + string.Join(",", names));
        }

        //goes through the array of lecturer objects and calls the name property to get the name 
        public void PrintIndividualLecturers()
        {
            foreach (Lecturer lecturer in _lecturers)
            {
                Console.WriteLine(_seperator);
                Console.WriteLine("Lecturer name: " + lecturer.Name);
                
                //lecturer.getGroups goes through the list of groups the lecturer is part of and then prints it
                Console.WriteLine("Groups of this lecturer: " + lecturer.GetGroups()); 
            }
        }
        
        //creates a list of student names and uses the string.join method to output a string with comma seperated names
        public void PrintStudents()
        {
            List <string> names = new List<string>();
            foreach (Students student in _students)
            {
                names.Add(student.Name);
            }
            
            Console.WriteLine("Students: " + string.Join(",", names));
        }

        //Prints the groups 
        public void PrintGroups()
        {
            Console.WriteLine("Groups: Java Programming, Advanced Data Structures, Python");
        }

        //prints each group individually with the lecturer of the group and the students of the group
        public void PrintIndividualGroups()
        {
            //using a ranged loop because we have 3 groups
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(_seperator);
                Console.WriteLine("Group name: " + _groups[i]);
                Console.Write("Students in the group: ");
               
                int count = 0; // variable to assist in monitoring how many student names have been printed
                
                foreach (Students student in _students) // going through each student in the students array
                {
                    if (student.CheckGroup(_groups[i])) // using student obj method to check if the student is in group
                    {
                        if (count == 0) // this if statement is assisting with
                                        // monitoring whether we need to print a comma before the student name
                        {
                            Console.Write(student.Name);
                            ++count;
                        }
                        else
                        {
                            Console.Write(", " + student.Name);
                        }
                    }
                }

                // Similar process for lecturers but only one lecturer name to be printed.
                Console.Write("\nGroup Lecturer: ");
                
                foreach (Lecturer lecturer in _lecturers)
                {
                    if (lecturer.CheckGroup(_groups[i]))
                    {
                        Console.Write(lecturer.Name);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}