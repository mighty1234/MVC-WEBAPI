using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int Brunch_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Position_id { get; set; }

        public virtual Brunch Brunch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Position Position { get; set; }
    }
}
