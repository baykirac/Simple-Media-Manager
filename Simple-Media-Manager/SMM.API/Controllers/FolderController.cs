using Microsoft.AspNetCore.Mvc;
using SMM.Domain.DTOs.FolderDTOs;
using SMM.Domain.Interfaces.Services;

namespace SMM.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FolderController : ControllerBase
    {
        private readonly IFolderService folderService;

        public FolderController(IFolderService folderService)
        {
            this.folderService = folderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await folderService.GetAllAsync());
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await folderService.GeyByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FolderCreateDTO dto)
        {
            return Ok(await folderService.AddAsync(dto));
        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] FolderPutDTO dto)
        {
            return Ok(await folderService.UpdateAsync(id, dto));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete (long id)
        {
            return Ok(await folderService.DeleteAsync(id));
        }

    }
}
