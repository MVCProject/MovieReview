using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MovieReview.Models
{
    public class Movies
    {
        [Key]
        public virtual int MoviesID { get; set; }

        public virtual string MovieName { get; set; }

        public virtual string MovieBio { get; set; }

        public virtual int Rating { get; set; }

        public virtual DateTime ReleaseDate { get; set; }

        [ForeignKey("DirectorsID")]
        public Director Director { get; set; }
        public virtual int DirectorsID { get; set; }

        public virtual string Status { get; set; }

        public virtual string Country { get; set; }

        public virtual string Language { get; set; }

    }
}