using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MovieReview.Models
{
    public class Director
    {
        [Key]
        public virtual int DirectorsID { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual string Bio { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string PlaceOfBirth { get; set; }
    }
}