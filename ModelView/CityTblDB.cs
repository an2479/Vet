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

    }
}
