using Microsoft.AspNetCore.Mvc;
using SMM.Application.Services;

namespace SMM.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FolderController : ControllerBase
    {
        private readonly FolderService folderService;

        public FolderController(FolderService folderService)
        {
            this.folderService = folderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await folderService.GetAll());
        }
    }
}
