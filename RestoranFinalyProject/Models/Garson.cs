using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranFinalyProject.Models
{
    public class Garson
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Password { get; set; }
        public Garson(string? name, string? surname, string? password)
        {
            Name = name;
            Password = password;
            Surname = surname;
        }
        public Garson()
        {

        }
        public override string ToString() => @$"{Name}       {Surname}";
    }
}
