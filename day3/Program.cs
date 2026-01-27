namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to bank account management system");
            day3.savingsaccount savingAcc = new day3.savingsaccount("SA123", "1234", 5.0m, "BR001");
            savingAcc.Deposit(1000);
            decimal interest = savingAcc.CalculateInterest();
            Console.WriteLine($"Interest for Saving Account: {interest}");

        }
    }
}
