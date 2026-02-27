using Microsoft.AspNetCore.Mvc;

namespace academico.Controllers;

public class alunocontroller : controller
{
    public IActionResult Index ()
    {
        return View();
    }
}