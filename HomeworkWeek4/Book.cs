﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek4
{
    public class Book
    {
        public Book(string title, string author, int year) 
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public string title;
        public string author;
        public int year;
        public string GetTitle()
        { 
            return this.title; 
        }
        public string GetAuthor() 
        {
            return this.author;
        }

        public int GetYear() 
        {
            return this.year;
        }
        public void SetTitle(string title)
        { 
            this.title = title;
        }
        public void SetAuthor(string author) 
        {
            this.author = author;
        }

        public void SetYear(int year)
        { this.year = year; 
        }
    }
}
