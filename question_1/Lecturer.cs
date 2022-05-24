namespace question_1
{
    public class Lecturer : DataCollection // inherits from datacollection class, no over rides or additional functionality needed 
    {
        public Lecturer(string name, string[] groups, bool isLecturer, bool isStudent) : base(name, groups, isLecturer,
            isStudent)
        {
        }

        public Lecturer(string name, string group, bool isLecturer, bool isStudent) : base(name, group, isLecturer,
            isStudent)
        {
        }
    }
}