using Domain;

namespace Infra
{
    public interface ICommentsApi
    {
        Task<IEnumerable<Comment>> GetAsync();
    }

    public class CommentsApi : ICommentsApi
    {
        HttpClient _httpClient;

        public CommentsApi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Comment>> GetAsync()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync("http://localhost:3000/comments");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var comments = System.Text.Json.JsonSerializer.Deserialize<List<Comment>>(jsonResponse);

            return comments;
        }
    }
}
