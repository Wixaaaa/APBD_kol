using APBD_kol.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController(IClientService clientService) : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetClient(int id)
        {
            try
            {
                var client = await clientService.GetClientAsync(id);
                return Ok(client);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}