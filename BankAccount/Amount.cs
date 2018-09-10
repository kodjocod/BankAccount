using System;
using Microsoft.VisualBasic.CompilerServices;

namespace BankAccount
{
    public class Amount
    {
        private readonly int value;

        public Amount(int value)
        {
            this.value = value;
        }

        public static Amount operator + (Amount leftAmount, Amount rightAmount)
        {
            return new Amount(leftAmount.value + rightAmount.value);
        }

        public static Amount operator -(Amount leftAmount, Amount rightAmount)
        {
            return new Amount(leftAmount.value - rightAmount.value);

        }

        public override bool Equals(object obj)
        {
            var amount = obj as Amount;
            return amount != null &&
                   value == amount.value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }
}