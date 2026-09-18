using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReviewTblList: List<ReviewTbl>
    {
        public ReviewTblList() { }

        public ReviewTblList(IEnumerable<ReviewTbl> list) : base(list) { }

        public ReviewTblList(IEnumerable<BaseEntity> list) : base(list.Cast<ReviewTbl>().ToList()) { }
    }
}
