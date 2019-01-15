using DTOLibrary;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCViewModel
{
    public  static  class Mapper
    {
         static public BrunchViewModel MapBrunch(BrunchDto brunch)
        {
            BrunchViewModel brunchViewModel = new BrunchViewModel();
            brunchViewModel.Id = brunch.Id;
            brunchViewModel.Name = brunch.Name;
            brunchViewModel.Email = brunch.Email;
            brunchViewModel.Address = brunch.Address;

            return brunchViewModel;
        }
        static public OrdersViewModel MapOrder(OrdersDto order)
        {
           OrdersViewModel brunchViewModel = new OrdersViewModel();
            brunchViewModel.Id = order.Id;         

            return brunchViewModel;
        }

    }
}
