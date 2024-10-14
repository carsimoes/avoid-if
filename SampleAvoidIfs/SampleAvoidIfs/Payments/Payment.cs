using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfs.Payments
{
    public abstract class Payment
   {
        public abstract string Pay(PaymentType paymentType);
   }
}
