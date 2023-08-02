using DesignPatternsInRealLife.CreationalPatterns.FactoryPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsInRealLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryPatternController : ControllerBase
    {
        private INotificationFactory _notification;
        public FactoryPatternController(INotificationFactory notificationFactory)
        {
            _notification= notificationFactory;
        }
        [HttpPost(Name = "SendNotification")]
        public IActionResult Get(string type)
        {
            var notificationType = _notification.GetNotificationType(type);
            var noticationMessage = notificationType.SendNotifcation();
            return Ok(noticationMessage);
        }
    }
}
