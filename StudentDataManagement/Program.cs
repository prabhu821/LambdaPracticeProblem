namespace StudentDataManagement
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
                Console.WriteLine("\nEnter option to choose \n1.Add Students \n2.Display Students \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Management.AddStudentData(students);
                        break;
                    case 2:
                        Management.DisplayStudentData(students);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}