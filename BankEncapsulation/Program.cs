namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("How much money would you like to deposit today?");
            double amountToDeposit = double.Parse(Console.ReadLine()); 
            account.Deposit(amountToDeposit);
            double userBalance = account.GetBalance();
            

            Console.WriteLine($"Your account balance is {userBalance,0:c}");
            
        }
    }
}
