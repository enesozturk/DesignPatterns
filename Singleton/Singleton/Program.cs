using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
