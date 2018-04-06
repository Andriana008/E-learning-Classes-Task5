using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task5;

namespace Task5UnitTest
{
    [TestClass]
    public class MailContactUnitTest
    {
        [TestMethod]
        public void CloneTest()
        {
            const string name = "natalia";
            const string mail = "natalia@gmail.com";
            MailContact mailContact = new MailContact(name, mail);
            object result = mailContact.Clone();

            MailContact actual = (MailContact)result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(mail, actual.Info);
        }

        [TestMethod]
        public void CompareToTestReturns1()
        {
            MailContact mailContact1 = new MailContact("natalia", "natalia@gmail.com");
            MailContact mailContact2 = new MailContact("anna", "anna@gmail.com");

            int actual = mailContact1.CompareTo(mailContact2);

            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void CompareToTestReturns0()
        {
            const string name = "natalia";
            const string mail = "natalia@gmail.com";
            MailContact mailContact1 = new MailContact(name, mail);
            MailContact mailContact2 = new MailContact(name, mail);

            int actual = mailContact1.CompareTo(mailContact2);

            Assert.AreEqual(actual, 0);
        }

        [TestMethod]
        public void ToStringTest()
        {
            const string name = "natalia";
            const string mail = "natalia@gmail.com";
            string expectedResult = $"{name} - {mail}";
            MailContact mailContact = new MailContact(name, mail);

            string actual = mailContact.ToString();

            Assert.AreEqual(actual, expectedResult);
        }

        [TestMethod]
        public void InputTest()
        {
            const string name = "sofia";
            const string mail = "sofia@gmail.com";
            const string data = "sofia sofia@gmail.com";
            MailContact mailContact = new MailContact();
            mailContact.Input(data);

            Assert.AreEqual(mailContact.Name, name);
            Assert.AreEqual(mailContact.Info, mail);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InputTestException()
        {
            const string name = "sofia";
            const string mail = "sofiagmail.com";
            const string data = "sofia sofiagmail.com";
            MailContact mailContact = new MailContact();
            mailContact.Input(data);

            Assert.AreEqual(mailContact.Name, name);
            Assert.AreEqual(mailContact.Info, mail);
        }
    }
}

