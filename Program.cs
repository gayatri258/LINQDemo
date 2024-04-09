// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Xml.Linq;

internal class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public int age { get; set; }
}
class Example
{
    public static void Main(string[] args)
    {

        Student[] studentArray = {
                 new Student() { StudentId = 1, Name = "Aniket", age = 23 },
                 new Student() { StudentId = 3 , Name = "Shubham", age = 22 },
                 new Student() {StudentId = 8 ,Name = "Dhanashri", age = 18},
                 new Student() {StudentId = 2 ,Name = "Gayatri", age = 25},
                 new Student() {StudentId = 6 ,Name = "Vedant", age = 17},
                 new Student() {StudentId = 7 ,Name = "Viraj" , age=15},
            };



        //use linq for find studets who are under age using Query Syntax.
        var UnderAge = from student in studentArray
                       where student.age < 18
                       select student;

        Console.WriteLine("Students who are Under age is :");
        foreach (var student in UnderAge)
        {
            Console.WriteLine(student.StudentId + " " + student.Name + " " + student.age);
        }

        Console.WriteLine("------------------------------------------");
        //use linq for find studets who are under age using Lambda Expression.

        var UnderAge1 = studentArray.Where(s => s.age < 18);
        Console.WriteLine("Students who are Under age is :");
        foreach (var student in UnderAge1)
        {
            Console.WriteLine(student.StudentId + " " + student.Name + " " + student.age);
        }

        Console.WriteLine("-------------------------------------------");
        //OrderBy Operator using Query Syntax.
        int[] Numbers = new int[] { 12, 67, 90, 45, 43, 25, 17, 6, 8 };

        var n = from num in Numbers
                orderby num ascending
                select num;

        Console.WriteLine("Numbers in ascending order by order by operator using Query");
        foreach (var item in n)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------------------------------------------------");

        //OrderBy in method syntax.
        int[] Numbers1 = new int[] { 12, 67, 90, 45, 43, 25, 17, 6, 8 };

        var n1 = Numbers1.OrderByDescending(num => num);
        Console.WriteLine("Numbers in descending order by order by operator using method");
        foreach (var item in n)
        {
            Console.WriteLine(item);
        }

        //ElementAt Method.
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("ElementAt method");
        IList<int> list = new List<int> { 12, 67, 45, 17, 25, 23, 6, 8, 11, 55, 33, 12, 90, 65 };
        Console.WriteLine("Element First : {0} ", list.ElementAt(0));

        Console.WriteLine("Element 20th  : {0} ", list.ElementAtOrDefault(20));
        //if specified index is not present then default value 0 will be display.

    }

}