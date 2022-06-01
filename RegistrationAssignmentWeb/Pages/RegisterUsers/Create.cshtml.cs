using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationAssignmentWeb.Model;
using RegistrationAssignmentWeb.Repository;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RegistrationAssignmentWeb.Pages.RegisterUsers
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;        

        // public RegisterUser RegisterUser { get; set; }
        public RegisterUserViewModel RegisterUser { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }

        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            //CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
            //{
            //    Text = i.Name,
            //    Value = i.CategoryId.ToString()
            //});            

            CategoryList = new Utilities().APICall().Select(i => new SelectListItem
            {
                Text = i.name,
                Value = i.categoryID.ToString()
            });
        }

        public async Task<IActionResult> OnPost()
        {            
            //if (ModelState["RegisterUser.EventDays"].Errors.Count <= 0)
            //{
            //    foreach (var eventDay in RegisterUser.EventDays)
            //    {
            //        RegisterUser.RegisterUserEveDays.Add(new RegisterUserEventDays() { Days = eventDay });
            //    }
            //}

            if (ModelState.IsValid)
            {
                RegisterUser _registerUser = new RegisterUser()
                {
                    Name = RegisterUser.Name,
                    Email = RegisterUser.Email,
                    Gender = RegisterUser.Gender,
                    AdditionalRequest = RegisterUser.AdditionalRequest,
                    InterestArea = RegisterUser.InterestArea,
                    RegisterDate = (DateTime) RegisterUser.RegisterDate
                };

                foreach (var eventDay in RegisterUser.EventDays)
                {
                    _registerUser.RegisterUserEveDays.Add(new RegisterUserEventDays() { Days = eventDay });
                }

                _unitOfWork.RegisterUser.Add(_registerUser);
                _unitOfWork.Save();
                TempData["success"] = "Register created successfully";
                return RedirectToPage("Index");
            }

            CategoryList = new Utilities().APICall().Select(i => new SelectListItem
            {
                Text = i.name,
                Value = i.categoryID.ToString()
            });

            return Page();
        }
       
    }
}
