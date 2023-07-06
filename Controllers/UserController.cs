using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;
public class UserController : Controller
{
    [HttpGet("")]
    public ViewResult Form()
    {
        return View();
    }

    [HttpPost("formsubmit")]
    public IActionResult SubmitForm(string Name, string Location, string Language, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;
        return View("Review");
    }
}