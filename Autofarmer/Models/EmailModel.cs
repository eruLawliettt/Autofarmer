using QRCoder.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Autofarmer.Models
{
    class EmailModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Recovery { get; set; }
        public DrawingImage QRCode { get; set; }

        public EmailModel(string email, string password, string recovery, DrawingImage qRCode)
        {
            Email = email;
            Password = password;
            Recovery = recovery;
            QRCode = qRCode;
        }

        public string? FullEmailString => $"{Email}:{Password}:{Recovery}";
    }
}
