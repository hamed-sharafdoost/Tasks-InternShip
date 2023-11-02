using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.ThirdQuestion
{
    public class StudentMember : Member
    {
        public Book[] books;
        public struct Rules
        {
            public const int AcademicBooks = 2;
            public const int AcademicBooks_Month = 2;
            public const int FictionalBooks = 4;
            public const int Limitation = 4;
            public const int SuspensionPenalty_Fictional = 1000;
            public const int SuspensionPenalty_Academic = 2000;
        }
        public StudentMember(string name, int NoBorrowedBooks, Book[] books)
        {
            Name = name;
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
            if (NoBorrowedBooks > Rules.Limitation || PenaltyBalance != 0 || (NoBorrowedBooks + books.Length) > 4)
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
        public bool CheckCategoryLimitation()
        {
            if (books.Count(a => a.Category == "Academic") > Rules.AcademicBooks ||
                books.Count(b => b.Category == "Fictional") > Rules.FictionalBooks)
                return false;
            return true;
        }
        public bool GiveBackOnTime(DateOnly currentdate, Book[] books)
        {
            if (books.Count(a => a.ReturnDate < currentdate) > 0)
            {
                foreach (var book in books.Where(a => a.ReturnDate < currentdate))
                {
                    book.SuspensionDays = (currentdate.Year - book.ReturnDate.Year)*365 + (currentdate.DayOfYear - book.ReturnDate.DayOfYear);
                    if (book.Category == "Academic")
                        PenaltyBalance += book.SuspensionDays * Rules.SuspensionPenalty_Academic;
                    else
                        PenaltyBalance += book.SuspensionDays * Rules.SuspensionPenalty_Fictional;
                }
                NoBorrowedBooks -= books.Length;
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
            if ((payment - PenaltyBalance) == 0)
            {
                PenaltyBalance = 0;
                return true;
            }
            return false;
        }
    }
}
