using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upswot.Domain.Entity
{
    public class EpisodeSheme : MainProp
    {
        public string Name { get; set; }

        public string URL { get; set; }

        public IEnumerable<string> Characters { get; set; }
    }
}
