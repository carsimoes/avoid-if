using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfs.Payments
{
    public interface IPayment
    {
        public string Payment(PaymentType paymentType);
    }
}
