namespace DesignPatternsInRealLife.CreationalPatterns.FactoryPattern
{
    public class SMSNotificationType : INotificationType
    {
        public string SendNotifcation()
        {
            return "This is sms notification";
        }
    }
}
