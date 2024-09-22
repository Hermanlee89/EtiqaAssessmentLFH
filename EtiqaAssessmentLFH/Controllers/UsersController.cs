using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EtiqaAssessmentLFH.Models;
using EtiqaAssessmentLFH.Data;

namespace EtiqaAssessmentLFH.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: Users
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // GET: Users/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View(new userModel());
        }
        // POST: Users/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create(userModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    user.CreatedTime = DateTime.Now;
                    user.UpdateTime = user.CreatedTime;
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(user);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error on Creating user data");
            }
        }

        // GET: Users/Edit/5
        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        // POST: Users/Edit/5
        [HttpPost("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, userModel user)
        {
            try { 
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {                
                user.UpdateTime = DateTime.Now;
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error on editing user data");
            }
        }

        // GET: Users/Delete/5
        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting user data");
            }
        }

    }
}
