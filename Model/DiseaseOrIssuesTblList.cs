using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiseaseOrIssuesTblList:List<DiseaseOrIssuesTbl>
    {
        public DiseaseOrIssuesTblList() { }

        public DiseaseOrIssuesTblList(IEnumerable<DiseaseOrIssuesTbl> list) : base(list) { }

        public DiseaseOrIssuesTblList(IEnumerable<BaseEntity> list) : base(list.Cast<DiseaseOrIssuesTbl>().ToList()) { }
    }
}
