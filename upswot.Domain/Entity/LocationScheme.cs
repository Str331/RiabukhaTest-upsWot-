using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upswot.Domain.Entity
{
    public class LocationScheme : MainProp
    {
        public string Name { get; set; }

        public string URL { get; set; }

        public string Dimension { get; set; }

        public string Type { get; set; }
    }
}
