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
    }
}
