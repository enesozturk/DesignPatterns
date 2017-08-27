namespace Singleton
{
    public class Policy
    {
        private static readonly Policy _instance = new Policy();
        public static Policy Instance
        {
            get
            {
                return _instance;
            }
        }

        public Policy()
        {

        }
        public int Id { get; set; } = 123;
        public string Insured { get; set; } = "Enes Ozturk";

        public string GetInsuredName() => Insured;
    }
}
