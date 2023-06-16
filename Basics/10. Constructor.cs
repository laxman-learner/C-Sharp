using System;
namespace AllAboutClasses
{


    public class Country
    {

        public string Name { get; set; }
        public int Population { get; set; }

        // constant 

        // public const double AREA = 234.56; - this constant can not be redefined

        public readonly double Area = 234.89;
        // this is runtime constant can be redefined inside constructor only 



        // classess have default constructor - with no parameters and do nothing

        // instance constructor
        public Country()
        {

        }

        // parameterized constructor

        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            Area = area;
        }

    }
    public class Demo
    {
        void DoSomeThing()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal", 29464504, 147181);

        }
    }
}