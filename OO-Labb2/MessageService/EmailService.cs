namespace OO_Labb2
{
    public class EmailService : IMessageService
    {
        private IConsoleLogger _consoleLogger;
        public EmailService(IConsoleLogger consoleLogger)
        {
            this._consoleLogger = consoleLogger;
        }
        public void Send(Order order, string subject, string message)
        {
            _consoleLogger.Log($"Email sent to {order.Reciever} about order {order.ID}");
        }
    }
}
