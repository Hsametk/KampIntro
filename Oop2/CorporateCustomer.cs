using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //Kurumsal,Tüzel müşteri
    //miras inheritance
    internal class CorporateCustomer : Customer
    {
        
        public string CompanyName { get; set; } 
        public string TaxNumber { get; set; }
    }
}
