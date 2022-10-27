using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_3
{
    public class Personel
    {
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string Email
        {
            get
            {
                return $"{Name.ToLower()}.{SurName.ToLower()}@{CompanyName.ToLower()}.com";
            }

        }
    }
}
