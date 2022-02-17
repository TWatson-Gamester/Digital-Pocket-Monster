using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Pocket_Monster.Models
{
    public class Pack
    {
        [Required]
        public int? ID { get; set; }
        [Required] [Column(TypeName = "varchar(25)")]
        public string PackName { get; set; }

        public Pack() { }

        public Pack(int id, string packName)
        {
            this.ID = id;
            this.PackName = packName;
        }
    }
}