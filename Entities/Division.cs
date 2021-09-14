using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PO_API.Entities
{
    public class Division
    {
        [Key]
        public int DivId { get; set; }

        [MaxLength(50)]
        public string DivName { get; set; }

        [MaxLength(50)]
        public string DivDescription { get; set; }
    }
    public class DivisionForNotif
    {
        public string Request { get; set; }
        public Division RequestValue { get; set; }
    }
}
