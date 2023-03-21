using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop
{
    public partial class Animal
    {
        public Animal()
        {
            Comments = new HashSet<Comment>();
        }

        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string ImgUrl { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }

        [InverseProperty("Animal")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
