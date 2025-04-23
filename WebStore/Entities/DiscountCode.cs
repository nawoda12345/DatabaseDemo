using System;
using System.Collections.Generic;

namespace WebStore.Entities
{
    public class DiscountCode
    {
        public int DiscountCodeId { get; set; }

        public string Code { get; set; } = null!;  // e.g., "SUMMER25"

        public string? Description { get; set; }

        public DiscountType DiscountType { get; set; }

        public decimal DiscountValue { get; set; } // 10 => 10% or $10

        public DateTime? ExpirationDate { get; set; }

        public int? MaxUsage { get; set; }

        public int TimesUsed { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
