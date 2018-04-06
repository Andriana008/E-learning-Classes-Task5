using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Task5;

namespace Task5UnitTests
{
    [TestClass]
    public class TaskUnitTest
    {
        [TestMethod]
        public void CloneListTest()
        {
            const string name1 = "anna";
            const string phone = "2513529";
            PhoneContact phoneContact = new PhoneContact(name1, phone);
            const string name2 = "nazar";
            const string mail = "nazar@gmail.com";
            MailContact mailContact = new MailContact(name2, mail);
            List<IContact> result = new List<IContact>();
            result.Add(phoneContact);
            result.Add(mailContact);
            Task task = new Task();

            List<IContact>  actual = task.CloneList(result);
           
            Assert.AreEqual(name1, actual[0].Name);
            Assert.AreEqual(phone, actual[0].Info);
            Assert.AreEqual(name2, actual[1].Name);
            Assert.AreEqual(mail, actual[1].Info);
        }

        [TestMethod]
        public void ParseTestReturnsMailContact()
        {
            const string name = "nazar";
            const string mail = "nazar@gmail.com";
            const string data = "1 nazar nazar@gmail.com";
            Task task = new Task();

            IContact actual = task.Parse(data);

            Assert.IsInstanceOfType(actual, typeof(MailContact));
            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(mail, actual.Info);
        }

        [TestMethod]
        public void ParseTestReturnsPhoneContact()
        {
            const string name = "nazar";
            const string phone = "7686786786";
            const string data = "2 nazar 7686786786";
            Task task = new Task();

            IContact actual = task.Parse(data);

            Assert.IsInstanceOfType(actual, typeof(PhoneContact));
            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(phone, actual.Info);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ParseTestException()
        {
            const string name = "nazar";
            const string phone = "7686786786";
            const string data = "3 nazar 7686786786";
            Task task = new Task();

            IContact actual = task.Parse(data);
        }
    }
}
