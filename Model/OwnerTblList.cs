using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OwnerTblList:List<OwnerTbl>
    {
        public OwnerTblList() { }

        public OwnerTblList(IEnumerable<OwnerTbl> list) : base(list) { }

        public OwnerTblList(IEnumerable<BaseEntity> list) : base(list.Cast<OwnerTbl>().ToList()) { }
    }
}
