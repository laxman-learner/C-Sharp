using System;

class FunctionDetails
{

    // returning multiple value from a function

    // example, method to find min and max from set of numbers 

    internal (int, int) FindMinMax(int[]
    numbers)  // we call this function outside the class i.e. inside another classs
    {
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;

        }

        return (min, max);
    }


    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name: {name} [{age}], Address: {address}");
    }

}
class MainClass
{
    static void Main6()
    {
        FunctionDetails fd = new FunctionDetails();
        int[] numbers = { 34, 58, 933, 9, 283, 84, 29, 282, 902 };
        (int, int) results = fd.FindMinMax(numbers);
        Console.WriteLine($"Minimum is {results.Item1}, Maximum is {results.Item2}");

        // above last two lines can be made readable as follows
        // (int Min, int Max) results = fd.FindMinMax(numbers);
        // Console.WriteLine($"Minimum is {results.Min}, Maximum is {results.Max}");

        // normally calling the function
        //fd.PrintCustomerDetails("Laxman",30, "Kathmandu");
        // using named parameters

        fd.PrintCustomerDetails(age: 30, address: "Kathmandu", name: "Laxman");
    }
}
