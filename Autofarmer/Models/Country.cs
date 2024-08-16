using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Models
{
    internal class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FlagSource { get; set; }


        public Country(int id, string name)
        {
            Id = id;
            Name = name;
            FlagSource = null;
        }

    }
}
