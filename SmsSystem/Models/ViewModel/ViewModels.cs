using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsSystem.Models.ViewModel
{
    public class Message
    {
        public string To { get; set; }

        public string ToNumber()
        {
            string CountryCode = "+88" + To;

            return CountryCode;
        }
       
    }
}