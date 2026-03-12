using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        List<Aluno> aluno1 = new List<Aluno>()
        {
            new Aluno()
            {
                nome = "Arnaldo",
                cpf = "12345678910",
                curso = "Tecnologia em Análise e Desenvolvimento de Sistemas",
                matricula = "20250988890",
                dataNascimento = new DateOnly(1988, 09, 02)    
            },
            new Aluno()
            {
                nome = "Zé Coméia",
                cpf = "09876543211",
                curso = "Tecnologia em Análise e Desenvolvimento de Sistemas",
                matricula = "20250988899",
                dataNascimento = new DateOnly(2000, 09, 02)
            }
            
        };
        return View(aluno1);
    }
}