using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityID { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Address2))
                return $"{Address1}, {PostalCode}";

            return $"{Address1}, {Address2}, {PostalCode}";
        }
    }
}
