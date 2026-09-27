using Bai1_FormSubmit.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai1_FormSubmit.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(AccountViewModel model)
    {
        if (model.Username == "Ta Quang Huy" && model.Password == "123")
        {
            model.Message = "Login success";
            model.IsSuccess = true;
        }
        else
        {
            model.Message = "Login failed";
            model.IsSuccess = false;
        }

        return View(model);
    }
}
