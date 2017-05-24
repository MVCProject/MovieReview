using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class Director
    {
        public virtual int DirectorID { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual string Bio { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual string POB { get; set; }
    }
}