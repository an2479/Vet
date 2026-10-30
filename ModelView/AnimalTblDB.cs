using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class AnimalTblDB : BaseDB 
    {
        public AnimalTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AnimalTbl";
            AnimalTblList aLst = new AnimalTblList(base.Select());
            return aLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AnimalTbl a = entity as AnimalTbl;
            a.AnimalType = AnimalTypeTblDB.SelectById((int)reader["animalType"]);
            a.BirthDate = Convert.ToDateTime(reader["birthDate"]);
            base.CreateModel(entity);
            return a;
        }

        public override BaseEntity NewEntity()
        {
            return new AnimalTbl();
        }

        static private AnimalTblList list = new AnimalTblList();

        public static AnimalTbl SelectById(int id)
        {
            AnimalTblDB db = new AnimalTblDB();
            list = db.SelectAll();

            AnimalTbl g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AnimalTbl a = entity as AnimalTbl;
            if (a != null)
            {
                string sqlStr = $"Insert INTO AnimalTbl (animalType,birthDate) VALUES (@cAnimalType,@birthDate)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cAnimalType", a.AnimalType.Id));
                command.Parameters.Add(new OleDbParameter("@birthDate", a.BirthDate));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AnimalTbl a = entity as AnimalTbl;
            if (a != null)
            {
                string sqlStr = $"UPDATE AnimalTbl SET animalType=@cAnimalType, birthDate=@birthDate WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cAnimalType", a.AnimalType.Id));
                command.Parameters.Add(new OleDbParameter("@cBirthDate", a.BirthDate));
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
    }
}
