using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek_Management.Database.Model
{
    public abstract class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Fin { get; set; }
        public User(string name ,string lastname,string fin)
        {
            Name = name;
            LastName = lastname;
            Fin = fin;
        }

    }
}
