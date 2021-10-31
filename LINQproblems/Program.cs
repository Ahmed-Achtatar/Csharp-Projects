using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQproblems
{
    class Program
    {

        static void Main(string[] args)
        {
            // LIST OF STRINGS
            var listOfStrings = new List<string>() 
            { "Ahmed", "Ali", "Assaad", "Oualid","Brahim",
                "Omar", "Hassan", "Hamid", "Anouar", "Farah",
                "Bousheta", "Houssam", "Hamza", "Imad", "Mouad", "Abdelilah" 
            };
            // LIST OF INTS
            var listOfInts = new List<int>() {1,277,0,-7,-888,-9,-16,392,2020,2021};

            // LIST OF DOUBLES
            var listOfDoubles = new List<double>() 
            {
                22.22,-11.11,9922.11,-100022.1,
                88.00,88.01,0,99,16 
            };

            // LISTS OF OBJECTS
            var listOfPeople = new List<People>()
            {
             new People("Ahmed",20,17.0,Gender.Male),
            new People("Ali",21,17.1,Gender.Male),
            new People("Assaad",23,13,Gender.Male),
            new People("Oualid",17,19.2,Gender.Male),
            new People("Brahim", 23, 16.9, Gender.Male),
            new People("Omar", 22, 12,  Gender.Male),
            new People("Abdelilah", 20, 17, Gender.Male),
            new People("Mouad", 21, 19, Gender.Male),
            new People("Imad",28,11,Gender.Male),
            new People("Hamza",27,12,Gender.Male),
            new People("Houssam",28,15,Gender.Male),
            new People("Fatima",48,2,Gender.Female),
            new People("Fatiha",48,2,Gender.Female),
            new People("Aicha",48,2,Gender.Female),
            new People("Samira",48,2,Gender.Female),
            new People("Hafida",48,2,Gender.Female),
            new People("Jamila",48,2,Gender.Female),
            new People("Tarik",48,2,Gender.Male),
            new People("Smail",48,2,Gender.Male),
            };

            Console.WriteLine("Hello World!");
        }

    }

    // OTHER CLASSES
    class People
    {
        // PROPERTIES
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Note { get; private set; }
        public Gender Gender { get; private set; }
        // METHODS

        public People(string name,int age,double note,Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Note = note;
            this.Gender = gender;
        }
        
    }

    internal enum Gender{
        Male,
        Female
    }
}
