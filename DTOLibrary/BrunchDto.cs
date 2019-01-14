using MVCServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class BrunchDto
    {
        public BrunchDto(Brunch entity)
        {
            this.Id = entity.Id;
            this.Address = entity.Address;
            this.Name = entity.Name;
            this.Email = entity.Email;
            this.StaffId = entity.Staff.Select(x => x.Id).ToList();
            this.OrdersId = entity.Orders.Select(x => x.Id).ToList();
          //  this.Staff = (entity.Staff == null) ? null : entity.Staff.Select(e=>new StaffDto(e)).ToList();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<int> StaffId { get; set; }
        public List<int> OrdersId { get; set; }
           
       // public List<StaffDto> Staff { get; set; }
       
    }
}
