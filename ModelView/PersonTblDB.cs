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
            p.IsActive = Convert.ToBoolean(reader["isActive"]);
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
            PersonTbl p = entity as PersonTbl;

            if (p != null)
            {
                string sqlStr = "UPDATE PersonTbl SET isActive=@isActive WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@isActive", false));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PersonTbl p = entity as PersonTbl;
            if (p != null)
            {
                string sqlStr = $"Insert INTO PersonTbl (firstName,familyName,tel,city,email,isActive) VALUES (@cFirstName,@cFamilyName,@cTel,@City,@cEmail,@cIsActive)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cFirstName", p.FirstName));
                command.Parameters.Add(new OleDbParameter("@cFamilyName", p.FamilyName));
                command.Parameters.Add(new OleDbParameter("@cTel", p.Tel));
                command.Parameters.Add(new OleDbParameter("@City", p.City.Id));
                command.Parameters.Add(new OleDbParameter("@cEmail", p.Email));
                command.Parameters.Add(new OleDbParameter("@cIsActive", p.IsActive));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PersonTbl p = entity as PersonTbl;
            if (p != null)
            {
                string sqlStr = $"UPDATE PersonTbl SET firstName=@cFirstName, familyName=@cFamilyName, tel=@cTel, city=@City, email=@cEmail, isActive=@cIsActive WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cFirstName", p.FirstName));
                command.Parameters.Add(new OleDbParameter("@cFamilyName", p.FamilyName));
                command.Parameters.Add(new OleDbParameter("@cTel", p.Tel));
                command.Parameters.Add(new OleDbParameter("@City", p.City.Id));
                command.Parameters.Add(new OleDbParameter("@cEmail", p.Email));
                command.Parameters.Add(new OleDbParameter("@cIsActive", p.IsActive));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
