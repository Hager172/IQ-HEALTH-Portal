using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
    {
    public class ApprovalItemDto
        {
        public string Id { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Quantity { get; set; }
        public string QuantityUnit { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        }
    }
