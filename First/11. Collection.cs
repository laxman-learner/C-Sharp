using System.Collections.Generic;
using System;
namespace LearnCollection
{

    class Collection
    {

        internal void LearnLists()
        {
            List<byte> ages = new List<byte>();
            ages.Add(35);
            ages.Add(10);
            ages.Add(100);
            ages.Add(78);
            ages.Add(60);

            // displaying list items

            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            List<Country> countires = new List<Country>();  // custom type list
            Country country1 = new Country();
            Country country2 = new Country();
            Country country3 = new Country();
            Country country4 = new Country();
            countires.Add(country1);
            countires.Add(country2);
            countires.Add(country3);
            countires.Add(country4);

        }

        // Dictionary is used to store key value pair.e.g. to store countries and their
        //   respective capital cities

        internal void LearnDictionary()
        {
            // Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            // countryCapitals.Add("Nepal", "Kathmandu");
            // countryCapitals.Add("India", "Delhi");
            // countryCapitals.Add("Bangladesh", "Dhaka");
            // countryCapitals.Add("Japan", "Tokiyo");

            // if what is to be stored in dictionary is preknown. We can add in dictionary as follow
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>
            {
                // () is optional and datatype of key and value may be different and of any type
                ["Nepal"] = "Kathmandu",
                ["India"] = "Delhi",
                ["Bangladesh"] = "Dhaka",
                ["Japan"] = "Tokiyo"

            };
            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country: {country.Key} Capital City : {country.Value}");
            }
        }
    }


    // Dictionary does not allow multiple same keys i.e. key collision



    public class Country
    {
        public string Name { get; set; }

        static void Main()
        {
            Collection collection = new Collection();
            collection.LearnDictionary();
            collection.LearnLists();
        }
    }
}









