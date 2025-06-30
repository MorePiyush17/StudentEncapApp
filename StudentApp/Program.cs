using StudentEncapApp;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.WriteLine("Student Details:\n");

            Console.Write("Enter Roll Number: ");
            student1.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name (min 5 chars): ");
            student1.Name = Console.ReadLine();

            Console.Write("Enter CGPA (1 to 10): ");
            student1.Cgpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(student1.ToString());
        }
    }
}
