using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DoctorTblList:List<DoctorTbl>
    {
        public DoctorTblList() { }

        public DoctorTblList(IEnumerable<DoctorTbl> list) : base(list) { }

        public DoctorTblList(IEnumerable<BaseEntity> list) : base(list.Cast<DoctorTbl>().ToList()) { }
    }
}
