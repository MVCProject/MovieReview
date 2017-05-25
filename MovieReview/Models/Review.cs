using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class Review
    {
        [Key]
        public virtual int ReviewId { get; set; }

        [ForeignKey("UserID")]
        public Users Users { get; set; }
        public virtual int UserID { get; set; }

        public virtual string ReviewBody { get; set; }

        public virtual int Rating { get; set; }

        [ForeignKey("MoviesID")]
        public Movies Movies { get; set; }
        public virtual int MoviesID { get; set; }
    }
}