using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _2121_wave_cafe.Data;
using System;
using System.Linq;
namespace _2121_wave_cafe.Models
{
    public static class duliucafe
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new _2121_wave_cafeContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<_2121_wave_cafeContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.cafe.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.cafe.AddRange(
                new cafe
                {
                    TênSP = "CÀ PHÊ ĐÁ",
                    NgàyNhập = DateTime.Parse("2018-10-16"),
                    SốLượng = "1",
                    GiáTiền = 10.000M,
                    NhậnXét = "Tốt"
                },
                new cafe
                {
                    TênSP = "CÀ PHÊ SỮA",
                    NgàyNhập = DateTime.Parse("2018-10-16"),
                    SốLượng = "2",
                    GiáTiền = 12.000M,
                    NhậnXét = "Tốt"
                },
                new cafe
                {
                    TênSP = "Cà Phê Sữa Tươi",
                    NgàyNhập = DateTime.Parse("2018-10-16"),
                    SốLượng = "3",
                    GiáTiền = 14.000M,
                    NhậnXét = "Tốt"
                },
                new cafe
                {
                    TênSP = "Cafe Aik Cheong Cappuccino",
                    NgàyNhập = DateTime.Parse("2021-8-3"),
                    SốLượng = "4",
                    GiáTiền = 21.000M,
                    NhậnXét = "Tốt"
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}