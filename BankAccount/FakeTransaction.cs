using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class FakeTransaction : ITransaction
    {
        public List<Amount> Transactionrecorder = new List<Amount>();


        public void Add(Amount amount)
        {
            Transactionrecorder.Add(amount);
        }
    }
}
