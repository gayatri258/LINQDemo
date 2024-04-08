// See https://aka.ms/new-console-template for more information

using System.Globalization;

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
            Console.WriteLine(student.StudentId + " " + student.Name + " " +student.age);
        }

        Console.WriteLine("------------------------------------------");
        //use linq for find studets who are under age using Lambda Expression.

        var UnderAge1 = studentArray.Where(s => s.age <18);
        Console.WriteLine("Students who are Under age is :");
        foreach (var student in UnderAge1)
        {
            Console.WriteLine(student.StudentId + " " + student.Name + " " + student.age);
        }

        Console.WriteLine("-------------------------------------------");
        //OrderBy Operator using Query Syntax.
        int[] Numbers= new int[] { 12, 67, 90, 45, 43, 25, 17, 6, 8 };

        var n = from num in Numbers
                orderby num descending
                select num;

        Console.WriteLine("Numbers in descending order by order by operator");
        foreach(var item in n)
        {
            Console.WriteLine(item);
        }

        

    }
}