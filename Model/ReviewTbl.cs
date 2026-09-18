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
        private string stars;
        private DateTime dateOfComment;

        public OwnerTbl IdOwner { get => idOwner; set => idOwner = value; }
        public string Description { get => description; set => description = value; }
        public string Stars { get => stars; set => stars = value; }
        public DateTime DateOfComment { get => dateOfComment; set => dateOfComment = value; }
    }
}
