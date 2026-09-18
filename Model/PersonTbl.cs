using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonTbl:BaseEntity
    {
        private string firstName;
        private string familyName;
        private string tel;
        private CityTbl city;
        private string email;

        public string FirstName { get => firstName; set => firstName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string Tel { get => tel; set => tel = value; }
        public CityTbl City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }
    }
}
