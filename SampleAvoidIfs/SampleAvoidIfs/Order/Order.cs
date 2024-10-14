using SampleAvoidIfs.Payments;
using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfs.Order
{
    public class Order
    {
        private readonly PaymentType _paymentType;

        private readonly Payment _payment;

        private readonly IPayment ipayment;

        public Order()
        { 
        }

        public Order(Payment payment, PaymentType paymentType)
        {
            _payment = payment;
            _paymentType = paymentType;
        }

        public Order(IPayment payment, PaymentType paymentType)
        {
            ipayment  = payment;
            _paymentType = paymentType;
        }

        public string GetPaymentTypeByClass()
        {
            if (_payment is null)
                throw new Exception("Payment Class not implemented");

            return _payment.Pay(_paymentType);
        }

        public string GetPaymentTypeByInterface()
        {
            if (ipayment is null)
                throw new Exception("Payment Interface not implemented");

            return ipayment.Payment(_paymentType);
        }

        public string GetPaymentType(PaymentType paymentType)
        {
            return paymentType switch
            {
                PaymentType.CreditCard => nameof(PaymentType.CreditCard),
                PaymentType.DebitCard => nameof(PaymentType.DebitCard),
                PaymentType.Cash => nameof(PaymentType.Cash),
                PaymentType.Pix => nameof(PaymentType.Pix),
                PaymentType.Bill => nameof(PaymentType.Bill),
                _ => string.Empty,
            };
        }
    }
}
