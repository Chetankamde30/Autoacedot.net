using DemoRegAndLoginWithIdentity.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DemoRegAndLoginWithIdentity.Controllers
{

    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {

      
        private readonly RoleManager<IdentityRole> _roleManager;

       
        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddService()
        {
            return View();
        }
        public IActionResult GetBooking()
        {
            return View();
        }
        public IActionResult GetContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleStore rolestore)
        {
            var alreadyAdded = await _roleManager.RoleExistsAsync(rolestore.RoleName);

            if (!alreadyAdded)
            {
                await _roleManager.CreateAsync(new IdentityRole(rolestore.RoleName));
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
