using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class DiseaseOrIssuesTblDB : BaseDB
    {
        public DiseaseOrIssuesTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM DiseaseOrIssuesTbl";
            DiseaseOrIssuesTblList diseaseOrIssuesLst = new DiseaseOrIssuesTblList(base.Select());
            return diseaseOrIssuesLst;
        }

        public override BaseEntity NewEntity()
        {
            return new DiseaseOrIssuesTbl();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            DiseaseOrIssuesTbl c = entity as DiseaseOrIssuesTbl;
            c.Disease = reader["disease"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        static private DiseaseOrIssuesTblList list = new DiseaseOrIssuesTblList();

        public static DiseaseOrIssuesTbl SelectById(int id)
        {
            DiseaseOrIssuesTblDB db = new DiseaseOrIssuesTblDB();
            list = db.SelectAll();

            DiseaseOrIssuesTbl g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
