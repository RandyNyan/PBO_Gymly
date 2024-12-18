using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Gymly.StrukturData
{
    public class Struktur_FasilitasGym
    {
        [Key]
        public int id_fasilitas_gym { get; set; }
        [Required]
        [StringLength(50)]
        public string nama_fasilitas { get; set; }
        [Required]
        public int jumlah_fasilitas { get; set; }
        [Required]
        public int fasilitas_baik { get; set; }
        [Required]
        public int fasilitas_rusak { get; set; }
    }
}
