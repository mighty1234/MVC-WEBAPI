using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class BrunchViewModel
    {
       

        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }       
        public  List<OrdersViewModel> Orders { get; set; }       
        public  List<StaffViewModel> Staff { get; set; }
    }
}