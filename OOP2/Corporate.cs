using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance - miras
    // Tüzel Müşteri bir müşteridir anlamına gelir.
    class Corporate:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
