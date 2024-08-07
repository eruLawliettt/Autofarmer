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
using System.Windows;
using Autofarmer.Views;

namespace Autofarmer.ViewModels
{
    class NewEmailWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }
        public NewEmailWindow Window { get; set; }
        public string? EmailString { get; set; }

        public NewEmailWindowViewModel(MainWindowViewModel vmSender, NewEmailWindow window)
        {
            MainWindowViewModel = vmSender;
            Window = window;
            
        }

        private Email GetEmailModelFromString(string emailString)
        {
            string email = emailString[..emailString.IndexOf(':')];
            string password = emailString[(emailString.IndexOf(':') + 1)..emailString.LastIndexOf(':')];
            string recovery = emailString[(emailString.LastIndexOf(':') + 1)..];

            return new Email(email, password, recovery, GenerateQR(email + '1'));
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

            try
            {
                if (EmailString == null || EmailString == String.Empty)
                    MessageBox.Show("Поле пустое, введи почту.", "Ошибка.");
                else
                {
                    MainWindowViewModel.CurrentAccount.Email = GetEmailModelFromString(EmailString);
                    Window.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ты ввёл хуйню, введи почту.", "Ошибка.");
            }
        }

        public ICommand ChangeEmailCommand => new RelayCommand(x => ChangeEmail());
    }
}
