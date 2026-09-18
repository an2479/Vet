using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OwnersAnimalTbl:BaseEntity
    {
        private OwnerTbl owner;
        private AnimalTbl animal;

        public OwnerTbl Owner { get => owner; set => owner = value; }
        public AnimalTbl Animal { get => animal; set => animal = value; }
    }
}
