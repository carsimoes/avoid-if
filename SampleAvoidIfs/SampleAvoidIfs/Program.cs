using SampleAvoidIfs.Helper;
using SampleAvoidIfs.Order;
using SampleAvoidIfs.PaymentTypes;

var order = new Order();

var order2 = new Order(PaymentHelper.PaymentsClasses[PaymentType.CreditCard], PaymentType.CreditCard);

var order3 = new Order(PaymentHelper.PaymentsInterfaces[PaymentType.DebitCard], PaymentType.DebitCard);

Console.WriteLine(order.GetPaymentType(PaymentType.Cash));

Console.WriteLine(order2.GetPaymentTypeByClass());

Console.WriteLine(order3.GetPaymentTypeByInterface());