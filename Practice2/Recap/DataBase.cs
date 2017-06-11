using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    public class DataBase
    {
        public List<Person> Persons;

        public DataBase()
        {
            Persons = new List<Person>();

            Persons.Add(new Student("Remus", 21, 10));
            Persons.Add(new Student("Ana", 21, 9));
            Persons.Add(new Student("Dan", 18, 10));
            Persons.Add(new Person("Amalia", 8));
            Persons.Add(new Person("David", 4));
            Persons.Add(new Student("Raluca", 19, 9));
            Persons.Add(new Student("Alex", 22, 8));
            Persons.Add(new Student("Magda", 22, 8));
            Persons.Add(new Person("Jimi", 3));
            Persons.Add(new Student("Marius", 23, 5));
        }

        public List<Person> GetByAge(int age)
        {
            var result = (from person in Persons where person.age == age select person).ToList();

            return result;
        }

        public List<Person> GetByAgeRange(int age1, int age2)
        {
            List<Person> result = (from person in Persons where person.age >= age1 && person.age <= age2 select person).ToList();

            return result;
        }

        
    }
}
