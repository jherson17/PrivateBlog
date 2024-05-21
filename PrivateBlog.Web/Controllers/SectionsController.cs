using Microsoft.AspNetCore.Mvc;
using PrivateBlog.Web.Core;
using PrivateBlog.Web.Data;
using PrivateBlog.Web.Data.Entities;
using PrivateBlog.Web.Services;
//using AspNetCoreHero.ToastNotification.Abstractions;
//using AspNetCoreHero.ToastNotification.Notyf;

namespace PrivateBlog.Web.Controllers
{
    public class SectionsController : Controller
    {
        private readonly DataContext _context;
        private readonly ISectionsService _SectionService;

        public SectionsController(DataContext context, ISectionsService SectionService/*, /*INotyfService notifyService*/)
        {
            _context = context;  // Asigna el contexto de datos al campo privado
            _SectionService = SectionService; // Asigna el servicio de autores recibido al campo privado.
           
        }
        [HttpGet]
        // Acción para mostrar la lista de autores.
        //click derecho - añador vista (debe tener el mismo nombre)
        public async Task<IActionResult> Index()
        {
            // Obtiene la lista de autores de forma asincrónica desde el servicio de autores.
            Response<List<Section>> response = await _SectionService.GetListAsyc();
            

            // Devuelve una vista pasando la lista de autores como modelo.
            return View(response.Result);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
