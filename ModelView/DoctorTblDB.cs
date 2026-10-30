using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class DoctorTblDB : PersonTblDB
    {

        public DoctorTblList SelectAll()
        {
            command.CommandText = $" SELECT  PersonTbl.id, PersonTbl.email, PersonTbl.city, PersonTbl.tel, PersonTbl.familyName, PersonTbl.firstName" +
                                  $" FROM (PersonTbl INNER JOIN" +
                                  $" DoctorTbl ON PersonTbl.id = DoctorTbl.id)";
            DoctorTblList pLst = new DoctorTblList(base.Select());
            return pLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            DoctorTbl d = entity as DoctorTbl;
            base.CreateModel(entity);
            return d;
        }

        public override BaseEntity NewEntity()
        {
            return new DoctorTbl();
        }

        static private DoctorTblList list = new DoctorTblList();

        public static DoctorTbl SelectById(int id)
        {
            DoctorTblDB db = new DoctorTblDB();
            list = db.SelectAll();

            DoctorTbl g = list.Find(item => item.Id == id);
            return g;
        }

        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DoctorTbl d = entity as DoctorTbl;
            if (d != null)
            {
                string sqlStr = $"Insert INTO DoctorTbl (id) VALUES (@cId)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cId", d.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            DoctorTbl doc = entity as DoctorTbl;
            if (doc != null)
            {
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
        
    }
}
