using OO_Labb2;

OrderService orderService = new OrderService();

orderService.Process(new Order
{
    Email = "example@example.com",
    ID = 12321,
    Priority = Priority.High,
    StreetAdress = "Some adress"
});
