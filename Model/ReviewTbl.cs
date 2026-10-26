using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReviewTbl:BaseEntity
    {
        private OwnerTbl idOwner;
        private string description;
        private int stars;
        private DateTime dateOfComment;

        public OwnerTbl IdOwner { get => idOwner; set => idOwner = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateOfComment { get => dateOfComment; set => dateOfComment = value; }
        public int Stars { get => stars; set => stars = value; }

        public override string ToString()
        {
            return IdOwner.FirstName+" "+ Description+" "+ Stars+ " "+ DateOfComment;
        }
    }
}
