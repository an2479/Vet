using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ShiftsTbl:BaseEntity
    {
        private DoctorTbl idDoctor;
        private DateTime shiftDate;
        private string startTime;
        private string endTime;

        public DoctorTbl IdDoctor { get => idDoctor; set => idDoctor = value; }
        public DateTime ShiftDate { get => shiftDate; set => shiftDate = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        
    }
}
