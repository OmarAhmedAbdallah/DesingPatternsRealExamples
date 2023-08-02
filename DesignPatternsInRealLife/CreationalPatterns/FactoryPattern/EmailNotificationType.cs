namespace DesignPatternsInRealLife.CreationalPatterns.FactoryPattern
{
    public class EmailNotificationType : INotificationType
    {
        public string SendNotifcation()
        {
            return "This is email notification";
        }
    }
}
