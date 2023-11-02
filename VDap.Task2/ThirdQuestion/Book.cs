using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.ThirdQuestion
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateOnly BorrowedDate { get; set; }
        public DateOnly ReturnDate { get; set; }
        public int SuspensionDays { get; set; }
        public int NoDeferment { get; set; }
        public Book(string Title,string Author,bool academic,DateOnly BorrowedDate)
        {
            this.Title = Title;
            this.Author = Author;
            Category = academic ? "Academic" : "Fictional";
            this.BorrowedDate = BorrowedDate;
        }
    }
}
