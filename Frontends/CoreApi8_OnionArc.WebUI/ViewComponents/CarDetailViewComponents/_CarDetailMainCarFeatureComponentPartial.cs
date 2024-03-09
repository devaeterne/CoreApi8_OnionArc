using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using CoreApi8_OnionArc.Dtos.CarDtos;
using CoreApi8_OnionArc.Dtos.CategoryDtos;

namespace CoreApi8_OnionArc.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailMainCarFeatureComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _CarDetailMainCarFeatureComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.carid = id;
			var client = _httpClientFactory.CreateClient();
			var resposenMessage = await client.GetAsync($"https://localhost:5078/api/Cars/{id}");
			if (resposenMessage.IsSuccessStatusCode)
			{
				var jsonData = await resposenMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultCarWithBrandsDtos>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
