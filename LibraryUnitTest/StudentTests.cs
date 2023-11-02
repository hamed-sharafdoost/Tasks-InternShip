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
    public class StudentTests
    {
        [TestMethod]
        public void Student_IsAllowedToBorrow()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Nisti","Leili golestan",false,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Database","SilberShawtz",true,DateOnly.FromDateTime(DateTime.Now))
            };
            StudentMember student = new StudentMember("Ahmad molaei", 4, books);

            //Act
            bool expected = true;
            bool result = student.IsAllowed();

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Student_CheckCategoryLimitation()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Mathematics","Thomas",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Database","SilberShawtz",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Madar manteghi","Mano",true,DateOnly.FromDateTime(DateTime.Now))
            };
            StudentMember student = new StudentMember("Ali", 0, books);

            //Act
            bool expected = false;
            bool result = student.CheckCategoryLimitation();

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Student_GiveBackOnTime()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Nisti","Leili golestan",false,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Bar Hasti","Milan kondera",false,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Database","SilberShawtz",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Madar manteghi","Mano",true,DateOnly.FromDateTime(DateTime.Now))
            };
            StudentMember student = new StudentMember("Ali", 0, books);

            //Act
            bool expected = false;
            bool result = student.GiveBackOnTime(DateOnly.FromDateTime(DateTime.Now).AddMonths(4), books);
            //Two months late = 61 days * 1000 * numberoffictional books + 61 days * 2000 * numberofacademic books
            //int penaltyexpected = 366000;
            //int penaltyactual = student.PenaltyBalance;

            //Assert
            Assert.AreEqual(expected, result);
            //Assert.Equal(penaltyexpected, penaltyactual);
        }
        [TestMethod]
        public void Student_PayPenalty()
        {
            //Arrange
            Book[] books = new Book[]
            {
                new Book("Nisti","Leili golestan",false,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Bar Hasti","Milan kondera",false,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Database","SilberShawtz",true,DateOnly.FromDateTime(DateTime.Now)),
                new Book("Madar manteghi","Mano",true,DateOnly.FromDateTime(DateTime.Now))
            };
            StudentMember student = new StudentMember("Ali", 0, books);

            //Act
            student.GiveBackOnTime(DateOnly.FromDateTime(DateTime.Now).AddMonths(3), books);
            int penaltyexpected = 180000;
            int penaltyactual = student.PenaltyBalance;

            //Assert
            Assert.AreEqual(penaltyexpected, penaltyactual);
        }
        [TestMethod]
        public void Student_IsAllowedToDefer()
        {
            //Arrange
            Book book1 = new Book("Nisti", "Leili golestan", false, DateOnly.FromDateTime(DateTime.Now));
            Book book2 = new Book("Madar manteghi", "Mano", true, DateOnly.FromDateTime(DateTime.Now));
            StudentMember student = new StudentMember("Ali", 0, new Book[] { book1, book2 });

            //Act
            bool expected = false;
            student.Defer(book1);
            student.Defer(book1);
            bool actual = student.Defer(book1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
