using System;

class Student
{

    private int marks;

    public void SetMarks(int m)
    {
        if (m >= 0 && m <= 100)
            marks = m;
        else
            Console.WriteLine("Invalid marks");
    }


    public int GetMarks()
    {
        return marks;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.SetMarks(85);
        Console.WriteLine("Marks: " + s.GetMarks());
    }
}