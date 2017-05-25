using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MovieReview.Models
{
    public class Genres
    {
        [Key]
        public virtual int GenresID { get; set; }
        public virtual string GenreName { get; set; }
    }
}