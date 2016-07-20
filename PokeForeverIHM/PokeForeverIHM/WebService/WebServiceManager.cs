using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PokeForeverIHM.EnumManager;

namespace PokeForeverIHM.WebService
{
	class WebServiceManager<T> where T : class
	{
		public string DataConnectionResource { get; set; }
		public WebServiceManager(DataConnectionResource resource)
		{
			DataConnectionResource = EnumString.GetStringValue(resource);
		}
		public async Task<T> Get(int id)
		{
			T item = default(T);
			string url = typeof(T).Name + "/" + id + "/";
			item = await HttpClientCaller(url, item);
			return item;
		}

		public async Task<List<T>> Get()
		{
			List<T> item = default(List<T>);
			string url = typeof(T).Name + "/";
			item = await HttpClientCaller(url, item);
			return item;
		}

		public async Task<T> Post(T item)
		{
			T result = default(T);
			string url = typeof(T).Name + "/";
			result = await HttpClientSender(url, item, result);

			return result;
		}

		public async Task<List<T>> Post(List<T> items)
		{
			List<T> result = default(List<T>);
			string url = typeof(T).Name + "s/";
			result = await HttpClientSender(url, items, result);

			return result;
		}

		public async Task<T> Put(T item)
		{
			T result = default(T);
			string url = typeof(T).Name + "/";
			result = await HttpClientPuter(url, item, result);

			return result;
		}

		public async Task<List<T>> Put(List<T> items)
		{
			List<T> result = default(List<T>);
			string url = typeof(T).Name + "s/";
			result = await HttpClientPuter(url, items, result);

			return result;
		}

		public async Task<int> Delete(T item)
		{
			int result = default(int);
			string url = typeof(T).Name + "/";
			result = await HttpClientDeleter(url, item, result);

			return result;
		}

		public async Task<int> Delete(List<T> items)
		{
			int result = default(int);
			string url = typeof(T).Name + "s/";
			result = await HttpClientDeleter(url, items, result);

			return result;
		}

		private async Task<TItem> HttpClientCaller<TItem>(string url, TItem item)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(DataConnectionResource);
				client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync(url);
				item = await HandleResponse(item, response);
			}

			return item;
		}

		private async Task<TItem> HttpClientSender<TItem>(string url, TItem item, TItem result)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(DataConnectionResource);
				client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.PostAsync(url,
					new StringContent(JsonConvert.SerializeObject(item),
					Encoding.UTF8, "application/json"));

				result = await HandleResponse(item, response);
			}

			return result;
		}

		private async Task<TItem> HttpClientPuter<TItem>(string url, TItem item, TItem result)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(DataConnectionResource);
				client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.PutAsync(url,
					new StringContent(JsonConvert.SerializeObject(item),
					Encoding.UTF8, "application/json"));

				result = await HandleResponse(item, response);
			}

			return result;
		}

		private async Task<TResult> HttpClientDeleter<TItem, TResult>(string url, TItem item, TResult result)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(DataConnectionResource);
				client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

				using (HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Delete, url))
				{
					message.Content = new StringContent(JsonConvert.SerializeObject(item),
					Encoding.UTF8, "application/json");
					HttpResponseMessage response = await client.SendAsync(message);

					result = await HandleResponse(result, response);
				}
			}

			return result;
		}

		private async Task<TItem> HandleResponse<TItem>(TItem item, HttpResponseMessage response)
		{
			if (response.IsSuccessStatusCode)
			{
				string result = await response.Content.ReadAsStringAsync();
				item = JsonConvert.DeserializeObject<TItem>(result);
			}

			return item;
		}
	}
}
