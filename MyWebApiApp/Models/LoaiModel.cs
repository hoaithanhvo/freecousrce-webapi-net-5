using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
    
}
