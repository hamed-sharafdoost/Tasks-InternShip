using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDap.Task2.ThirdQuestion;

namespace LibraryUnitTest
{
    [TestClass]
    public class ProfessorTests
    {
        [TestMethod]
        public void Professor_IsAllowedToBorrow()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Nisti", "Leili golestan", false, DateOnly.FromDateTime(DateTime.Now)),
                new Book("Madar manteghi","Mano",true, DateOnly.FromDateTime(DateTime.Now)),
            };
            ProfessorMember professor = new ProfessorMember("Dr.Zamani", 0, books);

            //Act
            bool expected = false;
            bool actual = professor.IsAllowed();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Professor_GiveBackOnTime()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Physics","Holiday",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Math","Thomas",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Database","SilberShawtz",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Madar manteghi","Mano",true,DateOnly.FromDateTime(DateTime.Now))
            };
            ProfessorMember professor = new ProfessorMember("Dr.Zamani", 0, books);

            //Act
            bool expected = false;
            bool actual = professor.GiveBackOnTime(DateOnly.FromDateTime(DateTime.Now).AddMonths(5), books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Professor_PayPenalty()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Physics","Holiday",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Math","Thomas",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Database","SilberShawtz",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Madar manteghi","Mano",true,DateOnly.FromDateTime(DateTime.Now))
            };
            ProfessorMember professor = new ProfessorMember("Dr.Zamani", 0, books);

            //Act
            professor.GiveBackOnTime(DateOnly.FromDateTime(DateTime.Now).AddMonths(5), books);
            //31 days * numberOfBooks * 2000
            int penaltyexpected = 248000;
            int penaltyactual = professor.PenaltyBalance;

            //Assert
            Assert.AreEqual(penaltyexpected, penaltyactual);
        }
        [TestMethod]
        public void Professor_IsAllowedToDefer()
        {
            //Arrange
            Book book1 = new Book("Math", "Thomas", true, DateOnly.FromDateTime(DateTime.Now));
            Book book2 = new Book("Madar manteghi", "Mano", true, DateOnly.FromDateTime(DateTime.Now));
            ProfessorMember professor = new ProfessorMember("Dr.Zamani", 0, new Book[] { book1, book2 });

            //Act
            bool expected = false;
            professor.Defer(book1);
            professor.Defer(book1);
            bool actual = professor.Defer(book1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
