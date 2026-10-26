using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class OwnersAnimalTblDB : BaseDB
    {
        public OwnersAnimalTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM OwnersAnimalTbl";
            OwnersAnimalTblList oaLst = new OwnersAnimalTblList(base.Select());
            return oaLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            OwnersAnimalTbl oa = entity as OwnersAnimalTbl;
            oa.Owner = OwnerTblDB.SelectById((int)reader["owner"]);
            oa.Animal = AnimalTblDB.SelectById((int)reader["animal"]);
            base.CreateModel(entity);
            return oa;
        }

        public override BaseEntity NewEntity()
        {
            return new OwnersAnimalTbl();
        }

        static private OwnersAnimalTblList list = new OwnersAnimalTblList();

        public static OwnersAnimalTbl SelectById(int id)
        {
            OwnersAnimalTblDB db = new OwnersAnimalTblDB();
            list = db.SelectAll();

            OwnersAnimalTbl g = list.Find(item => item.Id == id);
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
            OwnersAnimalTbl a = entity as OwnersAnimalTbl;
            if (a != null)
            {
                string sqlStr = $"UPDATE OwnersAnimalTbl SET owner=@cOwner, animal=@cAnimal WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cOwner", a.Owner.Id));
                command.Parameters.Add(new OleDbParameter("@cAnimal", a.Animal.Id));
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
    }
}
