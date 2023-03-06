using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upswot.Domain.Entity;
using upswot.Domain.Results;
using upswot.Services.Service_Interface;

namespace upswot.Services.Implementation
{
    public class EpisodeService : IBaseService,IEpisodeService
    {
        private readonly IMapper mapper;

        public EpisodeService(IMapper mapper,string adress = "https://rickandmortyapi.com/api/episode/")
            :base(mapper,adress)
        {
            this.mapper = mapper;
        }

        public async Task<IEnumerable<EpisodeSheme>> GetEpisode(string name)
        {
            try
            {
                var response = await Get<EpisodeResult>($"?name={name}");
                if (response == null || !response.Results.Any())
                    throw new Exception("ERROR 404: Episode doesn`t exist");
                return response.Results;
            }
            catch (Exception)
            {
                throw new Exception("Episode doensn`t exist");
            }
        }
    }
}
