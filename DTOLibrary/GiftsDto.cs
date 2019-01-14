using MVCServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
     public partial class GiftsDto
    {
        public GiftsDto(Gifts entity)
        {
            this.Cost = entity.Cost;
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.OrdersId = (entity.Orders == null) ? null : entity.Orders.Select(x => x.Id).ToList();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Cost { get; set; }
        public List<int> OrdersId { get; set; }
    }
}
