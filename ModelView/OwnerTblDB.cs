using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;
using System.Reflection;

namespace ModelView
{
    public class OwnerTblDB : PersonTblDB
    {
        public OwnerTblList SelectAll()
        {
            command.CommandText = $" SELECT PersonTbl.id, PersonTbl.firstName, PersonTbl.familyName, PersonTbl.tel, PersonTbl.email, PersonTbl.city" +
                                  $" FROM (OwnerTbl INNER JOIN" +
                                  $" PersonTbl ON OwnerTbl.id = PersonTbl.id)";

            OwnerTblList oLst = new OwnerTblList(base.Select());
            return oLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            OwnerTbl o = entity as OwnerTbl;
            base.CreateModel(entity);
            return o;
        }

        public override BaseEntity NewEntity()
        {
            return new OwnerTbl();
        }

        static private OwnerTblList list = new OwnerTblList();

        public static OwnerTbl SelectById(int id)
        {
            OwnerTblDB db = new OwnerTblDB();
            list = db.SelectAll();

            OwnerTbl g = list.Find(item => item.Id == id);
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
            OwnerTbl o = entity as OwnerTbl;
            if (o != null)
            {
                string sqlStr = $"Insert INTO OwnerTbl (id) VALUES (@cId)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cId", o.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            OwnerTbl owner = entity as OwnerTbl;
            if (owner != null)
            {
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}
