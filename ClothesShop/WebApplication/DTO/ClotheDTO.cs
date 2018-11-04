using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.DTO
{
    public class ClotheDTO
    {
        public int number;
        public string details;
        public double? priceSupp;
        public double? priceBuyer;
        public double cost;
        public double? stock;
        public string category;
        public string img_url;

        public List<PurchaseDTO> purchases;
    }
}