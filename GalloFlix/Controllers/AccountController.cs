using GalloFlix.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using GalloFlix.Models;


namespace GalloFlix.Controllers;

    [Authorize(Roles = "Administrador")]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(ILogger<AccountController> logger, 
        SignInManager<AppUser> signInManager, 
        UserManager<AppUser> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            LoginDto login = new();
            login.ReturnUrl = returnUrl ?? Url.Content("~/");
            return View(login);
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }
    }
