using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QueueTblList:List<QueueTbl>
    {
        public QueueTblList() { }

        public QueueTblList(IEnumerable<QueueTbl> list) : base(list) { }

        public QueueTblList(IEnumerable<BaseEntity> list) : base(list.Cast<QueueTbl>().ToList()) { }
    }
}
