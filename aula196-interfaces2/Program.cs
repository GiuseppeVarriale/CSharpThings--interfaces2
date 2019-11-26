using System;
using System.Globalization;
using aula196_interfaces2.Entities;

namespace aula196_interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: " );
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractTotalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(contractNumber, contractDate, contractTotalValue);
            Console.WriteLine($"contract number: {contract.Number}, date: {contract.Date}, total value: {contract.TotalValue}");
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
        
        }
    }
}
