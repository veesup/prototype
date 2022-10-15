using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? Productid { get; set; }
        public DateTime? Orderdated { get; set; }
    }
}
