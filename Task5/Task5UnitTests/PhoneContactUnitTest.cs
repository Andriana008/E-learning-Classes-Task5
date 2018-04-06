using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task5;

namespace Task5UnitTest
{
    [TestClass]
    public class PhoneContactUnitTest
    {
        [TestMethod]
        public void CloneTest()
        {
            const string name = "anna";
            const string phone = "2513529";
            PhoneContact phoneContact = new PhoneContact(name, phone);
            object result = phoneContact.Clone();

            PhoneContact actual = (PhoneContact)result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(phone, actual.Info);
        }

        [TestMethod]
        public void CompareToTestReturns1()
        {
            PhoneContact phoneContact1 = new PhoneContact("natalia", "12345");
            PhoneContact phoneContact2 = new PhoneContact("anna", "8654569");

            int actual = phoneContact1.CompareTo(phoneContact2);

            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void CompareToTestReturns0()
        {
            const string name = "natalia";
            const string phone = "251352";
            PhoneContact phoneContact1 = new PhoneContact(name, phone);
            PhoneContact phoneContact2 = new PhoneContact(name, phone);

            int actual = phoneContact1.CompareTo(phoneContact2);

            Assert.AreEqual(actual, 0);
        }

        [TestMethod]
        public void ToStringTest()
        {
            const string name = "natalia";
            const string mail = "25147865";
            string expectedResult = $"{name} - {mail}";
            PhoneContact phoneContact = new PhoneContact(name, mail);

            string actual = phoneContact.ToString();

            Assert.AreEqual(actual, expectedResult);
        }

        [TestMethod]
        public void InputTest()
        {
            const string name = "sofia";
            const string phone = "12554121245";
            const string data = "sofia 12554121245";
            PhoneContact phoneContact = new PhoneContact();
            phoneContact.Input(data);

            Assert.AreEqual(phoneContact.Name, name);
            Assert.AreEqual(phoneContact.Info, phone);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InputTestException()
        {
            const string name = "sofia";
            const string phone = "12554121245s";
            const string data = "sofia 12554121245s";
            PhoneContact phoneContact = new PhoneContact();
            phoneContact.Input(data);

            Assert.AreEqual(phoneContact.Name, name);
            Assert.AreEqual(phoneContact.Info, phone);
        }
    }
}

