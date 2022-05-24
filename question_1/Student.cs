namespace question_1
{
    public class Students : DataCollection // inherits from datacollection class, no over rides or additional functionality needed 
    {
        public Students(string name, string[] groups, bool isLecturer, bool isStudent) : base(name, groups, isLecturer,
            isStudent)
        {
        }

        public Students(string name, string group, bool isLecturer, bool isStudent) : base(name, group, isLecturer,
            isStudent)
        {
        }
    }
}