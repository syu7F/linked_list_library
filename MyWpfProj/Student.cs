using System;

namespace SetDemo
{
    public class Student : IComparable<Student>
    {
        public Student(int id, string name, Gender gender)
        {
            studenId = id;
            name = name;
            Gender = gender;
        }

        public int studenId { get; private set; }

        public string name { get; private set; }

        public Gender Gender { get; private set; }

        public int CompareTo(Student other)
        {
            return studenId.CompareTo(other.studenId);
        }
    }
}