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
    }
}
