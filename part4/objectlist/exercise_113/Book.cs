using System;
namespace exercise_113
{
    public class Book
    {
        public string name {get; set;}
        public string pages{get; set;}
        public string year {get; set;}

        public Book(string name, string pages, string year)
        {
            this.name = name;
            this.pages = pages;
            this.year = year;
        }
        public override string ToString()
        {
            return this.name + ", " + this.pages + " pages, " + this.year;
        }

    }
       
}

