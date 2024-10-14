using SampleAvoidIfs.Payments;
using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfs.Helper
{
    public static class PaymentHelper
    {
        public static Dictionary<PaymentType, Payment> PaymentsClasses = new()
        {
            { PaymentType.CreditCard,  new CreditCardPayment() },
            { PaymentType.DebitCard, new DebitCardPayment() },
            { PaymentType.Cash, new CashPayment() },
            { PaymentType.Pix, new PixPayment() },
            { PaymentType.Bill, new BillPayment() }
        };

        public static Dictionary<PaymentType, IPayment> PaymentsInterfaces = new()
        {
            { PaymentType.CreditCard, new CreditCardPayment() },
            { PaymentType.DebitCard, new DebitCardPayment() },
            { PaymentType.Cash, new CashPayment() },
            { PaymentType.Pix, new PixPayment() },
            { PaymentType.Bill, new BillPayment() }
        };
    }
}
