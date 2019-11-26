using System;
using System.Collections.Generic;
using System.Text;

namespace aula196_interfaces2.Services
{
    class PaypalService : OnlinePaymentService
    {
        private const double _feePercentage = 0.02;
        public const double _fonthlyInterest = 0.01;
        public double Interest(double amount, int months)
        {
            return amount * _fonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * _feePercentage;
        }
    }
}
