using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upswot.Domain.Entity;

namespace upswot.Domain.Results
{
    public class CharacterResults
    {
        public Info Info { get; set; }

        public IEnumerable<CharacterSheme> Results { get; set; }
    }
}
