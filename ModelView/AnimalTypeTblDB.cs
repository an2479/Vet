using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class AnimalTypeTblDB : BaseDB
    {
        public AnimalTypeTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AnimalTypeTbl";
            AnimalTypeTblList animalTypeLst = new AnimalTypeTblList(base.Select());
            return animalTypeLst;
        }

        public override BaseEntity NewEntity()
        {
            return new AnimalTypeTbl();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AnimalTypeTbl c = entity as AnimalTypeTbl;
            c.Type = reader["type"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        static private AnimalTypeTblList list = new AnimalTypeTblList();

        public static AnimalTypeTbl SelectById(int id)
        {
            AnimalTypeTblDB db = new AnimalTypeTblDB();
            AnimalTypeTblList list = db.SelectAll();

            AnimalTypeTbl g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
