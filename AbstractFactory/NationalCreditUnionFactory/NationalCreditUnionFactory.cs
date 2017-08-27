using Interfaces;
using System;

namespace NationalCreditUnion
{
    // Product A2
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }
    }

    // Product B2
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }

    //Consrete Factory 2
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {

            NationalLoanAccount obj = new NationalLoanAccount();
            return obj;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount obj = new NationalSavingsAccount();
            return obj;
        }
    }
}
