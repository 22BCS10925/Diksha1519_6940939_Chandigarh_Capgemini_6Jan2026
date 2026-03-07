using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using BankAccountSystem;
using System.Threading.Tasks;
using System.Linq;

namespace BankAccount.Tests
{
    public class BankAccountTests
    {
        private BankAccounts account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccounts(100);
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            account.Deposit(50);

            Assert.That(account.Balance,Is.EqualTo(150));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            account.Withdraw(40);

            Assert.That(account.Balance, Is.EqualTo(60));
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
        }
    }
}
