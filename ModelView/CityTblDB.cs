using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;


namespace ModelView
{
    public class CityTblDB : BaseDB
    {
        public CityTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM CityTbl";
            CityTblList cityLst = new CityTblList(base.Select());
            return cityLst;
        }

        public override BaseEntity NewEntity()
        {
            return new CityTbl();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            CityTbl c = entity as CityTbl;
            c.CityName = reader["cityName"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        static private CityTblList list = new CityTblList();

        public static CityTbl SelectById(int id)
        {
            CityTblDB db = new CityTblDB();
            list = db.SelectAll();

            CityTbl g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            CityTbl c = entity as CityTbl;
            if(c != null)
            {
                string sqlStr = $"Insert INTO CityTbl (cityName) VALUES (@cName)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CityName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            CityTbl c = entity as CityTbl;
            if(c != null)
            {
                string sqlStr = $"UPDATE CityTbl SET cityName=@cName WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CityName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
