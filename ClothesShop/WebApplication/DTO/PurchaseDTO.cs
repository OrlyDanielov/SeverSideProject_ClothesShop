using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.DTO
{
    public class PurchaseDTO
    {
        public int client_id;
        public int number; // the number of clothe
        public DateTime? purchase_date;
        public int? amount;
        public int purchase_id;
        public double total; // sum of all the order
    }
}