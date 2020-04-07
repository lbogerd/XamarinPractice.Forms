using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XamarinPractice.Shared
{
	public class DataRetriever
	{
		private HttpClient _client;

		public DataRetriever()
		{
			_client = new HttpClient();
		}
		
		private string GetResponse(string path)
		{
			var response = _client
				.GetAsync(@"https://jsonplaceholder.typicode.com/" + path)
				.GetAwaiter()
				.GetResult();

			response.EnsureSuccessStatusCode();

			return response
				.Content
				.ReadAsStringAsync()
				.GetAwaiter()
				.GetResult();
		}

		public List<Post> GetPosts()
		{
			return JsonConvert
				.DeserializeObject<List<Post>>(GetResponse("posts"));
		}
	}
}
