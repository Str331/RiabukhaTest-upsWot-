using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upswot.Domain.Entity;
using upswot.Services.Service_Interface;

namespace upswot.Services.Implementation
{
    public class LocationService: IBaseService,ILocationService
    {
        private readonly IMapper mapper;

        public LocationService(IMapper mapper,string adress = "https://rickandmortyapi.com/api/location/")
            : base(mapper, adress)
        {
            this.mapper = mapper;
        }

        public async Task<LocationScheme> GetLocation(int id)
        {
            var response = await Get<LocationScheme>(id.ToString());
            return response;
        }
    }
}
