namespace BankAccount
{
    public class Account
    {

        public FakeTransaction FakeTransaction { get; }
        public Account(FakeTransaction fakeTransaction)
        {
            FakeTransaction = fakeTransaction;
        }

        public void MakeDeposit(Amount amount)
        {
            FakeTransaction.Add(amount);
        }

        public void MakeWithDrawal(Amount amount)
        {
           FakeTransaction.Add(amount);
        }
    }
}