using Autofarmer.Models;
using Autofarmer.PseudoDatabase;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public GeoPoint GetGeolocation(string city)
        {
            var cityGeolocation = GeoDataBase.CityGeolocations.FirstOrDefault(x => x.City == city);

            if (cityGeolocation == null)
                return new GeoPoint(0, 0);

            else
            {
                var random = new Random();
                double latitude = random.NextDouble() * (cityGeolocation.MaximalLatitude - cityGeolocation.MinimalLatitude) + cityGeolocation.MinimalLatitude;
                double longitude = random.NextDouble() * (cityGeolocation.MaximalLongitude - cityGeolocation.MinimalLongitude) + cityGeolocation.MinimalLongitude;

                return new GeoPoint(Math.Round(latitude, 8), Math.Round(longitude, 8));
            }
        }

        public string GetCityFromAccountIdString(string accountId)
        {
            accountId = accountId.Trim();
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
