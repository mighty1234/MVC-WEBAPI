using MVCServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class PositionDto
    {
        public PositionDto(Position entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.Salary = entity.Salary;
            this.StaffIds = entity.Staff.Select(x => x.Id).ToList();

           // this.Staff = (entity.Staff != null) ? null: entity.Staff.Select(x=>new StaffDto(x)).ToList();
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<int> StaffIds { get; set; }

      

    }
}
