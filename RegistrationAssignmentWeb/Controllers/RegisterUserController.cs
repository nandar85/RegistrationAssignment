using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationAssignmentWeb.Repository;

namespace RegistrationAssignmentWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterUserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegisterUserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get(string? status = null)
        {

            var RegisterUserList = _unitOfWork.RegisterUser.GetAll(includeProperties: "RegisterUserEveDays");
            var CategoryList = new Utilities().APICall();

            var results = RegisterUserList.Join(
                CategoryList,
                ru => ru.InterestArea,
                c => c.categoryID,
                (reg, cat) => new { RegId = reg.Id, reg.Name, reg.Email, reg.Gender, RegisterDate = reg.RegisterDate.ToString("dd/MM/yyyy"), EventDays = string.Join(", ",reg.RegisterUserEveDays.Select(x=>x.Days).ToArray()), CatName = cat.name, reg.AdditionalRequest }).ToList();

            return Json(new { data = results });
        }
    }
}
