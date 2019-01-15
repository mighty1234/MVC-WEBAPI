using DTOLibrary;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVCViewModel
{
  public static  class OrderLoader
    {
      public static OrdersViewModel GetOrder(int id)
        {

            OrdersDto order;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Orders/"+id.ToString()).Result;
            order = response.Content.ReadAsAsync<OrdersDto>().Result;
            var result = Mapper.MapOrder(order);



            return result;

        }



    }
}
