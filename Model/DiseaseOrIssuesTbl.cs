using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiseaseOrIssuesTbl:BaseEntity
    {
        private string disease;

        public string Disease { get => disease; set => disease = value; }
    }
}
