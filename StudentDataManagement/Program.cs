﻿namespace StudentDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Data Management!");
            List<Student> students = new List<Student>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.Add Students \n2.Display Students \n3.Retrieve age btw 12 and 18 " +
                    "\n4.Sort Age by descending order \n5.Retrieve By Address \n6.First 3 students \n7.Search Student by name \n8.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Management.AddStudentData(students);
                        break;
                    case 2:
                        Management.DisplayStudentData(students);
                        break;
                    case 3:
                        Management.RetrieveAgeBtwRange(students);
                        break;
                    case 4:
                        Management.SortByDescOrder(students);
                        break;
                    case 5:
                        Management.RetrievingByAddress(students);
                        break;
                    case 6:
                        Management.FirstThreeStudents(students);
                        break;
                    case 7:
                        Management.SearchForParticularName(students);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}