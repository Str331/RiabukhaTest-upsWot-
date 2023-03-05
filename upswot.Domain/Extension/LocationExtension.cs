using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upswot.Domain.Entity;
using upswot.Domain.ViewModel;

namespace upswot.Domain.Extension
{
    public class LocationExtension : Profile
    {
        public LocationExtension() => CreateMap<LocationScheme, LocationVM>();
    }
}
