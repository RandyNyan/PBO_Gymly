using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Gymly.StrukturData
{
    internal class Struktur_Status
    {
        [Key]
        public int id_status { get; set; }
        [Required]
        public required string status_membership { get; set; }
        [Required]
        public int id_profil { get; set; }
        [Required]
        public int id_membership { get; set; }
    }
}
