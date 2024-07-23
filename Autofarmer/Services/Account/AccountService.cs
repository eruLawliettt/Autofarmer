using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static QRCoder.PayloadGenerator;



namespace Autofarmer.Services.Account
{
    internal class AccountService : IAccountService
    {
        public string GetCityFromAccountIdString(string accountId)
        {
            var city = accountId[accountId.IndexOf(' ')..];
            city = city[..city.LastIndexOf(' ')].Trim();

            return city;
        }

        public string GetRandomJaCString(Dictionary<string, string> jaCs)
        {
            var random = new Random();
            int index = random.Next(jaCs.Count);

            var jac = jaCs.ElementAt(index);

            return $"{jac.Key} - {jac.Value}";
        }

        public string GetJobFromJacString(string jac) => jac[..jac.IndexOf('-')].Trim();

        public string GetCompanyFromJacString(string jac) => jac[jac.IndexOf('-')..].Replace("-", "").Trim();
        
        
    }
}
