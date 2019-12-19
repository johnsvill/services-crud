using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudServices.Models
{
    public class Author : BaseEntity
    {        
        public string Firstname { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public List<Video> Videos { get; set; }
    }
}
