using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upswot.Domain.Entity;

namespace upswot.Services.Service_Interface
{
    public interface ICharacterService
    {
      public  Task<IEnumerable<CharacterSheme>> GetCharacters(string name);
    }
}
