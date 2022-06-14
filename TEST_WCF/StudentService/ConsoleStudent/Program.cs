using ConsoleStudent.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent
{
    internal class Program
    {
        static void Main(string[] objects)
        {

            StudentServiceClient client = new StudentServiceClient();

            Console.WriteLine("The student list : ");

            foreach(var obj in client.GetAllStudent())
            {
                Console.WriteLine("Student: " + obj.StudentID);
                Console.WriteLine(obj.LastName);
                Console.WriteLine(obj.FirstName);
                Console.WriteLine(obj.PhoneNumber);
                Console.WriteLine(obj.Email);

            }
        }
    }
}
