using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Models
{
    [Index("AnimalId", Name = "IX_Comments_AnimalId")]
    public partial class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int AnimalId { get; set; }
        public string CommentMessage { get; set; } = null!;

        [ForeignKey("AnimalId")]
        [InverseProperty("Comments")]
        public virtual Animal Animal { get; set; } = null!;
    }
}
