using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PO_API.Entities
{
    public class TargetSetting
    {
        [Key]
        public int TSettingId { get; set; }

        [MaxLength(50)]
        public string TSettingName { get; set; }

        [MaxLength(50)]
        public string TSettingDesc { get; set; }
    }

    public class TargetSettingSumary
    {
        [Key]
        public int Id { get; set; }
        public DateTime CompDate { get; set; }

        public double ActionVal { get; set; }
      
        [ForeignKey("TSettingId")]
        public TargetSetting TargetSettings { get; set; }

        public int TSettingId { get; set; }

        [ForeignKey("PlantId")]
        public Plant Plants { get; set; }

        public int PlantId { get; set; }
        
        [ForeignKey("DivId")]
        public Division Divisions { get; set; }
        public int DivId { get; set; }

    }


}
