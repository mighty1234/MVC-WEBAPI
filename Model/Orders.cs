using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<int> Staff_id { get; set; }
        public Nullable<int> Brunch_id { get; set; }
        public Nullable<int> Client_id { get; set; }
        public Nullable<int> Gift_id { get; set; }

        public virtual Brunch Brunch { get; set; }
        public virtual Client Client { get; set; }
        public virtual Gifts Gifts { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
