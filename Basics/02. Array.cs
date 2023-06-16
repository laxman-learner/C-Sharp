using System;
class Array
{
    void Learn1DArray()
    {

        // variable name or array name must be unique
        int[] ages1 = new int[10];
        double[] ages2 = new double[10];

        ages1[0] = 94;
        ages1[5] = 40;

        // printing the integer array

        Console.WriteLine("Printing the 1D-Integer array");
        Console.Write("[ " + ages1[0] + " ");
        Console.WriteLine(ages1[5] + " ]");

        float[] numbers = new float[] { 23.4f, 45.6f, 12.34f };
        // float[] numbers1 = {23.4f, 45.6f, 12.34f}; => another way of initialization

        // printing the float array

        Console.WriteLine("Printing the 1D-float array");
        Console.Write("[ " + numbers[0] + " ");
        Console.Write(numbers[1] + " ");
        Console.WriteLine(+numbers[2] + " ]");
    }

    void LearnMultiDArray()
    {

        // 2D array or matrix
        int[,] ageMatrix = new int[3, 3];
        ageMatrix[0, 0] = 56;
        ageMatrix[0, 1] = 98;
        ageMatrix[0, 2] = 45;
        ageMatrix[1, 0] = 90;
        ageMatrix[1, 1] = 23;
        ageMatrix[1, 2] = 78;
        ageMatrix[2, 0] = 19;
        ageMatrix[2, 1] = 89;
        ageMatrix[2, 2] = 43;

        // printing the 2D-Integer array

        Console.WriteLine("Printing the 2D-Integer array");
        Console.Write("[ " + ageMatrix[0, 0]);
        Console.Write(" " + ageMatrix[0, 1]);
        Console.WriteLine(" " + ageMatrix[0, 2] + " ]");

        Console.Write("[ " + ageMatrix[1, 0]);
        Console.Write(" " + ageMatrix[1, 1]);
        Console.WriteLine(" " + ageMatrix[1, 2] + " ]");

        Console.Write("[ " + ageMatrix[2, 0]);
        Console.Write(" " + ageMatrix[2, 1]);
        Console.WriteLine(" " + ageMatrix[2, 2] + " ]");

        // 3D array

        int[,,] ageMatrix3D = new int[10, 15, 5];

        // this means 10 items each item being 2D array of size 15*5

        ageMatrix3D[0, 0, 0] = 98;

        //printing 3D-Integer Array

        Console.WriteLine("Printing the 3D-Integer array");
        Console.WriteLine(" [" + ageMatrix3D[0, 0, 0] + " ]");


        string[,] names = new string[,]
                    {{"Bijaya","Rawal"},{"Narayan", "Wagle"},{"Smile", "Das"}};

        // displaying 2D-String Array
        Console.WriteLine("Printing the 2D-String array");
        Console.Write(names[0, 0] + " ");
        Console.WriteLine(names[0, 1]);
        Console.Write(names[1, 0] + " ");
        Console.WriteLine(names[1, 1]);
        Console.Write(names[2, 0] + " ");
        Console.WriteLine(names[2, 1]);

        // regular 2D arrays has equal number of column in each row
    }

    // zagged array - having different number of columns in each row

    void LearnZaggedArray()
    {
        byte[][] personAges = new byte[3][];  //similar to C/C++ 2D-Array Declaration

        personAges[0] = new byte[2] { 34, 56 };  //specifying size i.e. 2 in this case is optional
        personAges[1] = new byte[] { 40, 86, 78 };

        //printing zagged array

        Console.WriteLine("Displaying Zagged Array");
        Console.Write("[ " + personAges[0][0] + " ");
        Console.WriteLine(personAges[0][1] + " ]");
        Console.Write("[" + personAges[1][0] + " ");
        Console.Write(personAges[1][1] + " ");
        Console.Write(personAges[1][2] + " ]");

    }
    static void Main2(string[] args)
    {
        Array arr = new Array();
        arr.Learn1DArray();
        arr.LearnMultiDArray();
        arr.LearnZaggedArray();
    }
}