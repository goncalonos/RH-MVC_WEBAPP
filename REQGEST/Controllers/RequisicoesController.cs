using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using REQGEST.Data;
using REQGEST.Models;

namespace REQGEST.Controllers
{
    public class RequisicoesController : Controller
    {
        private readonly ReqGestDbContext _context;

        public RequisicoesController(ReqGestDbContext context)
        {
            _context = context;
        }

        // GET: Requisicoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Requisicao.ToListAsync());
        }

        // GET: Requisicoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requisicao == null)
            {
                return NotFound();
            }

            return View(requisicao);
        }

        // GET: Requisicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requisicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Item,Data_Requesicao,Estado_Requesicao,Justificacao,Observacao,Id")]*/ Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                requisicao.Id = Guid.NewGuid();
                _context.Add(requisicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requisicao);
        }

        // GET: Requisicoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao.FindAsync(id);
            if (requisicao == null)
            {
                return NotFound();
            }
            return View(requisicao);
        }

        // POST: Requisicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, /*[Bind("Item,Data_Requesicao,Estado_Requesicao,Justificacao,Observacao,Id")]*/ Requisicao requisicao)
        {
            if (id != requisicao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisicaoExists(requisicao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(requisicao);
        }

        // GET: Requisicoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requisicao == null)
            {
                return NotFound();
            }

            return View(requisicao);
        }

        // POST: Requisicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var requisicao = await _context.Requisicao.FindAsync(id);
            _context.Requisicao.Remove(requisicao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisicaoExists(Guid id)
        {
            return _context.Requisicao.Any(e => e.Id == id);
        }
    }
}
