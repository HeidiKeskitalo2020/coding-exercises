using System;

namespace exercise_124
{
    public class Person
    {
        private string person {get; set;}
        private int age;
        public Person(string name, int age)
        {
            this.person = name;
            this.age = 1;
        }
        public void GrowOlder()
        {
            this.age = age + 1;
        }
        public override string ToString()
        {
            return this.person + " " + this.age;
        }
    }
}