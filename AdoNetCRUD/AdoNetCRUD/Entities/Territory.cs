using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCRUD.Entities
{
    class Territory
    {
        public string Id { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
    }
}
