namespace DesignPatternsInRealLife.CreationalPatterns.FactoryPattern
{
    public interface INotificationFactory
    {
        INotificationType GetNotificationType(string name);
    }
}
