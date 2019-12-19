using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudServices.Models
{
    public class Video : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Url { get; set; } 

        public List<Author> Authors { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
