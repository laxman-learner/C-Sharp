using System;
using System.Linq;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Continent { get; set; }

    public long Population { get; set; }

    public DateTime IndependenceDay { get; set; }

    public Country(string n, string cp, string c, long p, DateTime i = default)
    // default means this this parameter is optional. If not provided default value is assigned
    {
        Name = n;   // or this.Name = n is also valid
        Capital = cp;
        Continent = c;
        Population = p;
        IndependenceDay = i;
    }
}

class Program
{
    void LearnLinqOnComplexCollection()
    {
        Country c1 = new Country("Nepal", "Kathmandu", "Asia", 34899892);

        // if constructor is not defined
        // c1.Name = "Nepal";
        // c1.Capital = "Kathmandu";
        // c1.Coninent = "Asia";
        // c1.Population = 34899892;

        Country c2 = new Country("India", "Delhi", "Asia", 4899892);
        Country c3 = new Country("England", "GB", "Europe", 13489989, DateTime.Parse("1947 / 11 / 1"));
        Country c4 = new Country("Bhutan", "Thimpu", "Asia", 2348998);
        Country c5 = new Country("Russia", "Mosco", "Europe", 4399892, DateTime.Parse("1947 / 11 / 1"));
        Country c6 = new Country("Australia", "Camberra", "Australia", 23489989, DateTime.Parse("1947 / 11 / 1"));

        List<Country> countries = new List<Country> { c1, c2, c3, c4, c5, c6 };

        // List all Asian country names
        var result1 = from country in countries
                      where country.Continent == "Asia"
                      select country.Name;
        Console.WriteLine("Asian Countries:");
        foreach (string countryName in result1)
        {
            Console.WriteLine(countryName);
        }

        // list all asian country names which are never been invaded

        var result2 = from country in countries
                      where country.Continent == "Asia" && country.IndependenceDay == default
                      select country.Name;

        Console.WriteLine("Asian Countries never been invaded:");
        foreach (string countryName in result2)
        {
            Console.WriteLine(countryName);
        }

        // list all european countries in ascending order that has population less than 500k

        var result3 = from country in countries
                      where country.Continent == "Europe" && country.Population < 5000000
                      orderby country.Name ascending
                      select country.Name;

        Console.WriteLine("European Countries with Population < 5000k:");
        foreach (string countryName in result3)
        {
            Console.WriteLine(countryName);
        }
    }
    static void Main1()
    {
        Program p1 = new Program();
        p1.LearnLinqOnComplexCollection();
        Console.WriteLine("All Right ?");

    }
}