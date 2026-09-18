using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AnimalTypeTbl:BaseEntity
    {
        private string type;

        public string Type { get => type; set => type = value; }
    }
}
