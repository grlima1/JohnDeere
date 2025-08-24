using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface IPostsApi
    {
        Task<IEnumerable<Post>> GetPostsAsync();
    }

    public class PostsApi : IPostsApi
    {
        HttpClient _httpClient;

        public PostsApi()
        {
            // Initialize HttpClient or any other dependencies here
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync("http://localhost:3000/posts");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var posts = System.Text.Json.JsonSerializer.Deserialize<List<Post>>(jsonResponse);

            return posts;
        }
    }
}
