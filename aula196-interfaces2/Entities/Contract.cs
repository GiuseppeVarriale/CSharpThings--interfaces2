using System;
using System.Collections.Generic;
using System.Text;

namespace aula196_interfaces2.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }

        public List<Installment> Instalments { get; private set; }  = new List<Installment>();
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
}
