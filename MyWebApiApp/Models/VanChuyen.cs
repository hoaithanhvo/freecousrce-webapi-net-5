using System;

namespace MyWebApiApp.Models
{
    public class VanChuyens
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float ChiPhi { get; set; }
        public float Km { get; set;}

    }
}
