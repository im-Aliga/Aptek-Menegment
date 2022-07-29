using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek_Management.Database.Model
{
    public  class Drugist : User 
    {

        public string Education { get; set; }
        public string Experice { get; set; }
        public Drugist(string name,string lastname,string fin,string education,string experice)
            :base(name,lastname, fin)
        {
            Education = education;
            Experice = experice;


        }
    }
}
