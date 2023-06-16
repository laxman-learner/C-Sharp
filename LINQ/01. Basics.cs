using System;
using System.Linq;
namespace LINQ.Learning
{

    class Queries
    {
        static void Main()
        {
            //LINQ - Language INtegrated Query

            int[] numbers = { 12, 45, 45, 93, 38, 63, 10, 83, 89, 100 };
            // Method Syntax
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            // 'Where' and 'Select' are LINQ operators. (num => num > 50) is lambda expression

            //   displaying results

            Console.WriteLine("Numbers greather than 50");

            foreach (int x in result1)
            {
                Console.WriteLine(x);
            }

            // Query expression syntax
            //   restrictions or filter - where i.e. to select few elements of list


            var result2 = from num in numbers
                          where num > 50
                          select num;


            Console.WriteLine("");
            Console.WriteLine("Numbers greather than 50");

            foreach (int x in result2)
            {
                Console.WriteLine(x);
            }

            var result3 = from num in numbers
                          where num > 50 && num < 100
                          select num;

            Console.WriteLine("");
            Console.WriteLine("Numbers greather than 50 and less than 100");

            foreach (int x in result3)
            {
                Console.WriteLine(x);
            }

            // projection - select i.e. to select all

            var result4 = from num in numbers
                          select num * num;  // to return square of all element

            Console.WriteLine("");
            Console.WriteLine("Square of all elements");

            foreach (int x in result4)
            {
                Console.WriteLine(x);
            }

            var result = from num in numbers
                         where num % 2 == 0
                         select num;  // to return s only even element

            Console.WriteLine("");
            Console.WriteLine("Only even numbers in list");

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

            var result5 = from num in numbers
                          where num % 2 == 0
                          select num * num;  // to return square of only even element

            Console.WriteLine("");
            Console.WriteLine("Square of even numbers only");

            foreach (int x in result5)
            {
                Console.WriteLine(x);
            }


            // ordering - orderby, orderby descending

            var result6 = from num in numbers
                          orderby num
                          select num;  // ascending order

            Console.WriteLine("");
            Console.WriteLine("Numbers in ascending order");

            foreach (int x in result6)
            {
                Console.WriteLine(x);
            }

            var result7 = from num in numbers
                          orderby num descending
                          select num;  // descending order

            Console.WriteLine("");
            Console.WriteLine("Numbers in descending order");

            foreach (int x in result7)
            {
                Console.WriteLine(x);
            }

            // partitioning : take, skip

            var result8 = numbers.Take(5); // first 5 elements

            Console.WriteLine("");
            Console.WriteLine("First Five elements : ");
            foreach (int x in result8)
            {
                Console.WriteLine(x);
            }

            var result9 = numbers.Skip(5).Take(5);
            // skip first 5 elements and take next 5 elements

            Console.WriteLine("");
            Console.WriteLine("Elements after first 5 elements : ");
            foreach (int x in result9)
            {
                Console.WriteLine(x);
            }

            // Quantifiers: any, all, contains

            var result10 = numbers.Any(num => num % 2 == 0);   // boolean return type
            // returns true if at least one element is even.
            Console.WriteLine("");
            Console.WriteLine("Is there any even element in list ? ");
            var confirm = (result10 == true) ? "Yes..." : "No...";
            Console.WriteLine(confirm);


            var result11 = numbers.All(num => num % 2 == 0);
            // returns true if all the elements of the list are even
            Console.WriteLine("");
            Console.WriteLine("Does list contain only evens ? ");
            var check = (result11 == true) ? "Yes..." : "No...";
            Console.WriteLine(check);

            var result12 = numbers.Contains(100);
            // returns true if 100 exists in list
            Console.WriteLine("");
            Console.WriteLine("Does list contain 100 ? ");
            var valid = (result12 == true) ? "Yes..." : "No...";
            Console.WriteLine(valid);

            // These all sorts of queries work for all types of other collections


            //    Generations
            var result13 = Enumerable.Range(1, 10);
            // generates numbers sequentially from 1 to 10

            Console.WriteLine("");

            foreach (var num in result13)
            {
                Console.WriteLine(num);
            }

            var result14 = Enumerable.Repeat("Hello World", 5);
            // repeats "Hello World" five times


            Console.WriteLine("");

            foreach (var str in result14)
            {
                Console.WriteLine(str);
            }

            //  Note: IEnumerable is base interface









        }
    }
}