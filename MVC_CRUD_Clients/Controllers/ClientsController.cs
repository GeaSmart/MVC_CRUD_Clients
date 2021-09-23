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
        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult AddEdit(int id=0)
        {
            return View(new Client());
        }
    }
}
