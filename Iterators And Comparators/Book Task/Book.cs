﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }


        public Book(string title,int year,params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }


        public int CompareTo(Book other)
        {
            
            if (this.Year.CompareTo(other.Year) != 0)
            {
                this.Year.CompareTo(other.Year);
            }
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{this.Title} {this.Year}";
        }
    }
}
