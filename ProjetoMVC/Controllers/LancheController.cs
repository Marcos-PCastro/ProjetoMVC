using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Repositories;
using ProjetoMVC.Repositories.Interfaces;
using ProjetoMVC.ViewModel;

namespace ProjetoMVC.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {

          //var lanches = _lancheRepository.Lanches;
          // return View(lanches);
          var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            
            return View(lanchesListViewModel);


        }
    }
}
