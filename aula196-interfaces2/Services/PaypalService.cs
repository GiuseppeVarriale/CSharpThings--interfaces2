using System;
using System.Collections.Generic;
using System.Text;

namespace aula196_interfaces2.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double _feePercentage = 0.02;
        public const double _monthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * _monthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * _feePercentage;
        }
    }
}
