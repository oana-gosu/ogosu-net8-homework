using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex2
{
    public class Book
    {
        public Book(string Title, string Author, int PageCount)
        {
            this.Title = Title;
            this.Author = Author;
            this.PageCount = PageCount;
            CurrentPage = 1;
        }
        private string Title { get; set; }
        private string Author { get; set; }
        private int PageCount { get; set; }
        private int CurrentPage { get; set; }



        public string GetTitle() { return Title; }
        public string GetAuthor() { return Author; }
        public int GetPageCount() { return PageCount; }
        public int GetCurrentPage() { return CurrentPage; }
        public int NextPage() { return CurrentPage=CurrentPage + 1; }
        public int PreviousPage() { return CurrentPage=CurrentPage - 1; }

        public string title
        {   
            get { return Title; }
            set { Title = value; }
        }

        public string author
        { 
            get { return Author; } 
            set {  Author = value; } 
        }
        
    }
}
