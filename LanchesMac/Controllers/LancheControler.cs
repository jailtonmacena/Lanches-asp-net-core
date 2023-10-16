using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheControler : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheControler(ILancheRepository lancheRepository) 
        { 
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
