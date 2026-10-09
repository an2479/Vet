using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class PersonTblDB : BaseDB
    {
        public PersonTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM PersonTbl";
            PersonTblList pLst = new PersonTblList(base.Select());
            return pLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            PersonTbl p = entity as PersonTbl;
            p.FirstName = reader["firstName"].ToString();
            p.FamilyName = reader["familyName"].ToString();
            p.Tel = reader["tel"].ToString();
            p.City = CityTblDB.SelectById((int)reader["city"]);
            p.Email = reader["email"].ToString();
            base.CreateModel(entity);
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new PersonTbl();
        }

        static private PersonTblList list = new PersonTblList();

        public static PersonTbl SelectById(int id)
        {
            PersonTblDB db = new PersonTblDB();
            list = db.SelectAll();

            PersonTbl g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
