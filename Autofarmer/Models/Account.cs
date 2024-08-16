using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Models
{
    internal class Account
    {
        public string? Id { get; set; }
        public string? City { get; set; }
        public CityGeolocation? CurrentCityGeolocation { get; set; }
        public GeoPoint GeoLocation { get; set; }
        public string? Description { get; set; }
        public string? Job { get; set; }
        public string? Company { get; set; }
        public Email Email { get; set; }

        public Account(string id, string city, GeoPoint geoLocation, string description, string job, string company, Email email)
        {
            Id = id;
            City = city;
            GeoLocation = geoLocation;
            Description = description;
            Job = job;
            Company = company;
            Email = email;
        }

        public string FullDescription => $"""
            {City} ❤️
            {Description}
            
            """;
    }
}
