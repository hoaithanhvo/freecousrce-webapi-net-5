using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Models
{
    public class CuaHang
    {
        public string Diachi { get; set; }
        public string TenCuaHang { get; set; }
        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }
        public string PhoneyNumber { get; set; }
        
        public int MaCuaHang { get; set; }
    }
}
