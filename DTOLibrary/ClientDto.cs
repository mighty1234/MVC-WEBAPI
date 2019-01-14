using MVCServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
     public partial class ClientDto
    {
        public ClientDto(Client entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.Phone = entity.Phone;
            this.Surname = entity.Surname;
            this.Email = entity.Email;
            this.OrdersId = (entity.Orders == null) ? null : entity.Orders.Select(x => x.Id).ToList();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<int> OrdersId { get; set; }

    }
}
