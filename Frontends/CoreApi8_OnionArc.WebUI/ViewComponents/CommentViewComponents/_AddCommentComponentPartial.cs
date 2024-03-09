using Microsoft.AspNetCore.Mvc;

namespace CoreApi8_OnionArc.WebUI.ViewComponents.CommentViewComponents
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
