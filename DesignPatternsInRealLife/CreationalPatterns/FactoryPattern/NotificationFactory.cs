namespace DesignPatternsInRealLife.CreationalPatterns.FactoryPattern
{
    public class NotificationFactory : INotificationFactory
    {
        public INotificationType GetNotificationType(string name)
        {
            switch (name)
            {
                case "SMS": 
                    return new SMSNotificationType();
                case "Email":
                    return new EmailNotificationType();
                default: 
                    return default;
            }
        }
    }
}
