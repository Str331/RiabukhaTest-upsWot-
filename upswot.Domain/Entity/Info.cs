using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upswot.Domain.Entity
{
    public class Info
    {
        public long Count { get; set; }

        public long Pages { get; set; }

        public string Next { get; set; }

        public string Prev { get; set; }
    }
}
