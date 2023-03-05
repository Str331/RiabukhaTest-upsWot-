using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upswot.Services.Service_Interface
{
    public abstract class IBaseService
    {
        private readonly HttpClient client;
        private readonly IMapper mapper;

        protected IBaseService(IMapper mapper, string baseAddress)
        {
            this.mapper = mapper;

            this.client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        protected async Task<T?> Get<T>(string path)
        {
            var response = await this.client.GetAsync(path);

            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync())
                : default(T);
        }
    }
}
