using SampleAvoidIfs.Order;
using SampleAvoidIfs.Payments;
using SampleAvoidIfs.PaymentTypes;

namespace SampleAvoidIfsTests
{
    public class SampleAvoidIfsTests
    {
        private Order _order;
       
        [Fact(DisplayName = "Order Test Payment With Multiples Ifs Must Be Credicard")]
        public void OrderTestPaymentWithMultiplesIfsMustBeCredicard()
        {
            _order = new Order();
            var paymentType = _order.GetPaymentType(PaymentType.CreditCard);
            Assert.Equal(nameof(PaymentType.CreditCard), paymentType);
        }

        [Fact(DisplayName = "Order Test Payment With Class And Polimorf Must Be DebitCard")]
        public void OrderTestPaymentWithClassAndPolimorfMustBeDebitCard()
        {
            _order = new Order(new DebitCardPayment() as Payment, PaymentType.DebitCard);
            Assert.Equal(nameof(PaymentType.DebitCard), _order.GetPaymentTypeByClass());
        }

        [Fact(DisplayName = "Order Test Payment With Class And Polimorf Must Be DebitCard")]
        public void OrderTestPaymentWithInterfaceMustBeCash()
        {
            _order = new Order(new CashPayment() as IPayment, PaymentType.Cash);
            Assert.Equal(nameof(PaymentType.Cash), _order.GetPaymentTypeByInterface());
        }
    }
}