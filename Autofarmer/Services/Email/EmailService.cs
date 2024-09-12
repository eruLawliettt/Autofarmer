using Autofarmer.Models;
using QRCoder.Xaml;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Autofarmer.Services.Email
{
    internal class EmailService : IEmailService
    {
        public List<Models.Email> GetEmailModels(List<string> emailStrings)
        {
            List<Models.Email> emailModels = [];

            foreach (string emailString in emailStrings)
            {
                emailModels.Add(GetEmailModelFromString(emailString));
            }

            return emailModels;
        }

        public Models.Email GetEmailModel(List<Models.Email> emailModels)
        {
            var email = emailModels.First();
            emailModels.Remove(email);

            return email;
        }

        public Models.Email GetEmailModelFromString(string emailString)
        {
            string email = emailString[..emailString.IndexOf('@')] + "@gmail.com";

            return new Models.Email(emailString, email, GenerateQR(email + '1'));
        }

        private DrawingImage GenerateQR(string value)
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            XamlQRCode qrCode = new XamlQRCode(qrCodeData);
            DrawingImage qrCodeAsXaml = qrCode.GetGraphic(20);
            return qrCodeAsXaml;

        }
    }
}
