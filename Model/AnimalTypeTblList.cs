using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AnimalTypeTblList:List<AnimalTypeTbl>
    {
        public AnimalTypeTblList() { }

        public AnimalTypeTblList(IEnumerable<AnimalTypeTbl> list) : base(list) { }

        public AnimalTypeTblList(IEnumerable<BaseEntity> list) : base(list.Cast<AnimalTypeTbl>().ToList()) { }
    }
}
