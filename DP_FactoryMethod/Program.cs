using DesignPatterns.Factories.FactoryMethod;

IPayment payment = PaymentFactory.create(PaymentMethod.CreditCard);
payment.Pay(1000.00);
