using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public MovieController()
        {

        }


        [HttpGet]
        public Task<ActionResult<ServiceResponse<int>>> GetMovies()
        {
            var response = new ServiceResponse<int>
            {
                Data = 1
            };

            if (response.Data == null)
            {
                return Task.FromResult<ActionResult<ServiceResponse<int>>>(BadRequest("NOOOO"));
            }

            return Task.FromResult<ActionResult<ServiceResponse<int>>>(Ok(response));
        }
    }
}
