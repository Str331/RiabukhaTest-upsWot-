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
    public class CharacterExtension : Profile
    {
        public CharacterExtension()
        {
            var mapper = new Mapper(new MapperConfiguration(configure =>
            configure.AddProfile(new LocationExtension())));

            CreateMap<CharacterSheme, CharacterVM>().ForMember(x => x.Origin,
                y => y.MapFrom(z => mapper.Map<LocationVM>(z.Location)));
        }
    }
}
