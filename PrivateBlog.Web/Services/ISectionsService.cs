using Microsoft.EntityFrameworkCore;
using PrivateBlog.Web.Core;
using PrivateBlog.Web.Data;
using PrivateBlog.Web.Data.Entities;

namespace PrivateBlog.Web.Services
{
    public interface ISectionsService
    {
        public Task<Response<List<Section>>> GetListAsyc();
    }


    // Implementación del servicio de Sections.
    public class SectionServices : ISectionsService
    {
        private readonly DataContext _context; // Campo privado para el contexto de datos.

        // Constructor que inyecta el contexto de datos.
        public SectionServices(DataContext context)
        {
            _context = context;
        }

        // Implementación del método para obtener la lista de Sections de manera asíncrona.
        public async Task<Response<List<Section>>> GetListAsyc()
        {
            try
            {
                // Obtiene la lista de autores de la base de datos de manera asíncrona.
                List<Section> list = await _context.Sections.ToListAsync();

                // Crea una respuesta exitosa con la lista obtenida.
                Response<List<Section>> response = new Response<List<Section>>
                {
                    IsSuccess = true,
                    Message = "Lista Obtenida",
                    Result = list
                };

                return response;
            }
            catch (Exception ex)
            {
                // En caso de excepción, crea una respuesta de error con el mensaje de la excepción.
                return new Response<List<Section>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}