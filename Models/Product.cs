using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Price { get; set; }
    }
}
