using Nexmo.Api;
using SmsSystem.Helper;
using SmsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace SmsSystem.Controllers
{
    public class SmsController : Controller
    {
        // GET: Sms
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            string password = GeneratePasswordForUserRegistration.Get();
            string fromNumber = ConfigurationManager.AppSettings["NEXMO_FROM_NUMBER"];
           // string fromNumber = Configuration.Instance.Settings["appSettings:NEXMO_FROM_NUMBER"].ToString();
            var results = SMS.Send(new SMS.SMSRequest
            {
                from = fromNumber,
                to = message.ToNumber(),
                text =GeneratePasswordForUserRegistration.Get()


            });


            return View();
        }
    }
}