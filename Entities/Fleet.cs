using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST01_3_1107_Popescu_Romeo.Entities
{
    [Serializable]
    public class Fleet
    {
        public int Id { get; set; }
        public List<Truck> Trucks { get; set; }

        public Fleet()
        { 
            Trucks = new List<Truck>();
        }
    }
}
