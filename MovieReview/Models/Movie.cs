using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class Movie
    {
        public virtual int MovieID { get; set; }

        public virtual string MovieName { get; set; }

        public virtual string MovieBio { get; set; }

        public virtual int Rating { get; set; }

        public virtual DateTime ReleaseDate { get; set; }

        [ForeignKey("DirectorID")]
        public Director Director { get; set; }
        public virtual int DirectorID { get; set; }

        public virtual string Status { get; set; }

        public virtual string Country { get; set; }

        public virtual string Language { get; set; }

    }
}