using System;
using System.Collections.Generic;
using System.Text;
using BankAccount;
using NFluent;
using Xunit;

namespace BankAccountTest
{
    public class MakeWithdrawalShould
    {
        [Fact]
        public void Return_the_value_of_the_withdrawal_when_we_make_a_transaction()
        {
            FakeTransaction fakeTransaction = new FakeTransaction();
            Account account= new Account(fakeTransaction);
            account.MakeWithDrawal(new Amount(30));
            Check.That(fakeTransaction.Transactionrecorder).Contains(new Amount(30));
        }
        [Fact]
        public void Return_the_value_of_two_withdrawals_when_we_make_a_transaction()
        {
            FakeTransaction fakeTransaction = new FakeTransaction();
            Account account= new Account(fakeTransaction);
            account.MakeWithDrawal(new Amount(30));
            account.MakeWithDrawal(new Amount(15));
            Check.That(fakeTransaction.Transactionrecorder).Contains(new Amount(30),new Amount(15));
        }
    }
}
