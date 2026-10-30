using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class AiTblDB : BaseDB
    {
        public AiTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AiTbl";
            AiTblList aLst = new AiTblList(base.Select());
            return aLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AiTbl a = entity as AiTbl;
            a.IdPerson = PersonTblDB.SelectById((int)reader["idPerson"]);
            a.PromptTime = Convert.ToDateTime(reader["promptTime"]);
            a.Message = reader["message"].ToString();
            a.Response = reader["response"].ToString();
            base.CreateModel(entity);
            return a;
        }

        public override BaseEntity NewEntity()
        {
            return new AiTbl();
        }

        static private AiTblList list = new AiTblList();

        public static AiTbl SelectById(int id)
        {
            AiTblDB db = new AiTblDB();
            list = db.SelectAll();

            AiTbl g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AiTbl a = entity as AiTbl;
            if (a != null)
            {
                string sqlStr = $"Insert INTO AiTbl (idPerson,promptTime,message,response) VALUES (@cIdPerson,@cPromptTime,@cMessage,@cResponse)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cIdPerson", a.IdPerson.Id));
                command.Parameters.Add(new OleDbParameter("@cPromptTime", a.PromptTime));
                command.Parameters.Add(new OleDbParameter("@cMessage", a.Message));
                command.Parameters.Add(new OleDbParameter("@cResponse", a.Response));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AiTbl a = entity as AiTbl;
            if (a != null)
            {
                string sqlStr = $"UPDATE AiTbl SET idPerson=@cIdPerson, promptTime=@cPromptTime, message=@cMessage, response=@cResponse WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cIdPerson", a.IdPerson.Id));
                command.Parameters.Add(new OleDbParameter("@cPromptTime", a.PromptTime));
                command.Parameters.Add(new OleDbParameter("@cMessage", a.Message));
                command.Parameters.Add(new OleDbParameter("@cResponse", a.Response));
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
    }
}
