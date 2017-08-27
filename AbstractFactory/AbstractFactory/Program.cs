using Interfaces;
using Providers;
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accntNumbers = new List<string>
            {
                "CITI-123","NATIONAL-456","CHASE-789"
            };

            for (int i = 0; i < accntNumbers.Count; i++)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactory.GetCreditUnionFactory(accntNumbers[i]);
                if(anAbstractFactory == null)
                {
                    Console.WriteLine($"Sorry, This credit union account number '{accntNumbers[i]}' is invalid");
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
