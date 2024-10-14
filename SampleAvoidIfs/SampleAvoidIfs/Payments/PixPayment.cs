using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfs.Payments
{
    public sealed class PixPayment : Payment, IPayment
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
