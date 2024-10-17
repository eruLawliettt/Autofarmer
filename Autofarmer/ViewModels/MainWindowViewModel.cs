using Autofarmer.Models;
using Autofarmer.PseudoDatabase;
using Autofarmer.Services.Account;
using Autofarmer.Services.Email;
using Autofarmer.Services.FilesHandling;
using Autofarmer.Views;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using static QRCoder.PayloadGenerator;
using OpenQA.Selenium.DevTools.V127.Storage;

namespace Autofarmer.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly string _descriptionsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Descriptions.txt";
        private readonly string _accountsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Accounts.txt";
        private readonly string _JACsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Jobs and Companies.txt";
        private readonly string _emailsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Emails.txt";
     
        private readonly FileService _fileService = new();
        private readonly EmailService _emailService = new();
        private readonly AccountService _accountService = new();

        private ChromeDriver _chromeDriver;

        private int TotalAccounts = 0;

        private List<Account> _accounts = [];
        private Account _currentAccount;
        private int _currentAccountNumber;

        public List<Account> Accounts 
        { 
            get => _accounts; 
            set => Set(ref _accounts, value, nameof(Accounts)); 
        }

        public Account CurrentAccount
        {
            get { return _currentAccount; }
            set => Set(ref _currentAccount, value, nameof(CurrentAccount));
        }

        public int CurrentAccountNumber
        {
            get { return _currentAccountNumber; }
            set => Set(ref _currentAccountNumber, value, nameof(CurrentAccountNumber));
        }

        public MainWindowViewModel()
        {
            List<string> accountStrings = _fileService.ReadFileByLines(_accountsFilePath);
            List<string> descriptions = _fileService.ReadFileByLines(_descriptionsFilePath);
            Dictionary<string, string> jacs = _fileService.GetDictionaryFromFile(_JACsFilePath);

            List<Email> emailModels = _emailService.GetEmailModels(_fileService.ReadFileByLines(_emailsFilePath));
           
            foreach (var accountString in accountStrings)
            {
                string jac = _accountService.GetRandomJaCString(jacs);
                string city = _accountService.GetCityFromAccountIdString(accountString);
                CityGeolocation cityGeolocation = GeoDataBase.CityGeolocations.FirstOrDefault(c => c.City.Equals(city))!;
                GeoPoint geoLocation = _accountService.GetGeolocation(city);
                string description = GetRandomValueFromList(descriptions);
                string job = _accountService.GetJobFromJacString(jac);
                string company = _accountService.GetCompanyFromJacString(jac);
                Email emailModel = _emailService.GetEmailModel(emailModels);

                Account model = new(
                    accountString, 
                    city,
                    geoLocation,
                    description,
                    job,
                    company, 
                    emailModel);

                if (cityGeolocation != null) 
                    model.CurrentCityGeolocation = cityGeolocation;

                Accounts.Add(model);
                TotalAccounts += 1;
            }

            CurrentAccount = Accounts[0];
            CurrentAccountNumber = 1;
        }



        public string GetRandomValueFromList(List<string> list)
        {
            var random = new Random();
            int index = random.Next(list.Count);
            return list[index];
        }



        void WebDriverDispose()
        {
            if (_chromeDriver != null)
                _chromeDriver.Quit();
        }

        void LogInToEmail()
        {
            WebDriverDispose();

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");;

            _chromeDriver = new(service, options);

            string url = "https://login.live.com/";

            _chromeDriver.Navigate().GoToUrl(url);

            try
            {
                string emailString = CurrentAccount.Email.EmailString!;

                string login = CurrentAccount.Email.Address!;
                string password = emailString[emailString.IndexOf(':')..].Remove(0, 1);

                var wait = new WebDriverWait(_chromeDriver, TimeSpan.FromSeconds(5));

               
                _chromeDriver.FindElement(By.Id("i0116")).SendKeys(login);
               
                _chromeDriver.FindElement(By.Id("idSIButton9")).Click();

                wait.Until(d => d.FindElement(By.Name("passwd"))).SendKeys(password);

                _chromeDriver.FindElement(By.Id("idSIButton9")).Click() ;
                
                _chromeDriver.Navigate().GoToUrl("https://www.microsoft.com/ru-ru/microsoft-365/outlook");

             

                //wait.Until(d => d.FindElement(By.XPath("//*[text()='Вход']"))).Click();
                
                
                

            }

            catch (Exception ex)
            {

            }

        }

        void NextAccount()
        {
            int index = Accounts.IndexOf(CurrentAccount) + 1;
            if (index != Accounts.Count)
            {
                CurrentAccount = Accounts[index];
                CurrentAccountNumber = index + 1;
            }
        }

        void PreviousAccount()
        {
            int index = Accounts.IndexOf(CurrentAccount) - 1;
            if (index >= 0)
            {
                CurrentAccount = Accounts[index];
                CurrentAccountNumber = index + 1;
            }
        }

        void CopyToClipboard()
        {
            Clipboard.SetText(CurrentAccount.Email.EmailString);
        }

        void ShowNewEmailWindow()
        {
            WebDriverDispose();
            NewEmailWindow newEmailWindow = new NewEmailWindow();
            newEmailWindow.DataContext = new NewEmailWindowViewModel(this, newEmailWindow);
            newEmailWindow.ShowDialog();
            if (CurrentAccountNumber == TotalAccounts)
            {
                PreviousAccount();
                NextAccount();
            }
            else
            {
                NextAccount();
                PreviousAccount();
            }
            
        }

        public ICommand LogInToEmailCommand => new RelayCommand(x => LogInToEmail());
        public ICommand CopyToClipboardCommand => new RelayCommand(x => CopyToClipboard());
        public ICommand ShowNewEmailWindowCommand => new RelayCommand(x => ShowNewEmailWindow());
        public ICommand NextAccountCommand => new RelayCommand(x => NextAccount());
        public ICommand PreviousAccountCommand => new RelayCommand(x => PreviousAccount());
    }
}
