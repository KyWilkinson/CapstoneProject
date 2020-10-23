using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;
using Microsoft.IdentityModel.Protocols;

namespace Capstone.Controllers
{
    public class SMSController : TwilioController
    {
       public ActionResult SendSMS()
        {
            var accountSid = ConfigurationManager.Appsettings["TwilioAccountSid"];
            var authToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber(ConfigurationManager.AppSettings["MyPhoneNumber"]);
            var from = new PhoneNumber("");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "Game Time is at  ");

            return Content(message.Sid);
        }
    }
}
