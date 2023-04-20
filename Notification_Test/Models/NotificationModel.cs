using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notification_Test.Models
{
    public class NotificationModel
    {
        [Key]
        public Guid id { get; set; }
        public string message { get; set; }
        public Boolean isRead { get; set; }

    }
}
