using System;

namespace laba_4
{
    
    class Person
    {
        private string _name;
        private int _birthYear;

        public string Name
        {
            get { return _name; }
        }
        public int BirthYear
        {
            get { return _birthYear; }
        }

        public Person()
        {

        }
        public Person(string name, int birthYear)
        {
            _name = name;
            _birthYear = birthYear;
        }

        public int Age()
        {
            int age = 2022 - _birthYear;
            return age;
        }
        public Person Input()
        {
            string name;
            int birthYear;

            Console.Write(" name - ");
            name = Console.ReadLine();
            Console.Write(" year - ");
            while (!Int32.TryParse(Console.ReadLine(), out birthYear))
            {
                Console.Write("Error, year is not correct ");
                Console.Write("\n year - ");
            }

            return new Person(name, birthYear);
        }
        public string ChangeName()
        {
            this._name = "Very Young";
            return this._name;
        }
        public override string ToString()
        {
            return "name - " + _name + ",\t \t the birthday year - " + _birthYear.ToString();
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person first, Person second)
        {

            return first._name == second._name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        static void Main(string[] args)
        {
            Person[] persons = new Person[6];
            Console.WriteLine("Enter information about person");

            for (int i = 0; i < 6; i++)
            {
                Person p = new Person();
                persons[i] = p;
                Console.WriteLine("\n Person {0}.", (i + 1));
                persons[i] = persons[i].Input();
            }

            Console.WriteLine("\n Information about age");
            foreach (Person person in persons)
            {
                int age;
                age = person.Age();
                Console.WriteLine("name - {0},\t age - {1}", person.Name, age);
            }

            Console.WriteLine("\n Output");
            foreach (Person person in persons)
            {
                int age;
                age = person.Age();
                if (age < 16)
                {
                    person.ChangeName();
                }
                person.Output();
            }
            Console.WriteLine("\n  Persons with the same names");
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.Write("Person {0}. - ", (i + 1));
                        persons[i].Output();
                        Console.Write("Person {0}. - ", j);
                        persons[j].Output();
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}