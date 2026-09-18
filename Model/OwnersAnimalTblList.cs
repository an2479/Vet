using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OwnersAnimalTblList:List<OwnersAnimalTbl>
    {
        public OwnersAnimalTblList() { }

        public OwnersAnimalTblList(IEnumerable<OwnersAnimalTbl> list) : base(list) { }

        public OwnersAnimalTblList(IEnumerable<BaseEntity> list) : base(list.Cast<OwnersAnimalTbl>().ToList()) { }
    }
}
