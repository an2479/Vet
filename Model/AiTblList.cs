using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AiTblList:List<AiTbl>
    {
        public AiTblList() { }

        public AiTblList(IEnumerable<AiTbl> list) : base(list) { }

        public AiTblList(IEnumerable<BaseEntity> list) : base(list.Cast<AiTbl>().ToList()) { }
    }
}
