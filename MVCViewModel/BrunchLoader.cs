using DTOLibrary;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace MVCViewModel
{
    public class BrunchLoader
    {
        public List<BrunchViewModel> GetBrunches()
        {
            BrunchViewModel brunchViewModel = new BrunchViewModel();
            List<BrunchViewModel> list = new List<BrunchViewModel>();


            IEnumerable<BrunchDto> brunchList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Brunch").Result;
            brunchList = response.Content.ReadAsAsync<IEnumerable<BrunchDto>>().Result;

            foreach (var brunch in brunchList)
            {
                var mappedBrunch = Mapper.MapBrunch(brunch);
                foreach (var item in brunch.OrdersId)
                {
                    mappedBrunch.Orders.Add(OrderLoader.GetOrder(item));
                }

                list.Add(mappedBrunch);
            }

            return list;
            
        }


    }
}
