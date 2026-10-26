using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class QueueTblDB : BaseDB
    {
        public QueueTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM QueueTbl";
            QueueTblList qLst = new QueueTblList(base.Select());
            return qLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            QueueTbl q = entity as QueueTbl;
            q.IdDoctor = DoctorTblDB.SelectById((int)reader["idDoctor"]);
            q.IdOwnersAnimal = OwnersAnimalTblDB.SelectById((int)reader["id"]);
            q.IssueOrDisease = DiseaseOrIssuesTblDB.SelectById((int)reader["id"]);
            q.QueueDate = Convert.ToDateTime(reader["queueDate"]);
            q.QueueHour = reader["queueHour"].ToString();
            q.Report = reader["report"].ToString();
            base.CreateModel(entity);
            return q;
        }

        public override BaseEntity NewEntity()
        {
            return new QueueTbl();
        }

        static private QueueTblList list = new QueueTblList();

        public static QueueTbl SelectById(int id)
        {
            QueueTblDB db = new QueueTblDB();
            list = db.SelectAll();

            QueueTbl g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            QueueTbl q = entity as QueueTbl;
            if (q != null)
            {
                string sqlStr = $"UPDATE QueueTbl SET idDoctor=@cIdDoctor, idOwnersAnimal=@cIdOwnersAnimal, issueOrDisease=@cIssueOrDisease, queueDate=@cQueueDate, queueHour=@cQueueHour, report=@cReport WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cIdDoctor", q.IdDoctor.Id));
                command.Parameters.Add(new OleDbParameter("@cIdOwnersAnimal", q.IdOwnersAnimal.Id));
                command.Parameters.Add(new OleDbParameter("@cIssueOrDisease", q.IssueOrDisease.Id));
                command.Parameters.Add(new OleDbParameter("@cQueueDate", q.QueueDate));
                command.Parameters.Add(new OleDbParameter("@cQueueHour", q.QueueHour));
                command.Parameters.Add(new OleDbParameter("@cReport", q.Report));
                command.Parameters.Add(new OleDbParameter("@id", q.Id));
            }
        }
    }
}
