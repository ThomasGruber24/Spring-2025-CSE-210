using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade? ");
        string stGrade = Console.ReadLine();
        int grade = int.Parse(stGrade);

        if (grade > 90)
        {
            Console.WriteLine("A, you passed your class!");
        }
        else if (grade > 80)
        {
            Console.WriteLine("B, you passed your class!");
        }
        else if (grade > 70)
        {
            Console.WriteLine("C, you passed your class!");
        }
        else if (grade > 60)
        {
            Console.WriteLine("D, you did not pass this class.");
        }
        else
        {
            Console.WriteLine("F, you failed this class.");
        }
    }
}