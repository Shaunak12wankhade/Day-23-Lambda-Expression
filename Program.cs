using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Lambda Expression");

            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
            CheckingForTeenagerPerson(listPersonInCity);
            AllPersonsAverageAge(listPersonInCity);
            CheckNameExistOrNot(listPersonInCity);
            SkipPersonsLessThan60(listPersonInCity);
            RemoveSpecificPerson(listPersonInCity);
            Console.ReadKey();
        }

        // UC1
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
            Console.WriteLine(listPersonInCity.ToString());
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));

        }

        // UC2
        private static void Retrieving_TopTwoRecord_ForAgels_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge: " + person.Age);
            }

        }

        //UC3
        private static void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, we have some teen-agers in the list");
            }
            else
                Console.WriteLine("No, we don't have teen-agers in the list");

        }

        //UC4
        private static void AllPersonsAverageAge(List<Person> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is :" + avgAge);
        }

        //UC5
        private static void CheckNameExistOrNot(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine("Yes, A person having name \"SAM\" exists in our list");
            }
        }

        //UC6
        private static void SkipPersonsLessThan60(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine($"Name: {person.Name},     Age: {person.Age}");
            }
        }

        //UC7
        private static void RemoveSpecificPerson(List<Person> listPersonInCity)
        {
            listPersonInCity.Remove(listPersonInCity.Find(e => e.Name == "SAM"));

            listPersonInCity.ForEach(x => Console.WriteLine($"SSN: {x.SSN} | " +
                $"Name: {x.Name} | Address: {x.Address} | Age: {x.Age}"));
        }
    }
    
}
    

