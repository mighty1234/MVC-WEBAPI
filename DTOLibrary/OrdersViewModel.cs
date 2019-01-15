using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class OrdersViewModel
    {
        public int Id { get; set; }
        public Nullable<int> Staff_id { get; set; }
        public Nullable<int> Brunch_id { get; set; }
        public Nullable<int> Client_id { get; set; }
        public Nullable<int> Gift_id { get; set; }

        public virtual BrunchViewModel Brunch { get; set; }
        public virtual ClientViewModel Client { get; set; }
        public virtual GiftsViewModel Gifts { get; set; }
        public virtual StaffViewModel Staff { get; set; }
    }
}