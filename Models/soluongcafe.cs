using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace _2121_wave_cafe.Models
{
    public class cafesoluong

    {
        public List<cafe>? cafes { get; set; }
        public SelectList? SốLượng { get; set; }
        public string? cafeSốLượng { get; set; }
        public string? SearchString { get; set; }
    }
}