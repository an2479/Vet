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
            ShiftsTbl s = entity as ShiftsTbl;
            if (s != null)
            {
                string sqlStr = $"UPDATE ShiftsTbl SET idDoctor=@cIdDoctor, shiftDate=@cShiftDate, startTime=@cStartTime, endTime=@cEndTime WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cIdDoctor", s.IdDoctor.Id));
                command.Parameters.Add(new OleDbParameter("@cShiftDate", s.ShiftDate));
                command.Parameters.Add(new OleDbParameter("@cStartTime", s.StartTime));
                command.Parameters.Add(new OleDbParameter("@cEndTime", s.EndTime));
                command.Parameters.Add(new OleDbParameter("@id", s.Id));
            }
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
