﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Models
{
    public partial class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
    }
}
