using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class ShiftsTblDB : BaseDB
    {
        public ShiftsTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ShiftsTbl";
            ShiftsTblList sLst = new ShiftsTblList(base.Select());
            return sLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ShiftsTbl s = entity as ShiftsTbl;
            s.IdDoctor = DoctorTblDB.SelectById((int)reader["idDoctor"]);
            s.ShiftDate = Convert.ToDateTime(reader["shiftDate"].ToString());
            s.StartTime = reader["startTime"].ToString();
            s.EndTime = reader["endTime"].ToString();
            base.CreateModel(entity);
            return s;
        }

        public override BaseEntity NewEntity()
        {
            return new ShiftsTbl();
        }

        //static private ShiftsTblList list = new ShiftsTblList();

        //public static ShiftsTbl SelectById(int id)
        //{
        //    ShiftsTblDB db = new ShiftsTblDB();
        //    list = db.SelectAll();

        //    ShiftsTbl g = list.Find(item => item.Id == id);
        //    return g;
        //}

    }
}
