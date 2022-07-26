using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bankmethod;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_Amount_to_Balance()
        {
            var account = new BankAccount(1000);

            account.Add(400);

            Assert.AreEqual(1400, account.Balance);
        }

        [TestMethod]
        public void Withdrawing_Amount_from_Balance()
        {
            var account = new BankAccount(1000);

            account.Withdraw(400);

            Assert.AreEqual(600, account.Balance);
        }

        [TestMethod]
        public void TransferingFunds_to_otherBank_account()
        {
            var account = new BankAccount(1000);
            var otheraccount = new BankAccount(1000);

            account.Withdraw(400);

            Assert.AreEqual(600, account.Balance);
        }
    }
}
