﻿using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Services.Account
{
    internal interface IAccountService
    {
        public GeoPoint GetGeolocation(string city);
        public string GetCityFromAccountIdString(string accountId);
        public string GetRandomJaCString(Dictionary<string, string> jaCs);
        public string GetJobFromJacString(string jac);
        public string GetCompanyFromJacString(string jac);

        

    }
}
