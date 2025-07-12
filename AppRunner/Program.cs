using Assignment2_OOP;
using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
    static void Main(string[] args)
    {
        #region
        //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array.

        Person[] people = new Person[3];
        people[0] = new Person("Hazem", 25);
        people[1] = new Person("mahmoud", 30);
        people[2] = new Person("Ali", 22);

        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
        #endregion
    }
}
