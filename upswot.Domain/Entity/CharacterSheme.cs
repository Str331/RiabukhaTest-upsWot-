using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upswot.Domain.Entity
{
    public class CharacterSheme:MainProp
    {

        public string Name { get; set; }

        public string Status { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }

        public LocationScheme Location { get; set; }

        public IEnumerable<string> Episode { get; set; }
    }
}
