using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ShiftsTblList:List<ShiftsTbl>
    {
        public ShiftsTblList() { }

        public ShiftsTblList(IEnumerable<ShiftsTbl> list) : base(list) { }

        public ShiftsTblList(IEnumerable<BaseEntity> list) : base(list.Cast<ShiftsTbl>().ToList()) { }
    }
}
