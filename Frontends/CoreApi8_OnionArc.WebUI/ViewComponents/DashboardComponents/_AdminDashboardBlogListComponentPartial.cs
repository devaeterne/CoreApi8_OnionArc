using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CoreApi8_OnionArc.Dtos.BlogDtos;

namespace CoreApi8_OnionArc.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardBlogListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardBlogListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:5078/api/Blogs/GetAllBlogsWithAuthorList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
