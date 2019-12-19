﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudServices.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedData { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime UpdateDate { get; set; }
    }
}
