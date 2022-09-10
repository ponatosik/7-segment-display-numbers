namespace ConsoleNumberPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Input number to display in 'seven segment clock' style:");
            try 
            {
                number = Convert.ToInt32(Console.ReadLine());
                ConsolePrinter.PrintNumber(number);
            } 
            catch(FormatException)
            {
                Console.WriteLine("Input was not a number.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Input number was too big.");
            }
        }
    }
}
