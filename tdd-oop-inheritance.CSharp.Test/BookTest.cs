﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void GetAuthorName_Book()
        {
            Author author = new Author("Herman Melville", "Woodlawn Cemetery", "www.melville.org");
            Book book = new Book("Moby Dick", author);

            string expectedResult = book.getAuthorName();
            string actualResult = "Herman Melville";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}