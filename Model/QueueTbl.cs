using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QueueTbl:BaseEntity
    {
        private DoctorTbl idDoctor;
        private OwnerTbl idOwnersAnimal;
        private DiseaseOrIssuesTbl issueOrDisease;
        private DateTime queueDate;
        private string queueHour;
        private string report;

        public DoctorTbl IdDoctor { get => idDoctor; set => idDoctor = value; }
        public OwnerTbl IdOwnersAnimal { get => idOwnersAnimal; set => idOwnersAnimal = value; }
        public DiseaseOrIssuesTbl IssueOrDisease { get => issueOrDisease; set => issueOrDisease = value; }
        public DateTime QueueDate { get => queueDate; set => queueDate = value; }
        public string QueueHour { get => queueHour; set => queueHour = value; }
        public string Report { get => report; set => report = value; }
    }
}
