using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PO_API.Entities
{
    public class Plant
    {
        [Key]
        public int PlantId { get; set; }

        [MaxLength(50)]
        public string PlantName { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        //[Required]
        //[MaxLength(50)]
        //public string Genre { get; set; }

        //public ICollection<Book> Books { get; set; } = new List<Book>();
    }

    public class PlantForNotif {
        public string Request { get; set; }
        public Plant RequestValue { get; set; }
    }
}
