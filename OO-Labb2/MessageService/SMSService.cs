namespace OO_Labb2
{
    public class SMSService : IMessageService
    {
        private IConsoleLogger _consoleLogger;
        public SMSService(IConsoleLogger consoleLogger)
        {
            this._consoleLogger = consoleLogger;
        }
        public void Send(Order order, string subject, string message)
        {
            _consoleLogger.Log($"SMS sent to {order.Reciever} about order {order.ID}");
        }
    }
}

