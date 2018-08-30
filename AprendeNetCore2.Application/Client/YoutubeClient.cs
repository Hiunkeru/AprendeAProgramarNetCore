using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Client
{
    public class YoutubeClient : IYoutubeClient
    {

        private readonly HttpClient _httpClient;

        public YoutubeClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.googleapis.com/youtube/v3/")
            };
            _httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetChannelAsync<T>(string channerId, string APIKey)
        {

            var response = await _httpClient.GetAsync($"channels?part=id,snippet,brandingSettings,contentDetails,invideoPromotion,statistics,topicDetails&id={channerId}&key={APIKey}");
            if (!response.IsSuccessStatusCode)
                return default(T);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

    }
}
