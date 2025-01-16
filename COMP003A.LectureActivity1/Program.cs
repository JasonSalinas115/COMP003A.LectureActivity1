/*
    Author: Jason Salinas
    Course: COMP-003A
    Faculty: Jonathan Cruz
    Purpose: Basic Console app
 */
// namespace level
namespace COMP003A.LectureActivity1
{
    // class level
    internal class Program
    {
        // main level
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hi \nMy name is Jason Salinas,");

            Console.WriteLine("Enter your name: ");
            string username = Console.ReadLine();

            Console.WriteLine("Hi " + username + ", My name is PC.");
        }
    }
}