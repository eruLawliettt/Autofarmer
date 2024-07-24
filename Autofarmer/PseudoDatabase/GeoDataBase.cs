using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.PseudoDatabase
{
    internal static class GeoDataBase
    {
        public static CityGeolocation[] CityGeolocations { get; set; }

        static GeoDataBase()
        {
            //649
            CityGeolocations = [
                new CityGeolocation ("Berlin", 52.47943476, 13.31989288, 52.54128466, 13.45207214),
                new CityGeolocation ("Hamburg", 53.54907943, 9.90039825, 53.59331988, 10.0686264),
                new CityGeolocation ("Munich", 48.12118429, 11.52843475, 48.16379550, 11.64104462),
                new CityGeolocation ("Cologne", 50.90714636, 6.91555023, 50.98091165, 7.03983307),
                new CityGeolocation ("Frankfurt am Main", 50.09635771, 8.63697052, 50.13246362, 8.71765137)

            ];
        }
    }
}
