using System.Collections.Generic;

namespace question_1
{
    public class DataCollection
    {
        //instance variables 
        private readonly List<string> _groups; // list of groups the person is part of
        private readonly bool _isLecturer;     //boolean to say whether the person is a lecturer
        private readonly bool _isStudent;      //boolean to say whether the person is a student

        //constructor to accept the name of the person, an array of groups they are part of and whether the student or not
        public DataCollection(string name, string[] groups, bool isLecturer, bool isStudent)
        {
            _isStudent = _isStudent;
            _isLecturer = _isLecturer;
            _groups = new List<string>();
            Name = name;
            _groups.AddRange(groups);
        }
        //constructor to accept the name of the person, a single string of a group they are part of and whether the student or not
        public DataCollection(string name, string group, bool isLecturer, bool isStudent)
        {
            _isStudent = _isStudent;
            _isLecturer = _isLecturer;
            _groups = new List<string>();
            Name = name;
            _groups.Add(group);
        }

        //getter used to get the name
        public string Name { get; set; }

        //returns all the groups in the group list
        public string GetGroups()
        {
            return string.Join(", ", _groups);
        }

        //adds a group name to the group list
        //functionality as per assignment requirements
        public void SetGroups(string group)
        {
            _groups.Add(group);
        }

        //adds an array of groups to the groups list
        //functionality as per assignment requirements
        public void SetGroups(string[] groups)
        {
            _groups.AddRange(groups);
        }
        
        //deletes a group from the group list
        //functionality as per assignment requirements
        public void DeleteGroup(string groupName)
        {
            _groups.Remove(groupName);
        }

        //functionality to edit a specific group
        //functionality as per assignment requirements
        public void EditGroup(string oldName, string newName)
        {
            var index = _groups.IndexOf(oldName);
            _groups.RemoveAt(index);
            _groups.Add(newName);
        }

        //goes through the list of groups and checks whether the argument group name is in the list of groups for the object
        public bool CheckGroup(string groupName)
        {
            foreach (var group in _groups)
            {
                if (groupName == group)
                {
                    return true;
                }
            }
            return false;
        }
    }
}