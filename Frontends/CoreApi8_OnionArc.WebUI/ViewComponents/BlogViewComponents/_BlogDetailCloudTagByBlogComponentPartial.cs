using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CoreApi8_OnionArc.Dtos.BlogDtos;
using CoreApi8_OnionArc.Dtos.TagCloudDtos;

namespace CoreApi8_OnionArc.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCloudTagByBlogComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _BlogDetailCloudTagByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.blogid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:5078/api/TagClouds/GetTagClodByBlogId?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetByBlogIdTagCloudDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
