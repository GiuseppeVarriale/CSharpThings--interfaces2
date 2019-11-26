namespace aula196_interfaces2.Services
{
    interface OnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
        
    }
}
