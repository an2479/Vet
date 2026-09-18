using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AnimalTblList:List<AnimalTbl>
    {
        public AnimalTblList() { }

        public AnimalTblList(IEnumerable<AnimalTbl> list) : base(list) { }

        public AnimalTblList(IEnumerable<BaseEntity> list) : base(list.Cast<AnimalTbl>().ToList()) { }
    }
}
