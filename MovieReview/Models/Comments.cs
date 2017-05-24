using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReview.Models
{
    public class Comments
    {
        [Key]
        public virtual int CommentID { get; set; }
        public virtual string CommentBody { get; set; }

        public virtual int UserID { get; set; }
        [ForeignKey("UserID")]
        public Users Users { get; set; }
    }
}