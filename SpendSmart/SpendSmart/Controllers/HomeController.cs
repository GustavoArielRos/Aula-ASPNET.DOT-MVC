using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using System.Diagnostics;

namespace SpendSmart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SpendSmartDbContext _context;

        public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            var allExpenses = _context.Expenses.ToList();//pegando todas as informações do banco e tacando nessa variavel

            var totalExpenses = allExpenses.Sum(x => x.Value);

            ViewBag.Expenses = totalExpenses;

            return View(allExpenses);
        }

        public IActionResult CreateEditExpense(int? id)
        {   
            if(id != null)
            {
                //editing -> load an expense by id
                var expenseInDb = _context.Expenses.SingleOrDefault(expense => expense.Id == id);

                return View(expenseInDb);

            }

            return View();
        }

        public IActionResult DeleteExpense(int id)
        {   
            //vamos passar pela tabela "Expenses" do banco de dados(_context) e achar aquela com id é igual do parâmetro e armazenar na variavel
            var expenseInDb = _context.Expenses.SingleOrDefault(x => x.Id == id);
            //depois vamos deletar essa variável no banco de dados
            _context.Expenses.Remove(expenseInDb);
            //salvando a alteração
            _context.SaveChanges();
            return RedirectToAction("Expenses");//vai levar para a página expenses
        }

        public IActionResult CreateEditExpenseForm(Expense model)
        {
            // Verifica se o ID do modelo é igual a 0
            // Se for igual a 0, significa que é um novo registro (criação)
            if (model.Id == 0)
            {
                // Create
                _context.Expenses.Add(model);
            } else
            {
                // Editing
                _context.Expenses.Update(model);
            }
            

            _context.SaveChanges();//salvando essa alteração do banco de dados

            return RedirectToAction("Expenses");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
