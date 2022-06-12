using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho.Models;


namespace Trabalho.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Trabalho.Data.AppContext _appContext;

        public ProdutosController(Trabalho.Data.AppContext appContetxt)
        {
            _appContext = appContetxt;
        }

        public async Task<IActionResult> Index()
        {
            var funcs = await _appContext.Produtos.ToListAsync();
            return View(funcs);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           // var produto = await _appContext.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            var produto = await _appContext.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("ID, Nome, Modelo, Descricao")] produto produto)
        {
            if (ModelState.IsValid)
            {
                _appContext.Add(produto);
                await _appContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var produto = await _appContext.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            var produto = await _appContext.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

       /* [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id,[Bind("ID, Nome, Modelo, Descricao")] produto produto)
        {
            if(id != produto.Id)
            {
                return base.NotFound();
            }
    

            if (ModelState.IsValid)
            {
                try
                {
                     _appContext.Update(produto);
                      await _appContext.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                        if (!ProdutoExists(produto.Id))
                        {
                            return base.NotFound();
                        }  
                        
                        else
                        {
                            throw;
                        }
                }
               
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }*/

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var produto = await _appContext.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            var produto = await _appContext.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _appContext.Produtos.FindAsync(id);
            _appContext.Produtos.Remove(produto);
            await _appContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
 }
