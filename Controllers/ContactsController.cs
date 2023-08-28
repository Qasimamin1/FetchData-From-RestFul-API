using Microsoft.AspNetCore.Mvc;
using ContactsMvcApp.Services;
using System.Threading.Tasks;

namespace ContactsMvcApp.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApiService _apiService;

        public ContactsController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _apiService.GetContactsAsync();
            return View(contacts);
        }
    }
}
