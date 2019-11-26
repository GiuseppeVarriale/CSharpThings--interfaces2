using System;
using System.Collections.Generic;
using System.Text;

namespace aula196_interfaces2.Entities
{
    class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
