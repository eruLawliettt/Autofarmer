﻿using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Autofarmer.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _descriptionsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Descriptions.txt";
        private string _accountsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Accounts.txt";
        private string _JACsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Jobs and Companies.txt";
        private string _modelsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Models.txt";

        private AccountInfoModel _currentAccount;

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

        public MainWindowViewModel()
        {
            Accounts = GetAccountsFromFile(_accountsFilePath);
            Descriptions = GetDescriptionsFromFile(_descriptionsFilePath);
            JACs = GetJACsFromFile(_JACsFilePath);

            Models = ReadFileByLines(_modelsFilePath);

            AccountInfoModels = GenerateAccountInfos(Accounts);

            CurrentAccount = AccountInfoModels[0];
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



        void NextAccount()
        {
            int index = AccountInfoModels.IndexOf(CurrentAccount) + 1;
            if (index != AccountInfoModels.Count)
                CurrentAccount = AccountInfoModels[index];
            else
                MessageBox.Show("Аккаунт последний");
        }

        void PreviousAccount()
        {
            int index = AccountInfoModels.IndexOf(CurrentAccount) - 1;
            if (index >= 0)
                CurrentAccount = AccountInfoModels[index];
            else
                MessageBox.Show("Предыдущего аккаунта нет");

        }



        public ICommand NextAccountCommand => new RelayCommand(x => NextAccount());
        public ICommand PreviousAccountCommand => new RelayCommand(x => PreviousAccount());
    }
}
