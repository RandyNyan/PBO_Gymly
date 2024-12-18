using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Gymly.StrukturData
{
    internal class Struktur_Membership
    {
        [Key]
        public int id_membership { get; set; }
        [Required]
        public string nama_membership { get; set; }
        [ForeignKey("M_Status")]
        public int id_status { get; set; }
    }
}
