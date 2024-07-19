using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Models
{
    internal class AccountInfoModel
    {
        public string? Id { get; set; }
        public string? City { get; set; }
        public string? Description { get; set; }
        public string? Job { get; set; }
        public string? Company { get; set; }

        public AccountInfoModel(string id, string city, string description, string job, string company)
        {
            Id = id;
            City = city;
            Description = description;
            Job = job;
            Company = company;

        }

        public string FullName => $"""
            {Id}

            {City} ❤️
            {Description}
            
            Job: {Job}
            Comp: {Company}
            """;
    }
}
