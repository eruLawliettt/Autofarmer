using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Services.Account
{
    internal interface IAccountService
    {
        public string GetCityFromAccountIdString(string accountId, List<string> namesToCut);
        public string GetRandomJaCString(Dictionary<string, string> jaCs);
        public string GetJobFromJacString(string jac);
        public string GetCompanyFromJacString(string jac);

    }
}
