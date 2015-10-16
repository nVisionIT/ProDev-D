﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProDev.Email.Tests
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void SendEmail()
        {
            Email email = new Email() { To = "rehanav@nvisionit.co.za", Subject="Unit Test" };

            SendGrid sendGrid = new SendGrid();
            Assert.IsTrue(sendGrid.SendEmail(email));
        }

    }
}
