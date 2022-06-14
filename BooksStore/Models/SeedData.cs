using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

namespace BooksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context =
            app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < BooksStoreDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    hinhanh = " https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/bbb806c412db45868343ad24012e91fd_9366/Giay_Bong_DJa_San_Co_Tu_Nhien_Predator_Freak.3_DJo_FY6282_01_standard.jpg",
                    Title = "GIÀY BÓNG ĐÁ SÂN CỎ TỰ NHIÊN PREDATOR FREAK.3",
                    Description = "ĐÔI GIÀY BÓNG ĐÁ CỔ LỬNG GIÚP BẠN LÀM CHỦ TRẬN ĐẤU TRÊN SÂN CỎ TỰ NHIÊN.",
                    Genre = "GIÀY BÓNG ĐÁ",
                    Price = 3.50m
                },
                new Book
                {
                    hinhanh = " https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/e4d6e938854444d9bfd5acc2010d8303_9366/Giay_Bong_DJa_San_Co_Tu_Nhien_Predator_Freak.1_DJo_FY6266_01_standard.jpg",
                    Title = "GIÀY BÓNG ĐÁ PREDATOR FREAK.1 FIRM GROUND",
                    Description = "ĐÔI GIÀY BÓNG ĐÁ NÂNG ĐỠ VỚI THIẾT KẾ TRAO QUYỀN KIỂM SOÁT.",
                    Genre = "GIÀY BÓNG ĐÁ",
                    Price = 2.70m
                },
                new Book
                {
                    hinhanh = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/7dbf2ba45c1e4207a1fdae1900c6b6bd_9366/Ao_DJau_San_Nha_Arsenal_22-23_DJo_H35903_21_model.jpg",
                    Title = "ÁO ĐẤU SÂN NHÀ ARSENAL 22/23",
                    Description = "CHIẾC ÁO ĐẤU BÓNG ĐÁ ARSENAL DÀNH CHO FAN, LÀM TỪ CHẤT LIỆU TÁI CHẾ.",
                    Genre = "ÁO ĐẤU",
                    Price = 4.80m
                },
                new Book
                {
                    hinhanh = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/aa1b019f4d9648ac87e6adde01234edd_9366/Ao_DJau_San_Nha_Real_Madrid_22-23_trang_HF0291_21_model.jpg",
                    Title = "ÁO ĐẤU SÂN NHÀ REAL MADRID 22/23",
                    Description = "CHIẾC ÁO ĐẤU SÂN NHÀ REAL MADRID LÀM TỪ CHẤT LIỆU TÁI CHẾ.",
                    Genre = "ÁO ĐẤU",
                    Price = 4.95m
                },
                new Book
                {
                    hinhanh = " https://www.thethaoaolikes.com/upload/public/8d26b89e5169e02ffa5a647ec5d842ce.jpg",
                    Title = "BĂNG CUỐN BẢO VỆ MẮT CÁ CHÂN THOÁNG KHÍ AL7130",
                    Description = "KIỂU DÁNG HIỆN ĐẠI, SIÊU BỀN Sử dụng miếng dán công nghệ mới, không gồ ghề, không gây đau khi tiếp xúc với da,độ bám dính rất chắc, siêu bền",
                    Genre = "ĐỒ BẢO VỆ",
                    Price = 1.30m
                },
                new Book
                {
                    hinhanh = "https://www.thethaoaolikes.com/upload/public/48126098c43ea04ba28967a5c2a20b69.jpg",
                    Title = "BÓ GỐI SILICONE AL7908",
                    Description = "LÒ XO DẠNG DẺO TRỢ LỰC VÀ ĐỆM SILICONE Miếng silicon bảo vệ phần đầu gối dày 1cm, trực tiếp chống chịu lực khi va chạm, 4 thanh lò xo đàn hồi",
                    Genre = "ĐỒ BẢO VỆ",
                    Price = 1.95m
                },
                new Book
                {
                    hinhanh = " https://prokeepersg.com/wp-content/uploads/2022/06/kiotviet_54ba7725cc8f32a9da2745d460c8fe1b-350x350.jpg",
                    Title = "Găng Tay Uhlsport Absolute Flex Carbon Frame",
                    Description = "Găng tay thủ môn, găng tay thủ môn cao cấp, găng tay thủ môn chính hãng",
                    Genre = "GĂNG TAY THỦ MÔN",
                    Price = 4.95m
                },
                new Book
                {
                    hinhanh = " https://prokeepersg.com/wp-content/uploads/2022/06/kiotviet_a19be8756c26f91674799e58228e930c-350x350.jpg",
                    Title = "Găng Tay Uhlsport HyperAct SuperGrip+ HN",
                    Description = "Găng tay thủ môn, găng tay thủ môn cao cấp, găng tay thủ môn chính hãng",
                    Genre = "GĂNG TAY THỦ MÔN",
                    Price = 5.90m
                }
                );

                context.SaveChanges();
            }
        }
    }
}