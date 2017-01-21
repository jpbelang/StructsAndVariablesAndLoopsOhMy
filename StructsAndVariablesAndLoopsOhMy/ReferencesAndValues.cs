using System;

namespace StructsAndVariablesAndLoopsOhMy
{
    public struct PersonStruct
    {

        public string Nom;
        public int Age;

        public PersonStruct(string nom, int age)
        {
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return Nom + "(" + Age + ")";
        }

    }

    public class PersonClass
    {
        public string Nom;
        public int Age;

        public PersonClass(string nom, int age)
        {
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return Nom + "(" + Age + ")";
        }

    }

    public class ReferencesAndValues
    {
        static void Main(string[] args)
        {

            // Les valeurs....
            {
                int singleInt = 4;
                int anotherInt = singleInt;
                anotherInt = 3;
                Console.WriteLine("les entiers " + singleInt + ", " + anotherInt);
            }

            // Les references...
            {
                int[] integers = new int[5];
                integers[0] = 3;
                int[] myIntegers = integers;
                Console.WriteLine("myIntegers = " + myIntegers[0]);
            }

            // Les structs
            {
                PersonStruct personOne = new PersonStruct("JP", 23);
                Console.WriteLine("struct personOne is " + personOne.Nom + " " + personOne.Age);

                PersonStruct samePerson = personOne;
                samePerson.Age = 33;

                // A-t-on tu change la personOne ?
                Console.WriteLine("struct personOne is " + personOne.Nom + " " + personOne.Age);
            }

            // Les classes
            {
                PersonClass personOne = new PersonClass("JP", 23);
                Console.WriteLine("class personOne is " + personOne.Nom + " " + personOne.Age);

                PersonClass samePerson = personOne;
                samePerson.Age = 33;

                // A-t-on tu change la personOne ?
                Console.WriteLine("class personOne is " + personOne.Nom + " " + personOne.Age);
            }
        }
    }
}