using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lab2.Components
{
    public class CommentViewComponent : ViewComponent
    {
        public const string COMMENTSESSION = "Comments";

        public IViewComponentResult Invoke()
        {
            string sessionString = HttpContext.Session.GetString("Comments");
            List<string> comments = new List<string>();
            if (!string.IsNullOrWhiteSpace(sessionString))
            {
                comments = JsonSerializer.Deserialize<List<string>>(sessionString);
            }

            return View("~/views/components/_comments.cshtml", comments);
        }
    }
}
