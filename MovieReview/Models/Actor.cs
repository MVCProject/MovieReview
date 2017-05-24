using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class Actor
    {
        public virtual int ActorID { get; set; }
        public virtual string ActorName { get; set; }
        public virtual string Bio { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string PlaceOfBirth { get; set; }
    }
}