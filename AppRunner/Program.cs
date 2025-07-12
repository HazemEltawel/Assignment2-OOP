using Assignment2_OOP;
using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
    static void Main(string[] args)
    {

        #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array.

        //Person[] people = new Person[3];
        //people[0] = new Person("Hazem", 25);
        //people[1] = new Person("mahmoud", 30);
        //people[2] = new Person("Ali", 22);

        //foreach (Person person in people)
        //{
        //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        //}
        #endregion

        #region Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

        //Console.Write("Enter X for Point 1: ");
        //double x1 = double.Parse(Console.ReadLine());
        //Console.Write("Enter Y for Point 1: ");
        //double y1 = double.Parse(Console.ReadLine());
        //Console.Write("Enter X for Point 2: ");
        //double x2 = double.Parse(Console.ReadLine());
        //Console.Write("Enter Y for Point 2: ");
        //double y2 = double.Parse(Console.ReadLine());
        //Point p1 = new Point(x1, y1);
        //Point p2 = new Point(x2, y2);
        //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        //Console.WriteLine($"\nDistance between the two points is: {distance}");

        #endregion

        #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        Person[] people = new Person[3];

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            people[i] = new Person(name, age);
        }

        Person oldest = people[0];
        for (int i = 1; i < people.Length; i++)
        {
            if (people[i].Age > oldest.Age)
            {
                oldest = people[i];
            }
        }

        Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");
    }

    #endregion










}
