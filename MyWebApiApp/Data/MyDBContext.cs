using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace MyWebApiApp.Data
{
    public class MyDBContext:DbContext
    {

        public MyDBContext(DbContextOptions options):base(options) { }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<CuaHangData> CuaHangs { get; set; }
        public DbSet<VanChuyenss> VanChuyen { get; set; }


    }
}
