using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CoreApi8_OnionArc.Dtos.TestimonialDtos;

namespace CoreApi8_OnionArc.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponantPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _TestimonialComponantPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:5078/api/Testimonials");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
