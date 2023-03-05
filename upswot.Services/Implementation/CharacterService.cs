using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using upswot.Domain.Entity;
using upswot.Domain.Results;
using upswot.Services.Service_Interface;

namespace upswot.Services.Implementation
{
    public class CharacterService :IBaseService, ICharacterService
    {
        private readonly IMapper mapper;

        public CharacterService(IMapper mapper, string adress = "https://rickandmortyapi.com/api/character/")
            : base(mapper, adress)
        {
            this.mapper = mapper;
        }
            
        public async Task<IEnumerable<CharacterSheme>> GetCharacters(string name)
        {
            try
            {
                var response = await Get<CharacterResults>($"?name={name}");
                if (response == null || !response.Results.Any())
                    throw new Exception("ERROR 404: Character doesn`t exist");

                return response.Results;
            }
            catch (Exception)
            {
                throw new Exception("Some exeption");
            }
        }

    }
}
