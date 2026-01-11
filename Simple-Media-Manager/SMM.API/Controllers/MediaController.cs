using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SMM.Application.Services;
using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;
using SMM.Domain.Interfaces.Services;
using SMM.Persistence.Context;

namespace SMM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly IMediaService mediaService;

        public MediaController(IMediaService mediaService)
        {
            this.mediaService = mediaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediaService.GetAll());
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await mediaService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(MediaCreateDto media)
        {
            return Ok(await mediaService.Add(media));
        }

        [HttpPut]
        public async Task<IActionResult> Put(long id, [FromBody] MediaPutDTO updatedEntity)
        {
            return Ok(await mediaService.Put(id, updatedEntity));
        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> Delete (long id)
        {
            return Ok(await mediaService.Delete(id));
        } 
    }
}
