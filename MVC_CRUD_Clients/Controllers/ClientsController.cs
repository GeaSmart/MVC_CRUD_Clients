using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_Clients.Entities;
using MVC_CRUD_Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD_Clients.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDBContext context;

        public ClientsController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Clients.ToList());            
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int id=0)
        {
            var cliente = await context.Clients.FindAsync(id);
            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(Client client)
        {
            if (ModelState.IsValid)
            {
                if (client.Id == 0)
                    context.Add(client);
                else
                    context.Update(client);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await context.Clients.FindAsync(id);
            context.Clients.Remove(cliente);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
