using BackEndProject.Helpers;
using BackEndProject.Models;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Contollers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {

            if (ModelState.IsValid)
            {
                AppUser newuser = new AppUser
                {
                    Fullname=registerVM.Fullname,
                    UserName=registerVM.Fullname,
                    Email = registerVM.Email,

                };

                IdentityResult identityResult = await _userManager.CreateAsync(newuser, registerVM.Password);


                if (identityResult.Succeeded)
                {
                    // Generate Token for user

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(newuser);
                    var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { userName = newuser.UserName, code }, Request.Scheme);
                    var mailto = newuser.Email;
                    var messageBody = $"<p>Emaili təsdiqləmək üçün <a href=\"{confirmationLink}\"> buraya daxil </a>  olun</p>" +
                        $"</br><p>Qeydiyatı yalnız bir dəfə təsdiqləyə bilərsiz</p>";
                    var messageSubject = "Email Təsdiqləmə";
                    await Helper.SendMessageAsync(messageSubject, messageBody, newuser.Email);
                    await _userManager.AddToRoleAsync(newuser, Roles.Admin.ToString());

                    return RedirectToAction("VerifyEmail", "Account");
                }
                else
                {
                    foreach (IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(registerVM);
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(loginVM.UserName);
                if (user != null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError("", "Please confirim your email");
                        return View(loginVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View(loginVM);
                }
                var signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, true);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

            }

            return View(loginVM);

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult VerifyEmail()
        {
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userName, string code)
        {
            if (userName == null || code == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                TempData["Response"] = "Email has been confirmed";
                return RedirectToAction("Login", "Account");
            }
            else
                return NotFound();
        }

        #region Create Role
        public async Task CreateRoles()
        {
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                if(!(await _roleManager.RoleExistsAsync(role.ToString())))
                {
                    await _roleManager.CreateAsync(new IdentityRole {Name=role.ToString() });
                }
            }
        }
        #endregion
    }
}
