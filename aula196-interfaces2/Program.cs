using System;
using System.Globalization;
using aula196_interfaces2.Entities;
using aula196_interfaces2.Services;

namespace aula196_interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractTotalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract myContract = new Contract(contractNumber, contractDate, contractTotalValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContracts(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment x in myContract.Installments)
            {
                Console.WriteLine($"{x.DueDate.ToString("dd/MM/yy")} - {x.Amount.ToString("F2", CultureInfo.InvariantCulture)} ");
            }
        }
    }
}
