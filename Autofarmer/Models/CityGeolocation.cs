﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Models
{
    internal class CityGeolocation
    {
        public string City { get; set; }
        public double MinimalLatitude { get; set; }
        public double MaximalLatitude { get; set; }
        public double MinimalLongitude { get; set; }
        public double MaximalLongitude { get; set; }

        public CityGeolocation(string city, double minLat, double minLong, double maxLat, double maxLong)
        {
            City = city;
            MinimalLatitude = minLat;
            MinimalLongitude = minLong;
            MaximalLatitude = maxLat;
            MaximalLongitude = maxLong;
        }

    }
}
