using System;
class SelectionStatement
{

    void LearnIfElse()
    {
        Console.Write("Enter any byte (0-255) number : ");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);

        if (x == 34)
        {
            Console.WriteLine("I am inside statement");
        }
        else if (x == 20)
        {
            Console.WriteLine("You entered 20");
        }
        else
        {
            Console.WriteLine("You didn't enter what we expect");
        }
    }

    // switch statement

    void LearnSwitch()
    {
        Console.Write("Enter any character: ");
        string x = Console.ReadLine();
        char option = char.Parse(x);

        switch (option)
        {
            case 'n':
            case 'x':
                Console.WriteLine("You opted for No");
                break;

            case 'y':
            case 'z':
                Console.WriteLine("You opted for Yes");
                break;

            default:
                Console.WriteLine("No match found");
                break;
        }
    }
    static void Main3()
    {
        SelectionStatement ss = new SelectionStatement();
        ss.LearnIfElse();
        ss.LearnSwitch();
    }


}