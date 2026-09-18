using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonTblList:List<PersonTbl>
    {
        public PersonTblList() { }

        public PersonTblList(IEnumerable<PersonTbl> list) : base(list) { }

        public PersonTblList(IEnumerable<BaseEntity> list) : base(list.Cast<PersonTbl>().ToList()) { }
    }
}
