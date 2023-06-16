class IterationStatement
{
    void LearnForLoop()
    {

        // for loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("I am inside for loop");
        }

        // foreach loop

        int[] numbers = { 45, 98, 84, 23, 759, 34 };

        foreach (int x in numbers)
        {
            if (x % 2 == 0)
                Console.WriteLine($"{x} is even");  // string interpolation
            else
                Console.WriteLine($"{x} is odd");

        }
    }

    //while loop

    void LearnWhileLoop()
    {
        char confirm = 'y';     // declaration is done outside while loop
        while (confirm == 'y')
        {
            Console.WriteLine();
            Console.WriteLine("Inside while loop");
            Console.WriteLine("Want one more ? ");
            confirm = Console.ReadKey().KeyChar;
        }
    }

    // do while loop
    void LearnDoWhileLoop()
    {
        char confirm = 'y';     // declaration is done outside while loop
        do
        {
            Console.WriteLine();
            Console.WriteLine("Inside do while loop");
            Console.WriteLine("Want one more do while ? ");
            confirm = Console.ReadKey().KeyChar;
        } while (confirm == 'y');
    }


    static void Main4(string[] args)
    {
        IterationStatement iteration = new IterationStatement();
        iteration.LearnForLoop();
        iteration.LearnWhileLoop();
        iteration.LearnDoWhileLoop();

        // 'is' is a keyword in c#
    }
}