using static System.Console;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var director = new Director();
            var president = new President();

            manager.SetNextApprover(director);
            director.SetNextApprover(president);

            WriteLine("How much do you need approval?");
            double amount = double.Parse(ReadLine());
            manager.Approve(amount);

            ReadLine();
        }
    }
}
