using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification_Test.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options): base(options)
        {

        }

        public DbSet<NotificationModel> Notifications { get; set; }
    }
}
