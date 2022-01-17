using OO_Labb2;

OrderService orderService = new OrderService(new ConsoleLogger(), new EmailService(new ConsoleLogger()));

orderService.Process(new Order
{
    Reciever = "example@example.com",
    ID = 12321,
    Priority = Priority.High,
    StreetAdress = "Some adress"
});

OrderService anotherOrderService = new OrderService(new ConsoleLogger(), new SMSService(new ConsoleLogger()));

anotherOrderService.Process(new Order
{
    Reciever = "+46734568921",
    ID = 31133,
    Priority = Priority.Medium,
    StreetAdress = "Some other adress"
});