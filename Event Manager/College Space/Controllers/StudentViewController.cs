using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using College_Space.Data;
using College_Space.Models;

namespace College_Space.Controllers
{
    public class StudentViewController : Controller
    {
        private readonly College_SpaceContext _context;

        public StudentViewController(College_SpaceContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> StudentViewTable()
        {
            return View(await _context.Events.ToListAsync());
        }

        private bool EventsExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}

