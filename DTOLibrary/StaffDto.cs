using MVCServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class StaffDto
    {
        public StaffDto(Staff entity)
        {
            this.Id = entity.Id;            
            this.Name = entity.Name;      
            this.Surname = entity.Surname;
            this.BrunchId = entity.Brunch_id;
            this.OrsersId = entity.Orders.Select(x => x.Id).ToList();
            this.PositionId = entity.Position_id;
            //this.Position =(entity.Position!=null)?null: new PositionDto(entity.Position);
            //this.Brunch = (entity.Brunch != null) ? null : new BrunchDto(entity.Brunch);
        }


        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public int BrunchId { get; set; }
        public List<int> OrsersId { get; set; }
        public int PositionId { get; set; }

       //public PositionDto Position{ get; set; }
       // public BrunchDto Brunch { get; set; }
       // public List<Orders> Orders { get; set; }
  
    }
}

