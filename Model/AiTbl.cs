using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AiTbl:BaseEntity
    {
        private PersonTbl idPerson;
        private DateTime promptTime;
        private string message;
        private string response;

        public PersonTbl IdPerson { get => idPerson; set => idPerson = value; }
        public DateTime PromptTime { get => promptTime; set => promptTime = value; }
        public string Message { get => message; set => message = value; }
        public string Response { get => response; set => response = value; }
    }
}
