using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerWebsite.Areas.Identity.Pages.Account
{
    

    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {

            _userManager = userManager;
            _signInManager = signInManager;

        }
        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }


        public void OnGet()
        {
            ReturnUrl = Url.Content("~/");
        }
        public async Task<IActionResult> OnPostAsync()
        {
            ReturnUrl = Url.Content("~/");
            if (ModelState.IsValid)

            {
                var userExists = await _userManager.FindByNameAsync(Input.Name);
                if (userExists != null)
                {
                    ModelState.AddModelError(string.Empty, "This username is already taken.");
                    return Page();
                }
                var identity = new IdentityUser { UserName = Input.Name};
                var result = await _userManager.CreateAsync(identity, Input.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(identity,isPersistent: false);
                    return LocalRedirect(ReturnUrl);
                }
            }
 
            return Page();
        }
        public class InputModel
        {
            [Required]
            public string Name { get; set; }
            //[Required]
            //[EmailAddress] public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
    
}
