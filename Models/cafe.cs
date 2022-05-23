using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _2121_wave_cafe.Models
{
    public class cafe
    {   
        public int Id { get; set; }
        public string TênSP { get; set; }
        [Display(Name = "Ngày Nhập")]
        [DataType(DataType.Date)]
        public DateTime NgàyNhập { get; set; }
        public string SốLượng { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GiáTiền { get; set; }
        public string NhậnXét { get; set; }
    }
}