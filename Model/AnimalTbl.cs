using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AnimalTbl:BaseEntity
    {
        private AnimalTypeTbl animalType;
        private DateTime birthDate;

        public AnimalTypeTbl AnimalType { get => animalType; set => animalType = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
