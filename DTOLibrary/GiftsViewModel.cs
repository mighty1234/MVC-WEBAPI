using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class GiftsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Cost { get; set; }
       
        public virtual List<OrdersViewModel> Orders { get; set; }
    }
}