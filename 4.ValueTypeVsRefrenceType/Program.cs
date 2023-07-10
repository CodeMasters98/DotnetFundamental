using System;

namespace DotnetFundamental
{

    class Student
    {
        public string StudentName { get; set; }
    }
    class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Parham";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("************* Start of Value Type *************");
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);
            Console.WriteLine("************* End of Value Type *************");

            

            Console.WriteLine("************* Start of Reference Type *************");
            Student std1 = new Student();
            std1.StudentName = "Parsa";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
            Console.WriteLine("************* End of Reference Type *************");

            Console.ReadLine();
        }
    }


}