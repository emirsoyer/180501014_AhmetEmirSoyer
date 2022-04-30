using Business.Concrete;
using DAL.EF;
using Microsoft.AspNetCore.Mvc;

namespace Zahnklinik.Controllers
{
    public class UserContoller : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepo()); 
        public IActionResult Index()
        {
            var val = userManager.GetAll();
            return View(val);
        }
    }
}
