
using System;

class program
{
    static void Main(string[] args)
    {

        Person[] people = new Person[3];

        // تعبئة بيانات الأشخاص
        people[0] = new Person("Hazem", 25);
        people[1] = new Person("Sara", 30);
        people[2] = new Person("Ali", 22);

        // طباعة تفاصيل كل شخص
        Console.WriteLine("People Details:");
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
