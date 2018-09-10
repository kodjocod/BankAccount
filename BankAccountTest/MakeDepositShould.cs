using System;
using System.ComponentModel.Design;
using BankAccount;
using NFluent;

using Xunit;

namespace BankAccountTest
{
    public class MakeDepositShould
    {
        [Fact]
        public void Return_the_value_of_the_deposit_when_we_make_a_transaction()
        {
            FakeTransaction fakeTransaction = new FakeTransaction();
            Account account = new Account(fakeTransaction);
            account.MakeDeposit(new Amount(10));
            Check.That(fakeTransaction.Transactionrecorder).Contains(new Amount(10));
        }

        [Fact]
        public void Return_the_amount_of_two_deposits()
        {
            FakeTransaction fakeTransaction = new FakeTransaction();
            Account account = new Account(fakeTransaction);
            account.MakeDeposit(new Amount(10));
            account.MakeDeposit(new Amount(50));
            Check.That(fakeTransaction.Transactionrecorder).Contains(new Amount(10),new Amount(50));
        }
    }
}
