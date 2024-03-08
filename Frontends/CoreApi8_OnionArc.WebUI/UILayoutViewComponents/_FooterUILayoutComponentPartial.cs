using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Dto.FooterAddressDtos;
using CoreApi8_OnionArc.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi8_OnionArc.WebUI.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _FooterUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:5078/api/FooterAddresses");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonContent.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}