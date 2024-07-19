using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace Autofarmer.ViewModels
{
    internal class MainWindowViewModel
    {
        private string _descriptionsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Descriptions.txt";
        private string _accountsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Accounts.txt";
        private string _JACsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Jobs and Companies.txt";
        private string _modelsFilePath = Path.GetDirectoryName(Environment.ProcessPath) + "/TextFiles/Models.txt";


        public List<string> Descriptions { get; set; } = [];
        public List<string> Accounts { get; set; } = [];
        public Dictionary<string, string> JACs { get; set; } = [];
        public List<string> Models { get; set; } = [];

        public List<AccountInfoModel> AccountInfoModels { get; set; } = [];

        
        public MainWindowViewModel()
        {
            Accounts = GetAccountsFromFile(_accountsFilePath);
            Descriptions = GetDescriptionsFromFile(_descriptionsFilePath);
            JACs = GetJACsFromFile(_JACsFilePath);

            Models = ReadFileByLines(_modelsFilePath);

            AccountInfoModels = GenerateAccountInfos(Accounts);
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
           
            var clean = Regex.Replace(AccountId, models, "", RegexOptions.IgnoreCase);
            clean = Regex.Replace(clean, @"[\d-]", string.Empty).Trim();
            
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
    }
}
