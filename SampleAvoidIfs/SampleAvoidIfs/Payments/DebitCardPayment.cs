using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfs.Payments
{
    public class DebitCardPayment : Payment, IPayment
    {
        public override string Pay(PaymentType paymentType)
        {
            return Enum.GetName(typeof(PaymentType), paymentType);
        }

        public string Payment(PaymentType paymentType)
        {
            return Enum.GetName(typeof(PaymentType), paymentType);
        }
    }
}
