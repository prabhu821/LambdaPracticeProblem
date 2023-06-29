using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataManagement
{
    internal class Management
    {
        public static void Display(Student student)
        {
            Console.WriteLine($"Student whose ID is: {student.Id} ,Name: {student.Name} " +
                $",PhoneNumber: {student.PhoneNumber} ,Address: {student.Address} ,Age: {student.Age}");
        }
        public static void AddStudentData(List<Student> studentList)
        {
            studentList.Add(new Student(1, "Ram", "9999900000", "Delhi", 25));
            studentList.Add(new Student(2, "Rohit", "9638527410", "Mangalore", 15));
            studentList.Add(new Student(3, "Ajay", "8527419630", "Kanpur", 11));
            studentList.Add(new Student(4, "Sam", "8525643212", "Delhi", 12));
            studentList.Add(new Student(5, "Rahul", "8000000000", "Shimla", 18));
            studentList.Add(new Student(6, "Rae", "8574195218", "Lucknow", 15));
            studentList.Add(new Student(7, "Jack", "8741741741", "Kochi", 20));
            Console.WriteLine("Records Added");
        }
        public static void DisplayStudentData(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                Display(student);
            }
        }

        public static void RetrieveAgeBtwRange(List<Student> studentList)
        {
            foreach (Student student in studentList.FindAll(x => x.Age >= 12 && x.Age <= 18))
            {
                Console.WriteLine($"Student with ID is: {student.Id} ,Name: {student.Name} ,PhoneNumber: {student.PhoneNumber} ,Address: {student.Address} ,Age: {student.Age}");
            }
        }

        public static void SortByDescOrder(List<Student> studentList)
        {
            foreach (Student student in studentList.OrderByDescending(x => x.Age))
            {
                Display(student);
            }
        }

        public static void RetrievingByAddress(List<Student> studentList)
        {
            var studentsByAddress = studentList.GroupBy(student => student.Address);
            foreach (var group in studentsByAddress)
            {
                Console.WriteLine($"Address: {group.Key}");
                foreach (Student student in group)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Age: {student.Age}");
                }
                Console.WriteLine();
            }
        }

        public static void FirstThreeStudents(List<Student> studentList)
        {
            foreach (Student student in studentList.Take(3).ToList())
            {
                Display(student);
            }
        }
    }
}
