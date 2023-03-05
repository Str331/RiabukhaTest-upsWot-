using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using upswot.Domain.Extension;
using upswot.Domain.ViewModel;
using upswot.Services.Service_Interface;

namespace RiabukhaTest.Controllers
{
    [ApiController,Route("api/v1/[controller]")]
    public class PersonController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICharacterService characterService;
        private readonly ILocationService locationService;
        private readonly IEpisodeService episodeService;

        public PersonController(IMapper mapper, ICharacterService characterService, ILocationService locationService, IEpisodeService episodeService)
        {
            this.mapper = mapper;
            this.characterService = characterService;
            this.locationService = locationService;
            this.episodeService = episodeService;
        }

        [HttpPost, Route("check-person")]
        public async Task<IActionResult> GetCharacterEp([FromBody] CharacterInEpisodeVM characterIn)
        {
            try
            {
                var character = await characterService.GetCharacters(characterIn.CharacterName);
                var episode = await episodeService.GetEpisode(characterIn.EpisodeName);
                var info = episode.Select(x => x.URL).Intersect(character.SelectMany(y => y.Episode)).ToList();

                return Ok(info.Count != 0);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet()]
        public async Task<IActionResult> GetCharacter([FromQuery] string name)
        {
            try
            {
                var character = await characterService.GetCharacters(name);
                foreach(var person in character)
                {
                    var locId = person.Location.URL.GetURLid();
                    var location = await locationService.GetLocation(locId);
                    person.Location = location;
                }
                return Ok(mapper.Map<IEnumerable<CharacterVM>>(character));
            }
            catch(Exception)
            {
                return NotFound();
            }
        }
    }
}
