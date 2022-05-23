using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2121_wave_cafe.Models;

namespace _2121_wave_cafe.Data
{
    public class _2121_wave_cafeContext : DbContext
    {
        public _2121_wave_cafeContext (DbContextOptions<_2121_wave_cafeContext> options)
            : base(options)
        {
        }

        public DbSet<_2121_wave_cafe.Models.cafe> cafe { get; set; }
    }
}
