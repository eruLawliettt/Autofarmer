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
        public string? Address { get; set; }
        public string? Password { get; set; }
        public string? Recovery { get; set; }
        public DrawingImage QRCode { get; set; }

        public Email(string address, string password, string recovery, DrawingImage qRCode)
        {
            Address = address;
            Password = password;
            Recovery = recovery;
            QRCode = qRCode;
        }

        public string? FullEmailString => $"{Address}:{Password}:{Recovery}";
    }
}
