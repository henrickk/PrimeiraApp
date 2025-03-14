using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class TesteEFController : Controller
    {
        public AppDbContext Db { get; set; }

        public TesteEFController(AppDbContext db)
        {
            Db = db;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Henrick",
                Email = "henrick@email.com",
                DataNascimento = new DateTime(2001, 1, 1),
                Avaliacao = 5,
                Ativo = true
            };

            ////----criando o aluno
            //Db.Alunos.Add(aluno);
            //Db.SaveChanges();

            ////----obtendo os dados dele
            var alunoChange = Db.Alunos.Where(a => a.Nome.Contains("Henrick")).FirstOrDefault();
            //alunoChange.Nome = "Henrick Adrian";

            ////Como salvo
            //Db.Alunos.Update(alunoChange);
            //Db.SaveChanges();


            Db.Alunos.Remove(alunoChange);
            Db.SaveChanges();

            return Content("");
        }
    }
}
