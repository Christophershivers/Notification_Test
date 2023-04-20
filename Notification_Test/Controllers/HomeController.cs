using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notification_Test.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Notification_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;

            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(NotificationModel nm)
        {
            var guidId = new Guid();

            nm.id = guidId;
            nm.isRead = false;

            _context.Notifications.Add(nm);
            _context.SaveChanges();

            return View();
        }

        public async Task<IActionResult> ChangeNotification()
        {
            var list = _context.Notifications.Where(x => x.isRead == false).ToList();

            foreach(var change in list)
            {
                change.isRead = true;
            }

            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        public IActionResult NotificationCenter()
        {
           var list = _context.Notifications.ToList();

            

            return View(list);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
