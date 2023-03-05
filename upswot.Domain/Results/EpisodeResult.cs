using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upswot.Domain.Entity;

namespace upswot.Domain.Results
{
    public class EpisodeResult
    {
        public Info Info { get; set; }

        public IEnumerable<EpisodeSheme> Results { get; set; }
    }
}
