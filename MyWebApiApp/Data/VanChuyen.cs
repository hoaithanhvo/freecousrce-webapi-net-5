using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebApiApp.Data
{
    public class VanChuyenss
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public float ChiPhi {  get; set; }
    }
}
