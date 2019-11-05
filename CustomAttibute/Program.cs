using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttibute
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();

            Console.WriteLine();
            Example2();
            Console.ReadKey();
        }

        private static void Example1()
        {
            Student s = new Student();
            s.setDetails(1, "Taylor", 92.5);

            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.getRollNo());
            Console.WriteLine("Name : " + s.getStuName());
            Console.WriteLine("Marks : " + s.getMarks());
        }

        private static void Example2()
        {

            // Calling the AttributeDisplay 
            // method using the class name 
            // since it is a static method 
            NewAttribute.AttributeDisplay(typeof(Employer));

            Console.WriteLine();

            NewAttribute.AttributeDisplay(typeof(Employee));

            Console.WriteLine();

            NewAttribute.AttributeDisplay(typeof(Student));
        }
    }
}
