using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class ReviewTblDB : BaseDB
    {
        public ReviewTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ReviewTbl";
            ReviewTblList rLst = new ReviewTblList(base.Select());
            return rLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ReviewTbl r = entity as ReviewTbl;
            r.IdOwner = OwnerTblDB.SelectById((int)reader["idOwner"]);
            r.Description = reader["description"].ToString();
            r.Stars = reader["stars"].ToString();
            r.DateOfComment = Convert.ToDateTime(reader["dateOfComment"].ToString());
            base.CreateModel(entity);
            return r;
        }

        public override BaseEntity NewEntity()
        {
            return new ReviewTbl();
        }

        static private ReviewTblList list = new ReviewTblList();

        public static ReviewTbl SelectById(int id)
        {
            ReviewTblDB db = new ReviewTblDB();
            list = db.SelectAll();

            ReviewTbl g = list.Find(item => item.Id == id);
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
            throw new NotImplementedException();
        }
    }
}
