using QRCoder.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Autofarmer.Models
{
    class Email
    {
        public string? EmailString { get; set; }
        public string? Address { get; set; }
        public DrawingImage QRCode { get; set; }

        public Email(string emailString, string address, DrawingImage qRCode)
        {
            EmailString = emailString;
            Address = address;
            QRCode = qRCode;
        }
    }
}
