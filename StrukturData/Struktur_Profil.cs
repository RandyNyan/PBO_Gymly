using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Gymly.StrukturData
{
    internal class Struktur_Profil
    {
        [Key]
        public int id_profil { get; set; }
        [Required]
        [StringLength(50)]
        public string naleng_customer { get; set; }
        [Required]
        [StringLength(50)]
        public string alamat_customer { get; set; }
        [Required]
        [StringLength(50)]
        public string notel_customer { get; set; }
        [Required]
        public int id_akun { get; set; }
    }
}
