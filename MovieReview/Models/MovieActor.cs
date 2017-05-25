using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class MovieActor
    {
        [Key, Column(Order = 0)]
        public virtual int ActorsID { get; set; }
        [Key, Column(Order = 1)]
        public virtual int MoviesID { get; set; }
    }
}