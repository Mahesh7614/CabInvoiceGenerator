namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator!");
            InvoiceGenerator objInvoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = objInvoiceGenerator.CalculateFare(6.0, 15);
            Console.WriteLine($"Fare: {fare}");
        }
    }
}