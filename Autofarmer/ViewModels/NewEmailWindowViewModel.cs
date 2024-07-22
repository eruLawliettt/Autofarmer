using Autofarmer.Models;
using QRCoder.Xaml;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Autofarmer.ViewModels
{
    class NewEmailWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }
        public string? EmailString { get; set; }

        public NewEmailWindowViewModel(MainWindowViewModel vmSender)
        {
            MainWindowViewModel = vmSender;
        }

        private EmailModel GetEmailModelFromString(string emailString)
        {
            string email = emailString[..emailString.IndexOf(':')];
            string password = emailString[(emailString.IndexOf(':') + 1)..emailString.LastIndexOf(':')];
            string recovery = emailString[(emailString.LastIndexOf(':') + 1)..];

            return new EmailModel(email, password, recovery, GenerateQR(email + '1'));
        }

        DrawingImage GenerateQR(string value)
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            XamlQRCode qrCode = new XamlQRCode(qrCodeData);
            DrawingImage qrCodeAsXaml = qrCode.GetGraphic(20);
            return qrCodeAsXaml;

        }

        void ChangeEmail()
        {
            MainWindowViewModel.CurrentAccount.Email = GetEmailModelFromString(EmailString);
        }

        public ICommand ChangeEmailCommand => new RelayCommand(x => ChangeEmail());
    }
}
