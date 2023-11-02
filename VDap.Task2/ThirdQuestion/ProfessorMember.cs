using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.ThirdQuestion
{
    public class ProfessorMember : Member
    {
        public Book[] books;
        public struct Rules
        {
            public const int AcademicBooks = 2;
            public const int AcademicBooks_Month = 4;
            public const int Limitation = 4;
            public const int SuspensionPenalty = 2000;
        }
        public ProfessorMember(string Name, int NoBorrowedBooks, Book[] books)
        {
            this.Name = Name;
            this.NoBorrowedBooks = NoBorrowedBooks;
            Id = new Random().Next();
            this.books = books;
            foreach (var book in this.books)
            {
                book.BorrowedDate = DateOnly.FromDateTime(DateTime.Now);
                book.ReturnDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(Rules.AcademicBooks_Month);
                NoBorrowedBooks++;
            }
        }
        public bool IsAllowed()
        {
            if (NoBorrowedBooks > Rules.Limitation || PenaltyBalance != 0
                || (books.Count(a => a.Category == "Fictional") > 0)
                || (NoBorrowedBooks + books.Length) > 4)
            {
                return false;
            }
            return true;
        }
        public bool Defer(Book deferedbook)
        {
            if (deferedbook.NoDeferment < 2 && deferedbook.ReturnDate > DateOnly.FromDateTime(DateTime.Now))
            {
                deferedbook.ReturnDate = deferedbook.ReturnDate.AddDays(14);
                deferedbook.NoDeferment++;
                return true;
            }
            else
                return false;
        }
        public bool GiveBackOnTime(DateOnly returndate, Book[] books)
        {
            if (books.Count(a => a.ReturnDate < returndate) > 0)
            {
                foreach (var book in books.Where(a => a.ReturnDate < returndate))
                {
                    book.SuspensionDays = (returndate.Year - book.ReturnDate.Year) + (returndate.DayOfYear - book.ReturnDate.DayOfYear);
                    PenaltyBalance += book.SuspensionDays * Rules.SuspensionPenalty;
                }
                NoBorrowedBooks -=books.Length;
                return false;
            }
            else
            {
                NoBorrowedBooks -= books.Length;
                return true;
            }
        }
        public bool IsPenaltyPaid(int payment)
        {
            if((payment - PenaltyBalance) == 0)
            {
                PenaltyBalance = 0;
                return true;
            }
            return false;
        }
    }
}
