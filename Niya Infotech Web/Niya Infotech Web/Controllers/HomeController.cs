using Microsoft.AspNetCore.Mvc;
using Niya_Infotech_Web.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;


namespace Niya_Infotech_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger )
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Testimonials()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contactus model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var name = model.Name;
            var email = model.Email;
            var subject = model.Subject;
            var phone = model.Phone;
            var message = model.Message;

            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("info.niyainfotech@gmail.com", "tfrf wetq lwtp xtyl"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("info.niyainfotech@gmail.com"),
                    Subject = subject,
                    Body = $"Name: {name}\nEmail: {email}\nPhone: {phone}\nMessage: {message}",
                    IsBodyHtml = false,
                };

                mailMessage.To.Add("info.niyainfotech@gmail.com");

                smtpClient.Send(mailMessage);

                ViewBag.Message = "Email sent successfully! We Will Contact You Soon...";
                ModelState.Clear();
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error occurred while sending the email. Please try again later.";
                return View(model);
            }
        }


        public IActionResult FAQ()
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
