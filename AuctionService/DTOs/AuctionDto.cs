using System;
using AuctionService.Entities;

namespace AuctionService.DTOs
{
	public class AuctionDto
	{
        public int ReservePrice { get; set; } = 0;
        public string? Seller { get; set; }
        public string? Winner { get; set; }
        public int? SoldAmount { get; set; }
        public int? CurrentHighBid { get; set; }
        public DateTime CreateAt { get; set; } 
        public DateTime UpdateAt { get; set; }
        public DateTime AuctionEnd { get; set; }
        
    }
}

