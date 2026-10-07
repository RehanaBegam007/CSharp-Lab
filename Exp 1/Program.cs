using System;

class Student
{
    public string name = "";
    public int rollNumber;
    public string department = "";
    public int semester;
    public int age;
    public double cgpa;

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("CGPA: " + cgpa);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.name = "Rehana Begam";
        student1.rollNumber = 101;
        student1.department = "Information Technology";
        student1.semester = 5;
        student1.age = 19;
        student1.cgpa = 8.5;

        student1.Display();
    }
}
