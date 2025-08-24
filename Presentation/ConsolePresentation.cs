using Infra;

namespace Presentation
{
    public interface IPresentation
    {
        Task<String> GetComments();
    }

    public class ConsolePresentation : IPresentation
    {
        public ICommentsApi _commentApi { get; set; }
        public ConsolePresentation(ICommentsApi commentsApi)
        {
            _commentApi = commentsApi;
        }

        public async Task<String> GetComments() {
            var comments = await _commentApi.GetAsync();


            //unique authors
            foreach (var comment in comments)
            {
                Console.WriteLine($"Comment by {comment.author.name}: {comment.author.email}, {comment.author.profile.bio}, {comment.author.profile.socialLinks}");
            }

            return "Printed All Comments";
        }
    }
}
