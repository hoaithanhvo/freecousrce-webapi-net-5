using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Data
{
    public class CuaHangData
    {
        [Required]
        [MaxLength(100)]
        public string Diachi { get; set; }
        public string TenCuaHang { get; set; }
        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }
        public string PhoneyNumber { get; set; }
        [Key]
        public int MaCuaHang { get; set; }
    }
}
