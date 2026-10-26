using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ModelView
{
    public class ReviewTblDB : BaseDB
    {
        public ReviewTblList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ReviewTbl";
            ReviewTblList rLst = new ReviewTblList(base.Select());
            return rLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ReviewTbl r = entity as ReviewTbl;
            r.IdOwner = OwnerTblDB.SelectById((int)reader["idOwner"]);
            r.Description = reader["description"].ToString();
            r.Stars = (int)reader["stars"];
            r.DateOfComment = (DateTime)(reader["dateOfComment"]);
            base.CreateModel(entity);
            return r;
        }

        public override BaseEntity NewEntity()
        {
            return new ReviewTbl();
        }

        static private ReviewTblList list = new ReviewTblList();

        public static ReviewTbl SelectById(int id)
        {
            ReviewTblDB db = new ReviewTblDB();
            list = db.SelectAll();

            ReviewTbl g = list.Find(item => item.Id == id);
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

        //protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    //throw new NotImplementedException();
        //    ReviewTbl r = entity as ReviewTbl;
        //    if (r != null)
        //    {
        //        string sqlStr = $"UPDATE Review SET id_Owner=@cIdOwner, description=@cDescription, stars=@cStars, dateOfComment=@cDateOfComment " +
        //                        $" WHERE ID=@id";
        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cIdOwner", r.IdOwner.Id));
        //        command.Parameters.Add(new OleDbParameter("@cDescription", r.Description));
        //        command.Parameters.Add(new OleDbParameter("@cStars", r.Stars));
        //        command.Parameters.Add(new OleDbParameter("@cDateOfComment", r.DateOfComment));
        //        command.Parameters.Add(new OleDbParameter("@id", r.Id));
        //    }
        //}
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ReviewTbl r = entity as ReviewTbl;

            if (r != null)
            {
                string sqlStr = $"UPDATE ReviewTbl " +
                                $"SET [idOwner] = @cIdOwner, [description] = @cDescription, [stars] = @cStars, dateOfComment=@cDateOfComment " +
                                $"WHERE [id] = @id";



                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@cIdOwner", r.IdOwner.Id));
                command.Parameters.Add(new OleDbParameter("@cDescription", r.Description));
                command.Parameters.Add(new OleDbParameter("@cStars", r.Stars));
                command.Parameters.Add(new OleDbParameter("@cDateOfComment", r.DateOfComment));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
    }
}
