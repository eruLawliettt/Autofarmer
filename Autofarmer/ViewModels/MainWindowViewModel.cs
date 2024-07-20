﻿using Autofarmer.Models;
using QRCoder;
using QRCoder.Xaml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using ZXing.QrCode.Internal;

namespace Autofarmer.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _descriptionsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Descriptions.txt";
        private string _accountsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Accounts.txt";
        private string _JACsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Jobs and Companies.txt";
        private string _modelsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Models.txt";

        private AccountInfoModel _currentAccount;
        private int _currentAccountNumber;
        private DrawingImage _emailQRCode;

        public List<string> Descriptions { get; set; } = [];
        public List<string> Accounts { get; set; } = [];
        public Dictionary<string, string> JACs { get; set; } = [];
        public List<string> Models { get; set; } = [];

        public List<AccountInfoModel> AccountInfoModels { get; set; } = [];

        public AccountInfoModel CurrentAccount
        {
            get { return _currentAccount; }
            set => Set(ref _currentAccount, value, nameof(CurrentAccount));
        }

        public int CurrentAccountNumber
        {
            get { return _currentAccountNumber; }
            set => Set(ref _currentAccountNumber, value, nameof(CurrentAccountNumber));
        }

        public DrawingImage EmailQRCode
        {
            get { return _emailQRCode; }
            set => Set(ref _emailQRCode, value, nameof(EmailQRCode));
        }


        public MainWindowViewModel()
        {
            Accounts = GetAccountsFromFile(_accountsFilePath);
            Descriptions = GetDescriptionsFromFile(_descriptionsFilePath);
            JACs = GetJACsFromFile(_JACsFilePath);

            Models = ReadFileByLines(_modelsFilePath);

            AccountInfoModels = GenerateAccountInfos(Accounts);

            CurrentAccount = AccountInfoModels[0];
            CurrentAccountNumber = 1;

            EmailQRCode = GenerateQR("gaywebsite.com");
        }

        private List<AccountInfoModel> GenerateAccountInfos(List<string> accounts)
        {
            List<AccountInfoModel> accountInfoModels = [];

            foreach (var account in accounts)
            {
                string jac = GetRandomJaC(JACs);
                AccountInfoModel model = new(account, GetCityFromAccountIdString(account), 
                    GetRandomValueFromList(Descriptions), GetJobFromJac(jac), GetCompanyFromJac(jac));

                accountInfoModels.Add(model);
            }

            return accountInfoModels;
        }
        private string GetCityFromAccountIdString(string AccountId)
        {
            string models = string.Join("|", [.. Models]);
            char[] nums = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];

            var clean = Regex.Replace(AccountId, models, "", RegexOptions.IgnoreCase);
            clean = new string(clean.Where(c => !nums.Contains(c)).ToArray()).Trim();
            
            return clean;
        }
        private string GetRandomValueFromList(List<string> list)
        {
            var random = new Random();
            int index = random.Next(list.Count);
            return list[index];
        }
        private string GetRandomJaC(Dictionary<string,string> dict)
        {
            var random = new Random();
            int index = random.Next(dict.Count);

            var jac = dict.ElementAt(index);

            return $"{jac.Key} - {jac.Value}";
        }
        private string GetJobFromJac(string jac) => jac[..jac.IndexOf('-')].Trim();
        private string GetCompanyFromJac(string jac) => jac[jac.IndexOf('-')..].Replace("-", "").Trim();
        private Dictionary<string, string> GetJACsFromFile(string filePath)
        {
            List<string> jacList = ReadFileByLines(_JACsFilePath);
            Dictionary<string, string> JACPairs = [];

            foreach (string jac in jacList)
            {
                var item = jac.Split('-');
                JACPairs.Add(item[0], item[1]);
            }

            return JACPairs;
        }
        private List<string> GetAccountsFromFile(string filePath) => ReadFileByLines(filePath);
        private List<string> GetDescriptionsFromFile(string filePath) => ReadFileByLines(filePath);
        private List<string> ReadFileByLines(string filePath)
        {
            const Int32 BufferSize = 512;

            using var fileStream = File.OpenRead(filePath);
            using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);

            bool IsProcessing = true;
            string line;
            List<string> list = [];

            while (IsProcessing)
            {
                line = streamReader.ReadLine();

                if (line != null)
                {
                    if (line == String.Empty || line == " ")
                        continue;
                    list.Add(line);
                }

                else
                    IsProcessing = false;
            }

            return list;
        }


        DrawingImage GenerateQR(string value)
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            XamlQRCode qrCode = new XamlQRCode(qrCodeData);
            DrawingImage qrCodeAsXaml = qrCode.GetGraphic(20);
            return qrCodeAsXaml;

        }

        void NextAccount()
        {
            int index = AccountInfoModels.IndexOf(CurrentAccount) + 1;
            if (index != AccountInfoModels.Count)
            {
                CurrentAccount = AccountInfoModels[index];
                CurrentAccountNumber = index + 1;
            }
                
            else
                MessageBox.Show("Аккаунт последний");
        }
        void PreviousAccount()
        {
            int index = AccountInfoModels.IndexOf(CurrentAccount) - 1;
            if (index >= 0)
            {
                CurrentAccount = AccountInfoModels[index];
                CurrentAccountNumber = index + 1;
            }
            else
                MessageBox.Show("Предыдущего аккаунта нет");

        }

        public ICommand NextAccountCommand => new RelayCommand(x => NextAccount());
        public ICommand PreviousAccountCommand => new RelayCommand(x => PreviousAccount());
    }
}
