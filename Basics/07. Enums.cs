using System;

// enums are used to avoid hard coding which makes the code more readable and maintable
enum DayOfWeek
{
    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
}

internal class Demo
{
    public DayOfWeek day { get; set; }
    void PrintGreeting()
    {
        if (day == DayOfWeek.Sunday)
        {
            Console.WriteLine("Greeting, Happay Sunday");
        }
        if (day == DayOfWeek.Saturday)
        {
            Console.WriteLine("Greeting, Happay Holiday");
            Console.WriteLine("Congrats, You have safe the day");

        }
    }
}