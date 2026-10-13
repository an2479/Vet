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
            PersonTbl p = entity as PersonTbl;
            if (p != null)
            {
                string sqlStr = $"UPDATE PersonTbl SET FirstName=@cFirstName, FamilyName=@cFamilyName, Tel=@cTel, City=@city, Email=@cEmail WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cFirstName", p.FirstName));
                command.Parameters.Add(new OleDbParameter("@cFamilyName", p.FamilyName));
                command.Parameters.Add(new OleDbParameter("@cTel", p.Tel));
                command.Parameters.Add(new OleDbParameter("@City", p.City.Id));//מספר שמזהה את העיר. כי ככה גם באקסס
                command.Parameters.Add(new OleDbParameter("@cEmail", p.Email));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
