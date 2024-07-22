using Autofarmer.Models;
using Autofarmer.Services.Account;
using Autofarmer.Services.Email;
using Autofarmer.Services.FilesHandling;
using Autofarmer.Views;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Autofarmer.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly string _descriptionsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Descriptions.txt";
        private readonly string _accountsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Accounts.txt";
        private readonly string _JACsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Jobs and Companies.txt";
        private readonly string _emailsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Emails.txt";
        private readonly string _modelsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Models.txt";

        private readonly FileService _fileService = new();
        private readonly EmailService _emailService = new();
        private readonly AccountService _accountService = new();

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

            List<string> namesToCut = _fileService.ReadFileByLines(_modelsFilePath);

            foreach (var accountString in accountStrings)
            {
                string jac = _accountService.GetRandomJaCString(jacs);
                Email emailModel = _emailService.GetEmailModel(emailModels);

                Account model = new(
                    accountString, 
                    _accountService.GetCityFromAccountIdString(accountString, namesToCut),
                    GetRandomValueFromList(descriptions), 
                    _accountService.GetJobFromJacString(jac), 
                    _accountService.GetCompanyFromJacString(jac), 
                    emailModel);

                Accounts.Add(model);
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

        void NextAccount()
        {
            int index = Accounts.IndexOf(CurrentAccount) + 1;
            if (index != Accounts.Count)
            {
                CurrentAccount = Accounts[index];
                CurrentAccountNumber = index + 1;
            }

            else
                MessageBox.Show("Аккаунт последний");
        }
        void PreviousAccount()
        {
            int index = Accounts.IndexOf(CurrentAccount) - 1;
            if (index >= 0)
            {
                CurrentAccount = Accounts[index];
                CurrentAccountNumber = index + 1;
            }
            else
                MessageBox.Show("Предыдущего аккаунта нет");

        }
        void CopyToClipboard()
        {
            Clipboard.SetText(CurrentAccount.Email.FullEmailString);
        }

        void ShowNewEmailWindow()
        {
            NewEmailWindow newEmailWindow = new NewEmailWindow();
            newEmailWindow.DataContext = new NewEmailWindowViewModel(this);
            newEmailWindow.ShowDialog();
            NextAccount();
            PreviousAccount();
        }


        public ICommand CopyToClipboardCommand => new RelayCommand(x => CopyToClipboard());
        public ICommand ShowNewEmailWindowCommand => new RelayCommand(x => ShowNewEmailWindow());
        public ICommand NextAccountCommand => new RelayCommand(x => NextAccount());
        public ICommand PreviousAccountCommand => new RelayCommand(x => PreviousAccount());
    }
}
